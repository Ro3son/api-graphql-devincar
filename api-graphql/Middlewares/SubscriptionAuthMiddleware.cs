using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.AspNetCore.Subscriptions.Messages;
using HotChocolate.Execution;
using Microsoft.IdentityModel.Tokens;

namespace DevInCar.GraphQL.Middlewares
{
    public static class ValidateJWT
    {
        public static bool ValidateToken(string authToken)
        {
            var key = "kqiLgDdyYReWjzGdetuq6ZMKckd5DATEWkmqlwkV";
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidIssuer = "localhost:7008",
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidAudience = "API",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
            };

            SecurityToken validatedToken;
            try
            {
                IPrincipal principal = tokenHandler.ValidateToken(
                    authToken,
                    validationParameters,
                    out validatedToken
                );
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }
    }

    public class SubscriptionAuthMiddleware : ISocketSessionInterceptor
    {
        public async ValueTask OnCloseAsync(
            ISocketConnection connection,
            CancellationToken cancellationToken
        )
        { }

        public async ValueTask OnRequestAsync(
            ISocketConnection connection,
            IQueryRequestBuilder requestBuilder,
            CancellationToken cancellationToken
        )
        { }

        /* We don't need the above two methods, just this one */
        public async ValueTask<ConnectionStatus> OnConnectAsync(
            ISocketConnection connection,
            InitializeConnectionMessage message,
            CancellationToken cancellationToken
        )
        {
            try
            {
            
                var jwtHeader = message.Payload["Authorization"] as string;

                if (string.IsNullOrEmpty(jwtHeader) || !jwtHeader.StartsWith("Bearer "))
                    return ConnectionStatus.Reject("Unauthorized");

                var token = jwtHeader.Replace("Bearer ", "");

                var response = ValidateJWT.ValidateToken(token);
                Console.WriteLine($"Pode se conectar: {response}");
                if (!response)
                {
                    return ConnectionStatus.Reject(
                        "Sem autorização para se conectar ao websocket."
                    );
                }
                connection.HttpContext.Request.Headers.Authorization = jwtHeader;

                return ConnectionStatus.Accept();
            }
            catch (Exception ex)
            {
                return ConnectionStatus.Reject("Sem autorização para se conectar ao websocket.");
            }
        }
    }
}
