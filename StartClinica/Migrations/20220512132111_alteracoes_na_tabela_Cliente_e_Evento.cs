using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartClinica.Migrations
{
    public partial class alteracoes_na_tabela_Cliente_e_Evento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Motivo",
                table: "Eventos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Eventos",
                newName: "DataCadastro");

            migrationBuilder.AlterColumn<string>(
                name: "DataEvento",
                table: "Eventos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Eventos",
                newName: "Motivo");

            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Eventos",
                newName: "Data");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEvento",
                table: "Eventos",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Clientes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
