using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atividadeAvaliativaModulo6.Migrations
{
    public partial class UpdateClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Cliente",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Cliente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id_Cliente",
                table: "Cliente",
                newName: "id_cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Cliente",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Cliente",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "id_cliente",
                table: "Cliente",
                newName: "Id_Cliente");
        }
    }
}
