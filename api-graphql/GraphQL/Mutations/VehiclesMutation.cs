using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculosMutation
    {
        [GraphQLName("vender_veiculo")]
        [GraphQLDescription("Método para vender veículo.")]
        public Veiculo SellVehicle(int id, [Service] IVehicleRepository repository) =>
            repository.SellVehicle(id);
    }
}
