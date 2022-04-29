using Microsoft.EntityFrameworkCore.Migrations;

namespace StartClinica.Migrations
{
    public partial class CorrecaoTabelaAgenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Agendas");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Agendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Agendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Agendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
