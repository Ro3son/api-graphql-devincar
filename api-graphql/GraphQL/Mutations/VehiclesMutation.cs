using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculosMutation
    {
        [GraphQLName("vender_veiculo")]
        [GraphQLDescription("Método para vender veículo.")]
        public Veiculo SellVehicle(int id, string cpf, [Service] IVehicleRepository _repository) =>
            _repository.SellVehicle(id, cpf);

        [GraphQLName("post_veiculo")]
        [GraphQLDescription("Método para criar novo veículo.")]
        public Veiculo PostVeiculo(
            int veiculoId,
            string chassi,
            string placa,
            string nomeModelo,
            
            [Service] IVehicleRepository _repository
        )
        {
            Veiculo veiculo = new Veiculo();
            veiculo.VeiculoId = veiculoId;
            veiculo.Chassi = chassi;
            veiculo.Placa = placa;
            veiculo.NomeModelo = nomeModelo;

            _repository.AddVehicle(veiculo);

            return veiculo;
        }
    }
}
