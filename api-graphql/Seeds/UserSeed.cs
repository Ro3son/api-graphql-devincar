using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Seed
{
    public class UsuarioSeed
    {
        public static List<Usuario> UsuarioSeeder { get; set; } = new List<Usuario>()
        {
            new Usuario
            {
                Id = 1,
                UserName = "User1",
                Password = "V4eY8fFKDg"
            },
            new Usuario
            {
                Id = 2,
                UserName = "User2",
                Password = "GJARed1TU0"
            },
            new Usuario
            {
                Id = 3,
                UserName = "User3",
                Password = "NSYfC9yLzt"
            }
        };
    }
}
