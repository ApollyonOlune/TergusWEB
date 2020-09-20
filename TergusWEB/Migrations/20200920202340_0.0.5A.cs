using Microsoft.EntityFrameworkCore.Migrations;

namespace TergusWEB.Migrations
{
    public partial class _005A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CpfCNPJ",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Cpf_CNPJ",
                table: "Cliente",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf_CNPJ",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "CpfCNPJ",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
