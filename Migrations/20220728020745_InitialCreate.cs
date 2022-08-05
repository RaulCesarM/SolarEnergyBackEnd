using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarEnergyBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Janeiro = table.Column<double>(type: "float", nullable: false),
                    Fevereiro = table.Column<double>(type: "float", nullable: false),
                    Marco = table.Column<double>(type: "float", nullable: false),
                    Abril = table.Column<double>(type: "float", nullable: false),
                    Maio = table.Column<double>(type: "float", nullable: false),
                    Junho = table.Column<double>(type: "float", nullable: false),
                    Julho = table.Column<double>(type: "float", nullable: false),
                    Agosto = table.Column<double>(type: "float", nullable: false),
                    Setembro = table.Column<double>(type: "float", nullable: false),
                    Outubro = table.Column<double>(type: "float", nullable: false),
                    Novembro = table.Column<double>(type: "float", nullable: false),
                    Dezembro = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.IdRegistro);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    IdUnidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.IdUnidade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Producao",
                columns: table => new
                {
                    IdProducao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnidadeProducaoIdUnidade = table.Column<int>(type: "int", nullable: false),
                    RegistradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalGerado = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producao", x => x.IdProducao);
                    table.ForeignKey(
                        name: "FK_Producao_Unidade_UnidadeProducaoIdUnidade",
                        column: x => x.UnidadeProducaoIdUnidade,
                        principalTable: "Unidade",
                        principalColumn: "IdUnidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producao_UnidadeProducaoIdUnidade",
                table: "Producao",
                column: "UnidadeProducaoIdUnidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producao");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Unidade");
        }
    }
}
