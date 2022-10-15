using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Repositories
{
    public interface IUserRepository
    {
        Usuario AuthUser(LoginInput login);
    }
}
