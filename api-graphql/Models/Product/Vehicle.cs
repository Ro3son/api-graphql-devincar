namespace DevInCar.GraphQL.Models
{
    public class Veiculo : VeiculoModel, IVenda
    {
        public int VeiculoId { get; set; }
        public double Potencia { get; set; }
        public string? Combustivel { get; set; }
        public int Portas { get; set; }
        public int Rodas { get; set; }
        public int VendaId { get; set; }
        public string? CPF { get; set; }
    }
}
