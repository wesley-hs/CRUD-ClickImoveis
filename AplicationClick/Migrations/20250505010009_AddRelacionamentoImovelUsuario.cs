using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicationClick.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionamentoImovelUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Imovel",
                newName: "DataCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Imovel",
                newName: "Data");
        }
    }
}
