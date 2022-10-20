namespace DevInCar.GraphQL.Models
{
    public class VeiculoInput
    {
        public int VeiculoId { get; set; }
        public string? NomeModelo { get; set; }
        public string? Chassi { get; set; }
        public string? Placa { get; set; }
    }
}
