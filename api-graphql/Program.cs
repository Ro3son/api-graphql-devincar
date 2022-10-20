using System.Text;
using DevInCar.GraphQL.Context;
using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Mutations;
using DevInCar.GraphQL.Queries;
using DevInCar.GraphQL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<DevContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"))
);

builder.Services.AddSingleton<IVehicleRepository, VehicleRepository>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    
    .AddType<Usuario>()
    .AddType<Veiculo>()
    .AddType<VeiculoModel>()

    .AddQueryType()
        .AddTypeExtension<UsuariosQuery>()
       .AddTypeExtension<VeiculosQuery>()

    .AddMutationType()
        .AddTypeExtension<AuthMutation>()
        .AddTypeExtension<VeiculosMutation>();  

builder.Services
    .Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
builder.Services
    .AddAuthorization();
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
        };
    });

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseCors("corsapp");
app.UseHttpsRedirection();
app.UseRouting();

app.UseWebSockets();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint => 
    endpoint.MapGraphQL());

app.Run();
