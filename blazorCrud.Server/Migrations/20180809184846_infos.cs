using Microsoft.EntityFrameworkCore.Migrations;

namespace blazorCrud.Server.Migrations
{
    public partial class infos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fone",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "fone",
                table: "Usuarios");
        }
    }
}
