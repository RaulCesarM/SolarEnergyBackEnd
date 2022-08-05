using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarEnergyBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class migra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producao_Unidade_UnidadeProducaoIdUnidade",
                table: "Producao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidade",
                table: "Unidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producao",
                table: "Producao");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Unidade",
                newName: "Unidades");

            migrationBuilder.RenameTable(
                name: "Producao",
                newName: "Producaos");

            migrationBuilder.RenameIndex(
                name: "IX_Producao_UnidadeProducaoIdUnidade",
                table: "Producaos",
                newName: "IX_Producaos_UnidadeProducaoIdUnidade");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeProducaoIdUnidade",
                table: "Producaos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistradoEm",
                table: "Producaos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "IdUnidade",
                table: "Producaos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidades",
                table: "Unidades",
                column: "IdUnidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producaos",
                table: "Producaos",
                column: "IdProducao");

            migrationBuilder.AddForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoIdUnidade",
                table: "Producaos",
                column: "UnidadeProducaoIdUnidade",
                principalTable: "Unidades",
                principalColumn: "IdUnidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producaos_Unidades_UnidadeProducaoIdUnidade",
                table: "Producaos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unidades",
                table: "Unidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producaos",
                table: "Producaos");

            migrationBuilder.DropColumn(
                name: "IdUnidade",
                table: "Producaos");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Unidades",
                newName: "Unidade");

            migrationBuilder.RenameTable(
                name: "Producaos",
                newName: "Producao");

            migrationBuilder.RenameIndex(
                name: "IX_Producaos_UnidadeProducaoIdUnidade",
                table: "Producao",
                newName: "IX_Producao_UnidadeProducaoIdUnidade");

            migrationBuilder.AlterColumn<int>(
                name: "UnidadeProducaoIdUnidade",
                table: "Producao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistradoEm",
                table: "Producao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "IdUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unidade",
                table: "Unidade",
                column: "IdUnidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producao",
                table: "Producao",
                column: "IdProducao");

            migrationBuilder.AddForeignKey(
                name: "FK_Producao_Unidade_UnidadeProducaoIdUnidade",
                table: "Producao",
                column: "UnidadeProducaoIdUnidade",
                principalTable: "Unidade",
                principalColumn: "IdUnidade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
