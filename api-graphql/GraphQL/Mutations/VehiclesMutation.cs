using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;
using DevInCar.GraphQL.Subscriptions;
using HotChocolate.Subscriptions;

namespace DevInCar.GraphQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculosMutation
    {
        [GraphQLName("vender_veiculo")]
        [GraphQLDescription("Método para vender veículo.")]
        public Veiculo SellVehicle(
            int veiculoId, string cpf, 
            [Service] IVehicleRepository _repository,
            [Service] ITopicEventSender _eventSender)
        {
            try 
            { 
                var veiculo = _repository.SellVehicle(veiculoId, cpf);

                _eventSender
                    .SendAsync(nameof(VeiculosSubscription.VeiculoAdicionado), veiculo)
                    .ConfigureAwait(false);
                
                return veiculo;
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível vender o veículo!");
            }
        }

        [GraphQLName("criar_veiculo")]
        [GraphQLDescription("Método para criar um novo veículo.")]
        public Veiculo PostVeiculo(
            VeiculoInput input,
            [Service] IVehicleRepository _repository,
            [Service] ITopicEventSender _eventSender
        )
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo.VeiculoId = input.VeiculoId;
                veiculo.Chassi = input.Chassi;
                veiculo.Placa = input.Placa;
                veiculo.NomeModelo = input.NomeModelo;

                _repository.AddVehicle(veiculo);

                _eventSender
                    .SendAsync(nameof(VeiculosSubscription.VeiculoAdicionado), veiculo)
                    .ConfigureAwait(false);

                return veiculo;
            }
            catch (System.Exception)
            {
                throw new Exception("Não foi possível criar o veículo!");
            }
        }

        [GraphQLName("alterar_cor")]
        [GraphQLDescription("Método para alterar a cor de um veículo.")]
        public bool PutColor(int veiculoId, string cor, [Service] IVehicleRepository _repository)
        {
            try
            {
                var model = new Veiculo();
                model.VeiculoId = veiculoId;
                model.Cor = cor;

                return _repository.UpdateColor(veiculoId, model);

            }
            catch(System.Exception)
            {
                throw new Exception("Não foi possível alterar a cor!");
            }
        }

        [GraphQLName("alterar_valor")]
        [GraphQLDescription("Método para alterar o valor de um veículo.")]
        public bool PutValue(int veiculoId, decimal preco, [Service] IVehicleRepository _repository)
        {
            try
            {
                var model = new Veiculo();
                model.VeiculoId = veiculoId;
                model.Preco = preco;

                return _repository.UpdatePrice(veiculoId, model);

            }
            catch(System.Exception)
            {
               throw new Exception("Não foi possível alterar o valor!");
            }
        }
    }
}
