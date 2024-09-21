using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex8_AtualizarMigrations_AT.Migrations
{
    /// <inheritdoc />
    public partial class NovoAtributo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Clientes");
        }
    }
}
