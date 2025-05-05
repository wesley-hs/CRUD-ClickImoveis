using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicationClick.Migrations
{
    /// <inheritdoc />
    public partial class M04AddnomeToImovel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Imovel",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Imovel");
        }
    }
}
