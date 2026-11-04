using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesInnovaStock.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorCMYK",
                table: "Materiales");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Materiales",
                newName: "Color");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Materiales",
                newName: "Tipo");

            migrationBuilder.AddColumn<string>(
                name: "ColorCMYK",
                table: "Materiales",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
