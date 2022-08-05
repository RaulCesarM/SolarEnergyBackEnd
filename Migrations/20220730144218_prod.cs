using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarEnergyBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class prod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoId",
                table: "Producaos");

            migrationBuilder.DropIndex(
                name: "IX_Producaos_UnidadeProducaoId",
                table: "Producaos");

            migrationBuilder.DropColumn(
                name: "IdUnidade",
                table: "Producaos");

            migrationBuilder.DropColumn(
                name: "UnidadeProducaoId",
                table: "Producaos");

            migrationBuilder.RenameColumn(
                name: "TotalGerado",
                table: "Producaos",
                newName: "totalGerado");

            migrationBuilder.RenameColumn(
                name: "RegistradoEm",
                table: "Producaos",
                newName: "data");

            migrationBuilder.AddColumn<string>(
                name: "unidade",
                table: "Producaos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unidade",
                table: "Producaos");

            migrationBuilder.RenameColumn(
                name: "totalGerado",
                table: "Producaos",
                newName: "TotalGerado");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Producaos",
                newName: "RegistradoEm");

            migrationBuilder.AddColumn<int>(
                name: "IdUnidade",
                table: "Producaos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeProducaoId",
                table: "Producaos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producaos_UnidadeProducaoId",
                table: "Producaos",
                column: "UnidadeProducaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoId",
                table: "Producaos",
                column: "UnidadeProducaoId",
                principalTable: "Unidades",
                principalColumn: "Id");
        }
    }
}
