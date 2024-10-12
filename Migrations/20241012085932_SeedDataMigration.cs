using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MipequeniaTienda.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Explora nuestra selección de productos de última generación en la categoría de Electrónica y Tecnología. Encuentra todo lo que necesitas, desde dispositivos inteligentes, equipos de audio, computadoras, hasta los gadgets más innovadores. Mantente conectado y actualizado con las tendencias tecnológicas más recientes para el hogar, oficina o entretenimiento personal. Aquí podrás descubrir soluciones tecnológicas que harán tu vida más fácil, eficiente y divertida.", "Electrónica y Tecnología" },
                    { 2, "Sumérgete en el mundo del entretenimiento con nuestra categoría de Consolas. Descubre las últimas generaciones de consolas de videojuegos que ofrecen experiencias inmersivas y emocionantes. Desde consolas portátiles hasta sistemas de alto rendimiento para jugar en casa, encuentra las mejores marcas y modelos que se ajustan a tu estilo de juego. Ya seas un gamer casual o un entusiasta, aquí encontrarás el equipo perfecto para llevar tu experiencia de juego al siguiente nivel.", "Consolas" },
                    { 3, "Adéntrate en mundos de aventura, acción y emoción con nuestra amplia colección de Videojuegos. Ofrecemos títulos para todos los gustos y plataformas, desde juegos de estrategia, deportes y rol hasta los más populares de acción y aventura. Ya seas un jugador ocasional o un fanático de los videojuegos, aquí encontrarás los últimos lanzamientos y clásicos favoritos que te brindarán horas de entretenimiento. ¡Elige tu próximo desafío y comienza la partida!", "Videojuegos" },
                    { 4, "Mejora tu experiencia de juego con nuestra selección de Accesorios de Videojuegos. Desde controles adicionales y audífonos con sonido envolvente hasta bases de carga, volantes y teclados especializados, aquí encontrarás todo lo que necesitas para llevar tus partidas al siguiente nivel. Ya seas un jugador casual o competitivo, nuestros accesorios están diseñados para maximizar la comodidad y el rendimiento en cada sesión de juego.", "Accesorios de Videojuegos" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Activo", "CategoriaId", "Codigo", "Descripcion", "Imagen", "Marca", "Modelo", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, true, 2, "PS5-SLIM-STD", "La PlayStation 5 Slim Estándar te ofrece una experiencia de juego de última generación con un diseño más compacto y ligero. Disfruta de tiempos de carga ultrarrápidos gracias a su disco SSD, gráficos increíbles con trazado de rayos y la vibrante resolución 4K. Ideal para los jugadores que buscan rendimiento y estilo en una consola compacta.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/11/00194481001017____22__1200x1200.jpg", "Sony", "CFI-1200A", "PlayStation 5 Slim Estándar", 549.90m, 100 },
                    { 2, true, 2, "NSW-1.1-SPORTS", "La Nintendo Switch 1.1 en colores Azul Neón y Rojo Neón incluye el popular juego Switch Sports y una suscripción de 12 meses a Nintendo Switch Online. Disfruta de la experiencia híbrida de Nintendo con la posibilidad de jugar en casa o llevarla contigo a cualquier parte.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202409/13/00194480000366____1__1200x1200.jpg?impolicy=Resize&width=1200", "Nintendo", "HAC-001(-01)", "Nintendo Switch 1.1 Azul Neón / Rojo Neón + Switch Sports + 12 meses NSO", 299.90m, 150 },
                    { 3, true, 3, "SH2-PS5-MER", "Silent Hill 2 para PlayStation 5 es una reinvención del clásico juego de terror psicológico. Vive una experiencia intensa con gráficos de nueva generación y un sonido inmersivo que te llevará a las profundidades de la perturbadora ciudad de Silent Hill.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202311/20/00197581507502____1__1200x1200.jpg?impolicy=Resize&width=1200", "Meridiem Games", "SH2-PS5", "Silent Hill 2 PlayStation 5", 59.90m, 200 },
                    { 4, true, 3, "ZELDA-EOW-NS", "The Legend Of Zelda Echoes Of Wisdom para Nintendo Switch te sumerge en una aventura épica llena de enigmas, combates y exploración en un vasto mundo abierto. Este juego de Nintendo continúa la legendaria saga de Zelda, ofreciendo gráficos vibrantes y jugabilidad inmersiva.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/01/00197580515936____17__1200x1200.jpg", "Nintendo", "LOZ-EOW-NS", "The Legend Of Zelda Echoes Of Wisdom Nintendo Switch", 59.90m, 300 },
                    { 5, true, 3, "SMB-WONDER-NS", "Super Mario Bros. Wonder para Nintendo Switch te invita a explorar un mundo lleno de aventuras, plataformas emocionantes y divertidos retos. Únete a Mario y sus amigos en esta nueva entrega que promete diversión interminable y acción clásica.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202307/14/00197580513584____22__1200x1200.jpg", "Nintendo", "SMB-WONDER-NS", "Super Mario Bros. Wonder Nintendo Switch", 59.90m, 250 },
                    { 6, true, 3, "MINECRAFT-NS", "Minecraft para Nintendo Switch permite a los jugadores explorar, construir y sobrevivir en un mundo infinito de bloques. Con nuevas características y la capacidad de jugar en modo portátil, es perfecto para jugadores de todas las edades.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201805/16/00197580501969____1__1200x1200.jpg", "Nintendo", "MINECRAFT-NS", "Minecraft Nintendo Switch", 29.90m, 500 },
                    { 7, true, 3, "LUIGIS-MANSION3-NS", "Luigi's Mansion 3 para Nintendo Switch es una emocionante aventura donde Luigi debe explorar un misterioso hotel para rescatar a sus amigos. Disfruta de gráficos impresionantes y una jugabilidad entretenida en este título que combina acción y acertijos.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201906/18/00197580504757____1__1200x1200.jpg?impolicy=Resize&width=1200", "Nintendo", "LM3-NS", "Luigi's Mansion 3 Nintendo Switch", 59.90m, 400 },
                    { 8, true, 3, "PATRICK-STAR-NS", "THE PATRICK STAR GAME para Nintendo Switch es una divertida aventura basada en el querido personaje de Bob Esponja. Explora el mundo submarino y enfrenta retos divertidos en un juego lleno de humor y sorpresas.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202305/21/00197580504103____1__1200x1200.jpg", "Nintendo", "PATRICK-STAR-NS", "THE PATRICK STAR GAME Nintendo Switch", 39.90m, 350 },
                    { 9, true, 3, "TUNIC-NS-MER", "Tunic para Nintendo Switch es un juego de acción y aventuras protagonizado por un pequeño zorro en un mundo lleno de misterios. Explora mazmorras, resuelve acertijos y descubre secretos en este encantador y desafiante título.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202303/15/00197580512792____2__1200x1200.jpg", "Meridiem Games", "TUNIC-NS", "Tunic Nintendo Switch", 39.90m, 350 },
                    { 10, true, 3, "ELDEN-RING-PS5", "Elden Ring para PlayStation 5 es un épico juego de rol de acción creado por FromSoftware. Explora vastos paisajes, derrota enemigos poderosos y descubre secretos en este título lleno de acción y desafíos.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202202/28/00197581502917____1__1200x1200.jpg", "Bandai Namco", "ER-PS5", "Elden Ring PlayStation 5", 56.90m, 120 },
                    { 11, true, 4, "DUALSENSE-FORTNITE", "El mando inalámbrico DualSense de edición limitada Fortnite para PlayStation 5 lleva la jugabilidad al siguiente nivel con un diseño inspirado en el popular juego y características avanzadas como retroalimentación háptica y gatillos adaptativos.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202410/02/00197581104847____6__1200x1200.jpg?impolicy=Resize&width=1200", "Sony", "CFI-ZCT1W-FORTNITE", "Mando inalámbrico DualSense: edición limitada Fortnite", 87.90m, 150 },
                    { 12, true, 4, "DR90-PRO-V8", "La Silla Gaming Drift DR90 Pro V8 en color negro y rojo te ofrece la máxima comodidad y ergonomía para largas sesiones de juego. Con un diseño robusto, ajuste completo y materiales de alta calidad, es perfecta para jugadores exigentes.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202306/23/00197578113009____13__1200x1200.jpg?impolicy=Resize&width=1200", "Drift", "DR90-PRO-V8-BKRD", "Silla Gaming Drift DR90 Pro V8 negro / rojo", 159.90m, 100 },
                    { 13, true, 2, "XBOX-SERIES-S-512GB", "La consola Xbox Series S ofrece una experiencia de juego de nueva generación en un formato compacto y asequible. Con 512 GB de almacenamiento, gráficos de alta calidad y tiempos de carga rápidos, es perfecta para jugadores que buscan un gran rendimiento a un precio accesible.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202009/21/00194482000026____10__1200x1200.jpg?impolicy=Resize&width=1200", "Microsoft", "Series-S-512GB", "Consola Xbox Series S 512 GB Blanca", 299.90m, 200 },
                    { 14, true, 2, "THE400-MINI", "La consola THE400 Mini de PLAION es un homenaje a las consolas retro, ofreciendo una experiencia de juego nostálgica en un formato compacto. Con una selección de juegos clásicos preinstalados, esta consola es perfecta para los amantes de los videojuegos retro.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202402/22/00194462000640____23__1200x1200.jpg?impolicy=Resize&width=1200", "PLAION", "THE400", "Consola THE400 Mini", 119.90m, 150 },
                    { 15, true, 3, "SWO-PS5", "Sumérgete en una aventura épica en el universo de Star Wars con Star Wars Outlaws para PlayStation 5. Vive emocionantes batallas, explora nuevos mundos y toma decisiones que impactarán tu viaje como un forajido en la galaxia.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/08/00197581508310____17__1200x1200.jpg", "UbiSoft", "Outlaws", "Star Wars Outlaws PlayStation 5", 81.90m, 200 },
                    { 16, true, 1, "HP-VICTUS-16R1030NS", "El portátil gaming HP VICTUS 16-r1030ns cuenta con un procesador Intel Core i7, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4060 de 8GB. Con una pantalla de 16,1 pulgadas y sistema operativo Windows 11, es ideal para jugadores que buscan alto rendimiento y capacidad de almacenamiento.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202408/27/00115215599299____6__1200x1200.jpg", "HP", "16-r1030ns", "Portátil Gaming HP VICTUS 16-r1030ns", 1599.00m, 50 },
                    { 17, true, 1, "LENOVO-LEGION-PRO5-16IRX9", "El portátil gaming Lenovo Legion Pro 5 16IRX9 viene equipado con un procesador Intel Core i9, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4070 de 8GB. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, es ideal para los gamers que buscan una experiencia de juego inmersiva y potente.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/17/00115215598895____5__1200x1200.jpg", "Lenovo", "16IRX9", "Portátil Gaming Lenovo Legion Pro 5 16IRX9", 1849.00m, 40 },
                    { 18, true, 1, "ACER-NITRO-V-16", "El portátil gaming Acer Nitro V 16 está equipado con un procesador AMD Ryzen 5, 16GB de RAM, 512GB de almacenamiento SSD y una tarjeta gráfica Nvidia RTX 4050. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, ofrece un rendimiento excelente para juegos y multitarea.", "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202406/10/00115215598713____7__1200x1200.jpg", "Acer", "Nitro V 16", "Portátil Gaming Acer Nitro V 16", 1049.00m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4);
        }
    }
}
