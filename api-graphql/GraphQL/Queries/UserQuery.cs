using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;
using HotChocolate.AspNetCore.Authorization;

namespace DevInCar.GraphQL.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class UsuariosQuery
    {
        [Authorize]
        [GraphQLName("buscar_usuarios")]
        [GraphQLDescription("Método para retornar todos os usuários cadastrados.")]
        public IEnumerable<Usuario> Get([Service] IUserRepository repository) =>
            repository.GetUsers();

        [GraphQLName("buscar_usuario_por_id")]
        [GraphQLDescription("Método para retornar o usuário por id.")]
        public Usuario GetUser([Service] IUserRepository repository, int userID) =>
            repository.GetUser(userID);
    }
}
