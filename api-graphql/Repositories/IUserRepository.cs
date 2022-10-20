using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<Usuario> GetUsers();
        Usuario GetUser(int id);
        Usuario AuthUser(LoginInput login);
    }
}
