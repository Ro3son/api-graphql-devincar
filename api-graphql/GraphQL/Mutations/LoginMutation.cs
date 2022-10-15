using System.IdentityModel.Tokens.Jwt;
using System.Text;
using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class AuthMutation
    {       
        public string UserLogin([Service] IOptions<TokenSettings> tokenSettings, 
        [Service] IUserRepository repository, 
        LoginInput login)
        {
            var currentUser = repository.AuthUser(login);
            if (currentUser != null)
            {
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Value.Key));
                var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

                var jwtToken = new JwtSecurityToken(
                    issuer: tokenSettings.Value.Issuer,
                    audience: tokenSettings.Value.Audience,                    
                    signingCredentials: credentials,
                    expires: DateTime.Now.AddMinutes(25)
                );

                string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
                return token;

            }
            return string.Empty;
        }
    }
}