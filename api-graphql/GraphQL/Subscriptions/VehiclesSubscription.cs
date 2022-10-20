using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Subscriptions
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VeiculosSubscription 
    {
        [GraphQLName("subscription_veiculo_adicionado")]

        [Subscribe]
        public Veiculo VeiculoAdicionado([EventMessage] Veiculo mensagem) => mensagem;

        [GraphQLName("subscription_veiculo_vendido")]
        
        [Subscribe]
        public Veiculo VeiculoVendido([EventMessage] Veiculo mensagem) => mensagem;
    }
}