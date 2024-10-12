using Microsoft.EntityFrameworkCore;
using MipequeniaTienda.Models;

namespace MipequeniaTienda.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Semilla de datos para categorías
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    CategoriaId = 1,
                    Nombre = "Electrónica y Tecnología",
                    Descripcion = "Explora nuestra selección de productos de última generación en la categoría de Electrónica y Tecnología. Encuentra todo lo que necesitas, desde dispositivos inteligentes, equipos de audio, computadoras, hasta los gadgets más innovadores. Mantente conectado y actualizado con las tendencias tecnológicas más recientes para el hogar, oficina o entretenimiento personal. Aquí podrás descubrir soluciones tecnológicas que harán tu vida más fácil, eficiente y divertida."
                },
                new Categoria
                {
                    CategoriaId = 2,
                    Nombre = "Consolas",
                    Descripcion = "Sumérgete en el mundo del entretenimiento con nuestra categoría de Consolas. Descubre las últimas generaciones de consolas de videojuegos que ofrecen experiencias inmersivas y emocionantes. Desde consolas portátiles hasta sistemas de alto rendimiento para jugar en casa, encuentra las mejores marcas y modelos que se ajustan a tu estilo de juego. Ya seas un gamer casual o un entusiasta, aquí encontrarás el equipo perfecto para llevar tu experiencia de juego al siguiente nivel."
                },
                new Categoria
                {
                    CategoriaId = 3,
                    Nombre = "Videojuegos",
                    Descripcion = "Adéntrate en mundos de aventura, acción y emoción con nuestra amplia colección de Videojuegos. Ofrecemos títulos para todos los gustos y plataformas, desde juegos de estrategia, deportes y rol hasta los más populares de acción y aventura. Ya seas un jugador ocasional o un fanático de los videojuegos, aquí encontrarás los últimos lanzamientos y clásicos favoritos que te brindarán horas de entretenimiento. ¡Elige tu próximo desafío y comienza la partida!"
                },
                new Categoria
                {
                    CategoriaId = 4,
                    Nombre = "Accesorios de Videojuegos",
                    Descripcion = "Mejora tu experiencia de juego con nuestra selección de Accesorios de Videojuegos. Desde controles adicionales y audífonos con sonido envolvente hasta bases de carga, volantes y teclados especializados, aquí encontrarás todo lo que necesitas para llevar tus partidas al siguiente nivel. Ya seas un jugador casual o competitivo, nuestros accesorios están diseñados para maximizar la comodidad y el rendimiento en cada sesión de juego."
                }
            );

            // Semilla de datos para productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    ProductoId = 1,
                    Nombre = "PlayStation 5 Slim Estándar",
                    Codigo = "PS5-SLIM-STD",
                    Modelo = "CFI-1200A",
                    Descripcion = "La PlayStation 5 Slim Estándar te ofrece una experiencia de juego de última generación con un diseño más compacto y ligero. Disfruta de tiempos de carga ultrarrápidos gracias a su disco SSD, gráficos increíbles con trazado de rayos y la vibrante resolución 4K. Ideal para los jugadores que buscan rendimiento y estilo en una consola compacta.",
                    Precio = 549.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/11/00194481001017____22__1200x1200.jpg",
                    CategoriaId = 2,
                    Stock = 100,
                    Marca = "Sony",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 2,
                    Nombre = "Nintendo Switch 1.1 Azul Neón / Rojo Neón + Switch Sports + 12 meses NSO",
                    Codigo = "NSW-1.1-SPORTS",
                    Modelo = "HAC-001(-01)",
                    Descripcion = "La Nintendo Switch 1.1 en colores Azul Neón y Rojo Neón incluye el popular juego Switch Sports y una suscripción de 12 meses a Nintendo Switch Online. Disfruta de la experiencia híbrida de Nintendo con la posibilidad de jugar en casa o llevarla contigo a cualquier parte.",
                    Precio = 299.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202409/13/00194480000366____1__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 2,
                    Stock = 150,
                    Marca = "Nintendo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 3,
                    Nombre = "Silent Hill 2 PlayStation 5",
                    Codigo = "SH2-PS5-MER",
                    Modelo = "SH2-PS5",
                    Descripcion = "Silent Hill 2 para PlayStation 5 es una reinvención del clásico juego de terror psicológico. Vive una experiencia intensa con gráficos de nueva generación y un sonido inmersivo que te llevará a las profundidades de la perturbadora ciudad de Silent Hill.",
                    Precio = 59.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202311/20/00197581507502____1__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 3,
                    Stock = 200,
                    Marca = "Meridiem Games",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 4,
                    Nombre = "The Legend Of Zelda Echoes Of Wisdom Nintendo Switch",
                    Codigo = "ZELDA-EOW-NS",
                    Modelo = "LOZ-EOW-NS",
                    Descripcion = "The Legend Of Zelda Echoes Of Wisdom para Nintendo Switch te sumerge en una aventura épica llena de enigmas, combates y exploración en un vasto mundo abierto. Este juego de Nintendo continúa la legendaria saga de Zelda, ofreciendo gráficos vibrantes y jugabilidad inmersiva.",
                    Precio = 59.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/01/00197580515936____17__1200x1200.jpg",
                    CategoriaId = 3,
                    Stock = 300,
                    Marca = "Nintendo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 5,
                    Nombre = "Super Mario Bros. Wonder Nintendo Switch",
                    Codigo = "SMB-WONDER-NS",
                    Modelo = "SMB-WONDER-NS",
                    Descripcion = "Super Mario Bros. Wonder para Nintendo Switch te invita a explorar un mundo lleno de aventuras, plataformas emocionantes y divertidos retos. Únete a Mario y sus amigos en esta nueva entrega que promete diversión interminable y acción clásica.",
                    Precio = 59.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202307/14/00197580513584____22__1200x1200.jpg",
                    CategoriaId = 3,
                    Stock = 250,
                    Marca = "Nintendo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 6,
                    Nombre = "Minecraft Nintendo Switch",
                    Codigo = "MINECRAFT-NS",
                    Modelo = "MINECRAFT-NS",
                    Descripcion = "Minecraft para Nintendo Switch permite a los jugadores explorar, construir y sobrevivir en un mundo infinito de bloques. Con nuevas características y la capacidad de jugar en modo portátil, es perfecto para jugadores de todas las edades.",
                    Precio = 29.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201805/16/00197580501969____1__1200x1200.jpg",
                    CategoriaId = 3,
                    Stock = 500,
                    Marca = "Nintendo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 7,
                    Nombre = "Luigi's Mansion 3 Nintendo Switch",
                    Codigo = "LUIGIS-MANSION3-NS",
                    Modelo = "LM3-NS",
                    Descripcion = "Luigi's Mansion 3 para Nintendo Switch es una emocionante aventura donde Luigi debe explorar un misterioso hotel para rescatar a sus amigos. Disfruta de gráficos impresionantes y una jugabilidad entretenida en este título que combina acción y acertijos.",
                    Precio = 59.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201906/18/00197580504757____1__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 3,
                    Stock = 400,
                    Marca = "Nintendo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 8,
                    Nombre = "THE PATRICK STAR GAME Nintendo Switch",
                    Codigo = "PATRICK-STAR-NS",
                    Modelo = "PATRICK-STAR-NS",
                    Descripcion = "THE PATRICK STAR GAME para Nintendo Switch es una divertida aventura basada en el querido personaje de Bob Esponja. Explora el mundo submarino y enfrenta retos divertidos en un juego lleno de humor y sorpresas.",
                    Precio = 39.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202305/21/00197580504103____1__1200x1200.jpg",
                    CategoriaId = 3,
                    Stock = 350,
                    Marca = "Nintendo",
                    Activo = true
                },
               new Producto
               {
                   ProductoId = 9,
                   Nombre = "Tunic Nintendo Switch",
                   Codigo = "TUNIC-NS-MER",
                   Modelo = "TUNIC-NS",
                   Descripcion = "Tunic para Nintendo Switch es un juego de acción y aventuras protagonizado por un pequeño zorro en un mundo lleno de misterios. Explora mazmorras, resuelve acertijos y descubre secretos en este encantador y desafiante título.",
                   Precio = 39.90m,
                   Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202303/15/00197580512792____2__1200x1200.jpg",
                   CategoriaId = 3, // ID de la categoría Videojuegos
                   Stock = 350,
                   Marca = "Meridiem Games",
                   Activo = true
               },
               new Producto
               {
                   ProductoId = 10,
                   Nombre = "Elden Ring PlayStation 5",
                   Codigo = "ELDEN-RING-PS5",
                   Modelo = "ER-PS5",
                   Descripcion = "Elden Ring para PlayStation 5 es un épico juego de rol de acción creado por FromSoftware. Explora vastos paisajes, derrota enemigos poderosos y descubre secretos en este título lleno de acción y desafíos.",
                   Precio = 56.90m,
                   Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202202/28/00197581502917____1__1200x1200.jpg",
                   CategoriaId = 3, // ID de la categoría Videojuegos
                   Stock = 120,
                   Marca = "Bandai Namco",
                   Activo = true
               },
                new Producto
                {
                    ProductoId = 11,
                    Nombre = "Mando inalámbrico DualSense: edición limitada Fortnite",
                    Codigo = "DUALSENSE-FORTNITE",
                    Modelo = "CFI-ZCT1W-FORTNITE",
                    Descripcion = "El mando inalámbrico DualSense de edición limitada Fortnite para PlayStation 5 lleva la jugabilidad al siguiente nivel con un diseño inspirado en el popular juego y características avanzadas como retroalimentación háptica y gatillos adaptativos.",
                    Precio = 87.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202410/02/00197581104847____6__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 4,
                    Stock = 150,
                    Marca = "Sony",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 12,
                    Nombre = "Silla Gaming Drift DR90 Pro V8 negro / rojo",
                    Codigo = "DR90-PRO-V8",
                    Modelo = "DR90-PRO-V8-BKRD",
                    Descripcion = "La Silla Gaming Drift DR90 Pro V8 en color negro y rojo te ofrece la máxima comodidad y ergonomía para largas sesiones de juego. Con un diseño robusto, ajuste completo y materiales de alta calidad, es perfecta para jugadores exigentes.",
                    Precio = 159.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202306/23/00197578113009____13__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 4,
                    Stock = 100,
                    Marca = "Drift",
                    Activo = true
                }, new Producto
                {
                    ProductoId = 13,
                    Nombre = "Consola Xbox Series S 512 GB Blanca",
                    Codigo = "XBOX-SERIES-S-512GB",
                    Modelo = "Series-S-512GB",
                    Descripcion = "La consola Xbox Series S ofrece una experiencia de juego de nueva generación en un formato compacto y asequible. Con 512 GB de almacenamiento, gráficos de alta calidad y tiempos de carga rápidos, es perfecta para jugadores que buscan un gran rendimiento a un precio accesible.",
                    Precio = 299.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202009/21/00194482000026____10__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 2, // ID de la categoría Consolas
                    Stock = 200,
                    Marca = "Microsoft",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 14,
                    Nombre = "Consola THE400 Mini",
                    Codigo = "THE400-MINI",
                    Modelo = "THE400",
                    Descripcion = "La consola THE400 Mini de PLAION es un homenaje a las consolas retro, ofreciendo una experiencia de juego nostálgica en un formato compacto. Con una selección de juegos clásicos preinstalados, esta consola es perfecta para los amantes de los videojuegos retro.",
                    Precio = 119.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202402/22/00194462000640____23__1200x1200.jpg?impolicy=Resize&width=1200",
                    CategoriaId = 2, // ID de la categoría Consolas
                    Stock = 150,
                    Marca = "PLAION",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 15,
                    Nombre = "Star Wars Outlaws PlayStation 5",
                    Codigo = "SWO-PS5",
                    Modelo = "Outlaws",
                    Descripcion = "Sumérgete en una aventura épica en el universo de Star Wars con Star Wars Outlaws para PlayStation 5. Vive emocionantes batallas, explora nuevos mundos y toma decisiones que impactarán tu viaje como un forajido en la galaxia.",
                    Precio = 81.90m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/08/00197581508310____17__1200x1200.jpg",
                    CategoriaId = 3, // ID de la categoría Videojuegos
                    Stock = 200, // Ejemplo de cantidad en stock
                    Marca = "UbiSoft",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 16,
                    Nombre = "Portátil Gaming HP VICTUS 16-r1030ns",
                    Codigo = "HP-VICTUS-16R1030NS",
                    Modelo = "16-r1030ns",
                    Descripcion = "El portátil gaming HP VICTUS 16-r1030ns cuenta con un procesador Intel Core i7, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4060 de 8GB. Con una pantalla de 16,1 pulgadas y sistema operativo Windows 11, es ideal para jugadores que buscan alto rendimiento y capacidad de almacenamiento.",
                    Precio = 1599.00m,
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202408/27/00115215599299____6__1200x1200.jpg",
                    CategoriaId = 1, // ID de la categoría Electrónica y Tecnología
                    Stock = 50, // Ejemplo de cantidad en stock
                    Marca = "HP",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 17,
                    Nombre = "Portátil Gaming Lenovo Legion Pro 5 16IRX9",
                    Codigo = "LENOVO-LEGION-PRO5-16IRX9",
                    Modelo = "16IRX9",
                    Descripcion = "El portátil gaming Lenovo Legion Pro 5 16IRX9 viene equipado con un procesador Intel Core i9, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4070 de 8GB. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, es ideal para los gamers que buscan una experiencia de juego inmersiva y potente.",
                    Precio = 1849.00m, // Precio descontado
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/17/00115215598895____5__1200x1200.jpg",
                    CategoriaId = 1, // ID de la categoría Electrónica y Tecnología
                    Stock = 40, // Ejemplo de cantidad en stock
                    Marca = "Lenovo",
                    Activo = true
                },
                new Producto
                {
                    ProductoId = 18,
                    Nombre = "Portátil Gaming Acer Nitro V 16",
                    Codigo = "ACER-NITRO-V-16",
                    Modelo = "Nitro V 16",
                    Descripcion = "El portátil gaming Acer Nitro V 16 está equipado con un procesador AMD Ryzen 5, 16GB de RAM, 512GB de almacenamiento SSD y una tarjeta gráfica Nvidia RTX 4050. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, ofrece un rendimiento excelente para juegos y multitarea.",
                    Precio = 1049.00m, // Precio descontado
                    Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202406/10/00115215598713____7__1200x1200.jpg",
                    CategoriaId = 1, // ID de la categoría Electrónica y Tecnología
                    Stock = 50, // Ejemplo de cantidad en stock
                    Marca = "Acer",
                    Activo = true
                }


            );
        }
    }
}
