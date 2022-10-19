using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculosMutation
    {
        [GraphQLName("vender_veiculo")]
        [GraphQLDescription("Método para vender veículo.")]
        public Veiculo SellVehicle(
            int id, 
            string cpf, 
            [Service] IVehicleRepository _repository) =>
            _repository.SellVehicle(id, cpf);

        [GraphQLName("criar_veiculo")]
        [GraphQLDescription("Método para criar um novo veículo.")]
        public bool PostVeiculo(
            VeiculoInput input,
            [Service] IVehicleRepository _repository
        )
        {
            Veiculo veiculo = new Veiculo()
            {
                VeiculoId = input.VeiculoId,
                Chassi = input.Chassi,
                Placa = input.Placa,
                NomeModelo = input.NomeModelo
            };

            return _repository.AddVehicle(veiculo);

        }

        [GraphQLName("alterar_cor")]
        [GraphQLDescription("Método para alterar a cor de um veículo.")]
        public bool PutColor(int veiculoId, string cor, [Service] IVehicleRepository _repository)
        {
            var model = new Veiculo();
            model.VeiculoId = veiculoId;
            model.Cor = cor;

            return _repository.UpdateColor(veiculoId, model);
        }

        [GraphQLName("alterar_valor")]
        [GraphQLDescription("Método para alterar o valor de um veículo.")]
        public bool PutValue(int veiculoId, decimal preco, [Service] IVehicleRepository _repository)
        {
            var model = new Veiculo 
            { 
                VeiculoId = veiculoId, 
                Preco = preco 
            };

            return _repository.UpdateColor(veiculoId, model);
        }
    }
}
