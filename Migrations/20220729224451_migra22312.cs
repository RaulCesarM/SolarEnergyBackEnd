using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarEnergyBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class migra22312 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoIdUnidade",
                table: "Producaos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Unidades",
                newName: "Apelido");

            migrationBuilder.RenameColumn(
                name: "IdUnidade",
                table: "Unidades",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UnidadeProducaoIdUnidade",
                table: "Producaos",
                newName: "UnidadeProducaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Producaos_UnidadeProducaoIdUnidade",
                table: "Producaos",
                newName: "IX_Producaos_UnidadeProducaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoId",
                table: "Producaos",
                column: "UnidadeProducaoId",
                principalTable: "Unidades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoId",
                table: "Producaos");

            migrationBuilder.RenameColumn(
                name: "Apelido",
                table: "Unidades",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Unidades",
                newName: "IdUnidade");

            migrationBuilder.RenameColumn(
                name: "UnidadeProducaoId",
                table: "Producaos",
                newName: "UnidadeProducaoIdUnidade");

            migrationBuilder.RenameIndex(
                name: "IX_Producaos_UnidadeProducaoId",
                table: "Producaos",
                newName: "IX_Producaos_UnidadeProducaoIdUnidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoIdUnidade",
                table: "Producaos",
                column: "UnidadeProducaoIdUnidade",
                principalTable: "Unidades",
                principalColumn: "IdUnidade");
        }
    }
}
