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
    }
}
