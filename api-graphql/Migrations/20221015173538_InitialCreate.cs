using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_graphql.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Potencia = table.Column<double>(type: "float", nullable: false),
                    Combustivel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portas = table.Column<int>(type: "int", nullable: false),
                    Rodas = table.Column<int>(type: "int", nullable: false),
                    Chassi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeModelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataFabricacao = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CapacidaDeCarga = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "V4eY8fFKDg", "User1" },
                    { 2, "GJARed1TU0", "User2" },
                    { 3, "NSYfC9yLzt", "User3" }
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "VeiculoId", "CapacidaDeCarga", "Chassi", "Combustivel", "Cor", "DataFabricacao", "NomeModelo", "Placa", "Portas", "Potencia", "Preco", "Rodas", "Status", "Tipo" },
                values: new object[,]
                {
                    { 1, 0, "CHASSIGHJOLNQSED4", "Gasolina", "Cinza", 2019, "Fiat Uno", "CAR3XFV", 4, 75.0, 43.807m, 0, 0, 2 },
                    { 2, 0, "CHASSIKSRAL4DOKCK", "Flex", "Preto", 2018, "VW GOL", "CAR3FFV", 4, 82.0, 47.507m, 0, 0, 2 },
                    { 3, 0, "CHASSIEFT90SL35HL", "Gasolina", "Branco", 2017, "Renault Duster", "CAR3XFV", 4, 118.0, 67.907m, 0, 1, 2 },
                    { 4, 0, "CHASSI12454T4T456", null, "Cinza", 2022, "CG 160 Titan", "PLC1234", 0, 15.1, 14.620m, 2, 0, 3 },
                    { 5, 0, "CHASSI123DFGEVGBU", null, "Azul", 2017, "CG 160 Fan", "BRA2S5D", 0, 15.1, 13.480m, 2, 0, 3 },
                    { 6, 0, "CHASSIQER234GYHJC", null, "Branco", 2022, "CG 160 Cargo", "CBA3S5K", 0, 15.1, 13.650m, 2, 1, 3 },
                    { 7, 1820, "CHASSIFA3DVFOLM1D7", "Diesel", "Branco", 2021, "Fiat Toro", "P1CKUP7", 4, 139.0, 103.907m, 0, 0, 0 },
                    { 8, 1920, "CHASSIYUI789O50HL", "Gasolina", "Prata", 2021, "Toyota Hilux", "TYT678X", 4, 204.0, 238.907m, 0, 0, 0 },
                    { 9, 1850, "CHASSL3ADFTTH7OGH", "Diesel", "Prata", 2021, "Chevrolet s10", "CHVR3FL", 4, 206.0, 113.907m, 0, 1, 0 },
                    { 10, 0, "CHASSI123AZXSDCFE4", null, "Azul", 2021, "Tricity 300", "TRI1237", 0, 20.600000000000001, 48.650m, 3, 0, 1 },
                    { 11, 0, "CHASSI678GTUHJKXOL", null, "Branco", 2022, "Tricity 125", "CITY123", 0, 9.0, 24.009m, 3, 0, 1 },
                    { 12, 0, "CHASSIRTYMKO5B8M0Z", null, "Branco", 2021, "Tricity 125", "BA12K45", 0, 20.600000000000001, 58.805m, 3, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
