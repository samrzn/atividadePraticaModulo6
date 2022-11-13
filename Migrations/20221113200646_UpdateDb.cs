using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace atividadeAvaliativaModulo6.Migrations
{
    public partial class UpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_cliente",
                table: "Cliente",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "id_cliente");
        }
    }
}
