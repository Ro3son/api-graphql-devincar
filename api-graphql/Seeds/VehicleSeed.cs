using DevInCar.GraphQL.Models;

namespace DevInCar.GraphQL.Seed
{
    public class VeiculoSeed
    {
        public static List<Veiculo> VeiculoSeeder { get; set; } = new List<Veiculo>()
        {
            new Veiculo()
                {
                    VeiculoId = 1,
                    Chassi = "CHASSIGHJOLNQSED4",
                    Placa = "CAR3XFV",
                    NomeModelo = "Fiat Uno",
                    DataFabricacao = 2019,
                    Potencia = 75.0,
                    Cor = "Cinza",
                    Preco = 43.807M,
                    Combustivel = "Gasolina",
                    Tipo = ETipoVeiculo.Carro,
                    Status = EStatusVeiculo.Disponivel,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 2,
                    Chassi = "CHASSIKSRAL4DOKCK",
                    Placa = "CAR3FFV",
                    NomeModelo = "VW GOL",
                    DataFabricacao = 2018,
                    Potencia = 82.0,
                    Cor = "Preto",
                    Preco = 47.507M,
                    Combustivel = "Flex",
                    Tipo = ETipoVeiculo.Carro,
                    Status = EStatusVeiculo.Disponivel,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 3,
                    Chassi = "CHASSIEFT90SL35HL",
                    Placa = "CAR3XFV",
                    NomeModelo = "Renault Duster",
                    DataFabricacao = 2017,
                    Potencia = 118.0,
                    Cor = "Branco",
                    Preco = 67.907M,
                    Combustivel = "Gasolina",
                    Tipo = ETipoVeiculo.Carro,
                    Status = EStatusVeiculo.Vendido,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 4,
                    Chassi = "CHASSI12454T4T456",
                    Placa = "PLC1234",
                    NomeModelo = "CG 160 Titan",
                    DataFabricacao = 2022,
                    Tipo = ETipoVeiculo.Moto,
                    Potencia = 15.1,
                    Cor = "Cinza",
                    Preco = 14.620M,
                    Status = EStatusVeiculo.Disponivel,
                    Rodas = 2
                },
            new Veiculo()
                {
                    VeiculoId = 5,
                    Chassi = "CHASSI123DFGEVGBU",
                    Placa = "BRA2S5D",
                    NomeModelo = "CG 160 Fan",
                    DataFabricacao = 2017,
                    Tipo = ETipoVeiculo.Moto,
                    Potencia = 15.1,
                    Cor = "Azul",
                    Preco = 13.480M,
                    Status = EStatusVeiculo.Disponivel,
                    Rodas = 2
                },
            new Veiculo()
                {
                    VeiculoId = 6,
                    Chassi = "CHASSIQER234GYHJC",
                    Placa = "CBA3S5K",
                    NomeModelo = "CG 160 Cargo",
                    DataFabricacao = 2022,
                    Tipo = ETipoVeiculo.Moto,
                    Potencia = 15.1,
                    Cor = "Branco",
                    Preco = 13.650M,
                    Status = EStatusVeiculo.Vendido,
                    Rodas = 2
                },
            new Veiculo()
                {
                    VeiculoId = 7,
                    Chassi = "CHASSIFA3DVFOLM1D7",
                    Placa = "P1CKUP7",
                    NomeModelo = "Fiat Toro",
                    DataFabricacao = 2021,
                    Tipo = ETipoVeiculo.Camionete,
                    Potencia = 139.0,
                    Cor = "Branco",
                    Preco = 103.907M,
                    Combustivel = "Diesel",
                    CapacidaDeCarga = 1820,
                    Status = EStatusVeiculo.Disponivel,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 8,
                    Chassi = "CHASSIYUI789O50HL",
                    Placa = "TYT678X",
                    NomeModelo = "Toyota Hilux",
                    DataFabricacao = 2021,
                    Tipo = ETipoVeiculo.Camionete,
                    Potencia = 204.0,
                    Cor = "Prata",
                    Preco = 238.907M,
                    Combustivel = "Gasolina",
                    CapacidaDeCarga = 1920,
                    Status = EStatusVeiculo.Disponivel,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 9,
                    Chassi = "CHASSL3ADFTTH7OGH",
                    Placa = "CHVR3FL",
                    NomeModelo = "Chevrolet s10",
                    DataFabricacao = 2021,
                    Tipo = ETipoVeiculo.Camionete,
                    Potencia = 206.0,
                    Cor = "Prata",
                    Preco = 113.907M,
                    Combustivel = "Diesel",
                    CapacidaDeCarga = 1850,
                    Status = EStatusVeiculo.Vendido,
                    Portas = 4
                },
            new Veiculo()
                {
                    VeiculoId = 10,
                    Chassi = "CHASSI123AZXSDCFE4",
                    Placa = "TRI1237",
                    NomeModelo = "Tricity 300",
                    DataFabricacao = 2021,
                    Tipo = ETipoVeiculo.Triciclo,
                    Potencia = 20.6,
                    Cor = "Azul",
                    Preco = 48.650M,
                    Status = EStatusVeiculo.Disponivel,
                    Rodas = 3
                },
            new Veiculo()
                {
                    VeiculoId = 11,
                    Chassi = "CHASSI678GTUHJKXOL",
                    Placa = "CITY123",
                    NomeModelo = "Tricity 125",
                    DataFabricacao = 2022,
                    Tipo = ETipoVeiculo.Triciclo,
                    Potencia = 9.0,
                    Cor = "Branco",
                    Preco = 24.009M,
                    Status = EStatusVeiculo.Disponivel,
                    Rodas = 3
                },
            new Veiculo()
                {
                    VeiculoId = 12,
                    Chassi = "CHASSIRTYMKO5B8M0Z",
                    Placa = "BA12K45",
                    NomeModelo = "Tricity 125",
                    DataFabricacao = 2021,
                    Tipo = ETipoVeiculo.Triciclo,
                    Potencia = 20.6,
                    Cor = "Branco",
                    Preco = 58.805M,
                    Status = EStatusVeiculo.Vendido,
                    Rodas = 3
                }
        };
    }
}
