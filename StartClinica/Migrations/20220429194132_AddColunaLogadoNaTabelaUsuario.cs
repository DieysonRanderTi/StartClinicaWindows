using Microsoft.EntityFrameworkCore.Migrations;

namespace StartClinica.Migrations
{
    public partial class AddColunaLogadoNaTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Logado",
                table: "Usuarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logado",
                table: "Usuarios");
        }
    }
}
