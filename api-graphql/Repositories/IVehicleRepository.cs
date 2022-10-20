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
        Veiculo AddVehicle(Veiculo veiculo);
        bool UpdateColor(int id, Veiculo cor);
        bool UpdatePrice(int id, Veiculo preco);
    }
}