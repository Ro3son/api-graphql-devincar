using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculosMutation
    {
        [GraphQLName("vender_veiculo")]
        [GraphQLDescription("Método para vender veículo.")]
        public Veiculo SellVehicle(int id, string cpf, [Service] IVehicleRepository _repository) =>
            _repository.SellVehicle(id, cpf);

        [GraphQLName("criar_veiculo")]
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

        [GraphQLName("alterar_cor")]
        [GraphQLDescription("Método para alterar a cor de um veículo.")]
        public bool PutVeiculo(int id, string cor, [Service] IVehicleRepository _repository)
        {
            var model = new Veiculo 
            { 
                VeiculoId = id, 
                Cor = cor, 
            };

            return _repository.UpdateColor(id, model);
        }
    }
}
