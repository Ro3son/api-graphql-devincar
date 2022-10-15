using HotChocolate.AspNetCore.Authorization;

namespace DevInCar.GraphQL.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Authorize]
        public string? UserName { get; set;}

        [Authorize]
        public string? Password { get; set;}
    }
}