using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<Veiculo> GetVehicles();
        IEnumerable<Veiculo> GetByTypeVehicle(ETipoVeiculo tipoVeiculo);
        IEnumerable<Veiculo> GetByStatusVehicle(EStatusVeiculo statusVeiculo);
        IEnumerable<Veiculo> GetMaxPrice();
        IEnumerable<Veiculo> GetMinPrice();
        Veiculo SellVehicle(int veiculoId, string cpf);
        void AddVehicle(Veiculo veiculo);
    }
}