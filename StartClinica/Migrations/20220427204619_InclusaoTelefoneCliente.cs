using Microsoft.EntityFrameworkCore.Migrations;

namespace StartClinica.Migrations
{
    public partial class InclusaoTelefoneCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelefoneContato",
                table: "Cliente",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelefoneContato",
                table: "Cliente");
        }
    }
}
