using System.ComponentModel.DataAnnotations.Schema;

namespace DevInCar.GraphQL.Models
{
    public class VendaModel : Veiculo
    {
        public int VendaId { get; set; }
        public string? CPFDoComprador { get; set; }
        public string? Data { get; set; }
    }
}