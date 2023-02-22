using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Login.Entities.Migrations
{
    /// <inheritdoc />
    public partial class renameuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "Usuarios",
                newName: "Nombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Usuarios",
                newName: "User");
        }
    }
}
