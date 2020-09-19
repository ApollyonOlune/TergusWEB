using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TergusWEB.Migrations
{
    public partial class _001A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Razao_Social = table.Column<string>(maxLength: 200, nullable: false),
                    Cpf_CNPJ = table.Column<string>(nullable: false),
                    Rg_IE = table.Column<string>(nullable: false),
                    Data_da_expedicao = table.Column<DateTime>(nullable: false),
                    Afiliacao1 = table.Column<string>(nullable: false),
                    Afiliacao2 = table.Column<string>(nullable: false),
                    Naturalidade_cidade = table.Column<string>(nullable: false),
                    Naturalidade_estado = table.Column<string>(nullable: false),
                    Data_de_nascimento = table.Column<DateTime>(nullable: false),
                    Cep = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Numero = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Data_do_cadastro = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: false),
                    Telefone_1 = table.Column<string>(nullable: false),
                    Telefone_2 = table.Column<string>(nullable: true),
                    Telefone_3 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Nome_Fantasia = table.Column<string>(nullable: true),
                    Inscricao_Municipal = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Cliente_Juridico = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Data_de_nascimento = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Rg = table.Column<string>(nullable: false),
                    Salario = table.Column<double>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Advogado = table.Column<bool>(nullable: false),
                    Demitido = table.Column<bool>(nullable: false),
                    Data_da_demissao = table.Column<DateTime>(nullable: false),
                    telefone_1 = table.Column<string>(nullable: false),
                    telefone_2 = table.Column<string>(nullable: true),
                    telefone_3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_cliente = table.Column<int>(nullable: false),
                    Numero_do_processo = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Foro = table.Column<string>(nullable: false),
                    Valor_da_acao = table.Column<float>(nullable: false),
                    Competencia = table.Column<string>(nullable: false),
                    Classe = table.Column<string>(nullable: false),
                    Assunto_principal = table.Column<string>(nullable: false),
                    Outros_asssuntos = table.Column<string>(nullable: false),
                    Grau = table.Column<string>(nullable: false),
                    Re = table.Column<string>(nullable: false),
                    Autor = table.Column<string>(nullable: false),
                    Testemunha = table.Column<string>(nullable: false),
                    Advogado = table.Column<string>(nullable: false),
                    Vara = table.Column<string>(nullable: false),
                    Portal = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    FuncionarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processo_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ClienteId",
                table: "Processo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_FuncionarioId",
                table: "Processo",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
