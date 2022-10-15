using HotChocolate.AspNetCore.Authorization;

namespace DevInCar.GraphQL.Models
{
    public abstract class VeiculoModel
    {
        [Authorize]
        public string? Chassi { get; set; }

        [Authorize]
        public string? Placa { get; set; }
        public string? NomeModelo { get; set; }
        public int DataFabricacao { get; set; }
        public string? Cor { get; set; }
        public decimal Preco { get; set; }
        public int CapacidaDeCarga { get; set; }
        public ETipoVeiculo Tipo { get; set; }
        public EStatusVeiculo Status { get; set; }
    }
}
