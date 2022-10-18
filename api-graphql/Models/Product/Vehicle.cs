namespace DevInCar.GraphQL.Models
{
    public class Veiculo : VeiculoModel
    {
        public int VeiculoId { get; set; }
        public double Potencia { get; set; }
        public string? Combustivel { get; set; }
        public int Portas { get; set; }
        public int Rodas { get; set; }
    }
}
