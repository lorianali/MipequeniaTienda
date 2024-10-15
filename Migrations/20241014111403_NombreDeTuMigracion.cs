using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MipequeniaTienda.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeTuMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Imagen",
                value: "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202409/09/00197578531879____8__1200x1200.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "Imagen",
                value: "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202305/21/00197580504103____1__1200x1200.jpg");
        }
    }
}
