using DevInCar.GraphQL.Context;
using DevInCar.GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace DevInCar.GraphQL.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly IDbContextFactory<DevContext> _context;

        public VehicleRepository(IDbContextFactory<DevContext> context)
        {
            _context = context;
        }

        public IEnumerable<Veiculo> GetVehicles()
        {
            using (var context = _context.CreateDbContext())
            {
                return context.Veiculos.ToList();
            }
        }

        public IEnumerable<Veiculo> GetByTypeVehicle(ETipoVeiculo tipoVeiculo)
        {
            using (var context = _context.CreateDbContext())
            {
                return context.Veiculos.Where(t => t.Tipo == tipoVeiculo).ToList();
            }
        }

        public IEnumerable<Veiculo> GetByStatusVehicle(EStatusVeiculo statusVeiculo)
        {
            using (var context = _context.CreateDbContext())
            {
                return context.Veiculos.Where(t => t.Status == statusVeiculo).ToList();
            }
        }

        public IEnumerable<Veiculo> GetMaxPrice()
        {
            using (var context = _context.CreateDbContext())
            {
                var max = context.Veiculos.Max(x => x.Preco);

                return context.Veiculos.Where(p => p.Preco == max).ToList();
            }
        }

        public IEnumerable<Veiculo> GetMinPrice()
        {
            using (var context = _context.CreateDbContext())
            {
                var min = context.Veiculos.Min(x => x.Preco);

                return context.Veiculos.Where(p => p.Preco == min).ToList();
            }
        }

        public Veiculo SellVehicle(int veiculoId)
        {
            using (var context = _context.CreateDbContext())
            {
                var veiculo = context.Veiculos
                    .Where(x => x.VeiculoId == veiculoId)
                    .FirstOrDefault();
                
                return veiculo;
            }
        }
    }
}
