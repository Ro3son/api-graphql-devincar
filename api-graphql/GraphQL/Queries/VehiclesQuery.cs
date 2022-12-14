using DevInCar.GraphQL.Models;
using DevInCar.GraphQL.Repositories;

namespace DevInCar.GraphQL.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class VeiculosQuery
    {
        [GraphQLName("buscar_veiculos")]
        [GraphQLDescription("Método para retornar todos os veículos.")]
        public IEnumerable<Veiculo> Get(

            [Service] IVehicleRepository repository

        ) => repository.GetVehicles();

        [GraphQLName("buscar_veiculos_por_tipo")]
        [GraphQLDescription("Método para retornar veículos por tipo.")]
        public IEnumerable<Veiculo> GetByType(

            ETipoVeiculo tipo,

            [Service] IVehicleRepository repository
            
        ) => repository.GetByTypeVehicle(tipo);

        [GraphQLName("buscar_veiculos_por_status")]
        [GraphQLDescription("Método para retornar veículos por status.")]
        public IEnumerable<Veiculo> GetByStatus(

            EStatusVeiculo status,

            [Service] IVehicleRepository repository
            
        ) => repository.GetByStatusVehicle(status);

        [GraphQLName("buscar_veiculo_com_maior_preco")]
        [GraphQLDescription("Método retorna o veículo com maior preço.")]
        public IEnumerable<Veiculo> GetByMaxPrice(

            [Service] IVehicleRepository repository
            
        ) => repository.GetMaxPrice();

        [GraphQLName("buscar_veiculo_com_menor_preco")]
        [GraphQLDescription("Método retorna o veículo com menor preço.")]
        public IEnumerable<Veiculo> GetByMinPrice(

            [Service] IVehicleRepository repository
            
        ) => repository.GetMinPrice();
    }
}
