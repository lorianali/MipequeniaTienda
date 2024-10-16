using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MipequeniaTienda.Migrations
{
    /// <inheritdoc />
    public partial class ImagenUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "BannerId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "https://img.freepik.com/free-vector/gradient-gaming-stream-twitch-banner_23-2149815080.jpg" },
                    { 2, "https://img.freepik.com/vector-gratis/banner-contraccion-configuracion-juego-neon-diseno-plano_23-2149833530.jpg" },
                    { 3, "https://img.freepik.com/vector-gratis/diseno-plantilla-banner-contraccion-juegos_23-2149843550.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "BannerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "BannerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "BannerId",
                keyValue: 3);
        }
    }
}
