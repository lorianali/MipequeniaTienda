﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MipequeniaTienda.Data;

#nullable disable

namespace MipequeniaTienda.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241016101958_CrearTablaBanner")]
    partial class CrearTablaBanner
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MipequeniaTienda.Models.Banner", b =>
                {
                    b.Property<int>("BannerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BannerId"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BannerId");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Descripcion = "Explora nuestra selección de productos de última generación en la categoría de Electrónica y Tecnología. Encuentra todo lo que necesitas, desde dispositivos inteligentes, equipos de audio, computadoras, hasta los gadgets más innovadores. Mantente conectado y actualizado con las tendencias tecnológicas más recientes para el hogar, oficina o entretenimiento personal. Aquí podrás descubrir soluciones tecnológicas que harán tu vida más fácil, eficiente y divertida.",
                            Nombre = "Electrónica y Tecnología"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Descripcion = "Sumérgete en el mundo del entretenimiento con nuestra categoría de Consolas. Descubre las últimas generaciones de consolas de videojuegos que ofrecen experiencias inmersivas y emocionantes. Desde consolas portátiles hasta sistemas de alto rendimiento para jugar en casa, encuentra las mejores marcas y modelos que se ajustan a tu estilo de juego. Ya seas un gamer casual o un entusiasta, aquí encontrarás el equipo perfecto para llevar tu experiencia de juego al siguiente nivel.",
                            Nombre = "Consolas"
                        },
                        new
                        {
                            CategoriaId = 3,
                            Descripcion = "Adéntrate en mundos de aventura, acción y emoción con nuestra amplia colección de Videojuegos. Ofrecemos títulos para todos los gustos y plataformas, desde juegos de estrategia, deportes y rol hasta los más populares de acción y aventura. Ya seas un jugador ocasional o un fanático de los videojuegos, aquí encontrarás los últimos lanzamientos y clásicos favoritos que te brindarán horas de entretenimiento. ¡Elige tu próximo desafío y comienza la partida!",
                            Nombre = "Videojuegos"
                        },
                        new
                        {
                            CategoriaId = 4,
                            Descripcion = "Mejora tu experiencia de juego con nuestra selección de Accesorios de Videojuegos. Desde controles adicionales y audífonos con sonido envolvente hasta bases de carga, volantes y teclados especializados, aquí encontrarás todo lo que necesitas para llevar tus partidas al siguiente nivel. Ya seas un jugador casual o competitivo, nuestros accesorios están diseñados para maximizar la comodidad y el rendimiento en cada sesión de juego.",
                            Nombre = "Accesorios de Videojuegos"
                        });
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Detalle_Pedido", b =>
                {
                    b.Property<int>("DetallePedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetallePedido"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("DetallePedido");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetallePedidos");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Direccion", b =>
                {
                    b.Property<int>("DireccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DireccionId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DireccionId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Direccions");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.Property<int>("DireccionIdSeleccionada")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("PedidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Activo = true,
                            CategoriaId = 2,
                            Codigo = "PS5-SLIM-STD",
                            Descripcion = "La PlayStation 5 Slim Estándar te ofrece una experiencia de juego de última generación con un diseño más compacto y ligero. Disfruta de tiempos de carga ultrarrápidos gracias a su disco SSD, gráficos increíbles con trazado de rayos y la vibrante resolución 4K. Ideal para los jugadores que buscan rendimiento y estilo en una consola compacta.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/11/00194481001017____22__1200x1200.jpg",
                            Marca = "Sony",
                            Modelo = "CFI-1200A",
                            Nombre = "PlayStation 5 Slim Estándar",
                            Precio = 549.90m,
                            Stock = 100
                        },
                        new
                        {
                            ProductoId = 2,
                            Activo = true,
                            CategoriaId = 2,
                            Codigo = "NSW-1.1-SPORTS",
                            Descripcion = "La Nintendo Switch 1.1 en colores Azul Neón y Rojo Neón incluye el popular juego Switch Sports y una suscripción de 12 meses a Nintendo Switch Online. Disfruta de la experiencia híbrida de Nintendo con la posibilidad de jugar en casa o llevarla contigo a cualquier parte.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202409/13/00194480000366____1__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Nintendo",
                            Modelo = "HAC-001(-01)",
                            Nombre = "Nintendo Switch 1.1 Azul Neón / Rojo Neón + Switch Sports + 12 meses NSO",
                            Precio = 299.90m,
                            Stock = 150
                        },
                        new
                        {
                            ProductoId = 3,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "SH2-PS5-MER",
                            Descripcion = "Silent Hill 2 para PlayStation 5 es una reinvención del clásico juego de terror psicológico. Vive una experiencia intensa con gráficos de nueva generación y un sonido inmersivo que te llevará a las profundidades de la perturbadora ciudad de Silent Hill.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202311/20/00197581507502____1__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Meridiem Games",
                            Modelo = "SH2-PS5",
                            Nombre = "Silent Hill 2 PlayStation 5",
                            Precio = 59.90m,
                            Stock = 200
                        },
                        new
                        {
                            ProductoId = 4,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "ZELDA-EOW-NS",
                            Descripcion = "The Legend Of Zelda Echoes Of Wisdom para Nintendo Switch te sumerge en una aventura épica llena de enigmas, combates y exploración en un vasto mundo abierto. Este juego de Nintendo continúa la legendaria saga de Zelda, ofreciendo gráficos vibrantes y jugabilidad inmersiva.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202407/01/00197580515936____17__1200x1200.jpg",
                            Marca = "Nintendo",
                            Modelo = "LOZ-EOW-NS",
                            Nombre = "The Legend Of Zelda Echoes Of Wisdom Nintendo Switch",
                            Precio = 59.90m,
                            Stock = 300
                        },
                        new
                        {
                            ProductoId = 5,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "SMB-WONDER-NS",
                            Descripcion = "Super Mario Bros. Wonder para Nintendo Switch te invita a explorar un mundo lleno de aventuras, plataformas emocionantes y divertidos retos. Únete a Mario y sus amigos en esta nueva entrega que promete diversión interminable y acción clásica.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202307/14/00197580513584____22__1200x1200.jpg",
                            Marca = "Nintendo",
                            Modelo = "SMB-WONDER-NS",
                            Nombre = "Super Mario Bros. Wonder Nintendo Switch",
                            Precio = 59.90m,
                            Stock = 250
                        },
                        new
                        {
                            ProductoId = 6,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "MINECRAFT-NS",
                            Descripcion = "Minecraft para Nintendo Switch permite a los jugadores explorar, construir y sobrevivir en un mundo infinito de bloques. Con nuevas características y la capacidad de jugar en modo portátil, es perfecto para jugadores de todas las edades.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201805/16/00197580501969____1__1200x1200.jpg",
                            Marca = "Nintendo",
                            Modelo = "MINECRAFT-NS",
                            Nombre = "Minecraft Nintendo Switch",
                            Precio = 29.90m,
                            Stock = 500
                        },
                        new
                        {
                            ProductoId = 7,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "LUIGIS-MANSION3-NS",
                            Descripcion = "Luigi's Mansion 3 para Nintendo Switch es una emocionante aventura donde Luigi debe explorar un misterioso hotel para rescatar a sus amigos. Disfruta de gráficos impresionantes y una jugabilidad entretenida en este título que combina acción y acertijos.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/201906/18/00197580504757____1__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Nintendo",
                            Modelo = "LM3-NS",
                            Nombre = "Luigi's Mansion 3 Nintendo Switch",
                            Precio = 59.90m,
                            Stock = 400
                        },
                        new
                        {
                            ProductoId = 8,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "PATRICK-STAR-NS",
                            Descripcion = "THE PATRICK STAR GAME para Nintendo Switch es una divertida aventura basada en el querido personaje de Bob Esponja. Explora el mundo submarino y enfrenta retos divertidos en un juego lleno de humor y sorpresas.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202409/09/00197578531879____8__1200x1200.jpg",
                            Marca = "Nintendo",
                            Modelo = "PATRICK-STAR-NS",
                            Nombre = "THE PATRICK STAR GAME Nintendo Switch",
                            Precio = 39.90m,
                            Stock = 350
                        },
                        new
                        {
                            ProductoId = 9,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "TUNIC-NS-MER",
                            Descripcion = "Tunic para Nintendo Switch es un juego de acción y aventuras protagonizado por un pequeño zorro en un mundo lleno de misterios. Explora mazmorras, resuelve acertijos y descubre secretos en este encantador y desafiante título.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202303/15/00197580512792____2__1200x1200.jpg",
                            Marca = "Meridiem Games",
                            Modelo = "TUNIC-NS",
                            Nombre = "Tunic Nintendo Switch",
                            Precio = 39.90m,
                            Stock = 350
                        },
                        new
                        {
                            ProductoId = 10,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "ELDEN-RING-PS5",
                            Descripcion = "Elden Ring para PlayStation 5 es un épico juego de rol de acción creado por FromSoftware. Explora vastos paisajes, derrota enemigos poderosos y descubre secretos en este título lleno de acción y desafíos.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202202/28/00197581502917____1__1200x1200.jpg",
                            Marca = "Bandai Namco",
                            Modelo = "ER-PS5",
                            Nombre = "Elden Ring PlayStation 5",
                            Precio = 56.90m,
                            Stock = 120
                        },
                        new
                        {
                            ProductoId = 11,
                            Activo = true,
                            CategoriaId = 4,
                            Codigo = "DUALSENSE-FORTNITE",
                            Descripcion = "El mando inalámbrico DualSense de edición limitada Fortnite para PlayStation 5 lleva la jugabilidad al siguiente nivel con un diseño inspirado en el popular juego y características avanzadas como retroalimentación háptica y gatillos adaptativos.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202410/02/00197581104847____6__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Sony",
                            Modelo = "CFI-ZCT1W-FORTNITE",
                            Nombre = "Mando inalámbrico DualSense: edición limitada Fortnite",
                            Precio = 87.90m,
                            Stock = 150
                        },
                        new
                        {
                            ProductoId = 12,
                            Activo = true,
                            CategoriaId = 4,
                            Codigo = "DR90-PRO-V8",
                            Descripcion = "La Silla Gaming Drift DR90 Pro V8 en color negro y rojo te ofrece la máxima comodidad y ergonomía para largas sesiones de juego. Con un diseño robusto, ajuste completo y materiales de alta calidad, es perfecta para jugadores exigentes.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202306/23/00197578113009____13__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Drift",
                            Modelo = "DR90-PRO-V8-BKRD",
                            Nombre = "Silla Gaming Drift DR90 Pro V8 negro / rojo",
                            Precio = 159.90m,
                            Stock = 100
                        },
                        new
                        {
                            ProductoId = 13,
                            Activo = true,
                            CategoriaId = 2,
                            Codigo = "XBOX-SERIES-S-512GB",
                            Descripcion = "La consola Xbox Series S ofrece una experiencia de juego de nueva generación en un formato compacto y asequible. Con 512 GB de almacenamiento, gráficos de alta calidad y tiempos de carga rápidos, es perfecta para jugadores que buscan un gran rendimiento a un precio accesible.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202009/21/00194482000026____10__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "Microsoft",
                            Modelo = "Series-S-512GB",
                            Nombre = "Consola Xbox Series S 512 GB Blanca",
                            Precio = 299.90m,
                            Stock = 200
                        },
                        new
                        {
                            ProductoId = 14,
                            Activo = true,
                            CategoriaId = 2,
                            Codigo = "THE400-MINI",
                            Descripcion = "La consola THE400 Mini de PLAION es un homenaje a las consolas retro, ofreciendo una experiencia de juego nostálgica en un formato compacto. Con una selección de juegos clásicos preinstalados, esta consola es perfecta para los amantes de los videojuegos retro.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202402/22/00194462000640____23__1200x1200.jpg?impolicy=Resize&width=1200",
                            Marca = "PLAION",
                            Modelo = "THE400",
                            Nombre = "Consola THE400 Mini",
                            Precio = 119.90m,
                            Stock = 150
                        },
                        new
                        {
                            ProductoId = 15,
                            Activo = true,
                            CategoriaId = 3,
                            Codigo = "SWO-PS5",
                            Descripcion = "Sumérgete en una aventura épica en el universo de Star Wars con Star Wars Outlaws para PlayStation 5. Vive emocionantes batallas, explora nuevos mundos y toma decisiones que impactarán tu viaje como un forajido en la galaxia.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/08/00197581508310____17__1200x1200.jpg",
                            Marca = "UbiSoft",
                            Modelo = "Outlaws",
                            Nombre = "Star Wars Outlaws PlayStation 5",
                            Precio = 81.90m,
                            Stock = 200
                        },
                        new
                        {
                            ProductoId = 16,
                            Activo = true,
                            CategoriaId = 1,
                            Codigo = "HP-VICTUS-16R1030NS",
                            Descripcion = "El portátil gaming HP VICTUS 16-r1030ns cuenta con un procesador Intel Core i7, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4060 de 8GB. Con una pantalla de 16,1 pulgadas y sistema operativo Windows 11, es ideal para jugadores que buscan alto rendimiento y capacidad de almacenamiento.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202408/27/00115215599299____6__1200x1200.jpg",
                            Marca = "HP",
                            Modelo = "16-r1030ns",
                            Nombre = "Portátil Gaming HP VICTUS 16-r1030ns",
                            Precio = 1599.00m,
                            Stock = 50
                        },
                        new
                        {
                            ProductoId = 17,
                            Activo = true,
                            CategoriaId = 1,
                            Codigo = "LENOVO-LEGION-PRO5-16IRX9",
                            Descripcion = "El portátil gaming Lenovo Legion Pro 5 16IRX9 viene equipado con un procesador Intel Core i9, 32GB de RAM, 1TB de almacenamiento SSD y una tarjeta gráfica Nvidia GeForce RTX 4070 de 8GB. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, es ideal para los gamers que buscan una experiencia de juego inmersiva y potente.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202405/17/00115215598895____5__1200x1200.jpg",
                            Marca = "Lenovo",
                            Modelo = "16IRX9",
                            Nombre = "Portátil Gaming Lenovo Legion Pro 5 16IRX9",
                            Precio = 1849.00m,
                            Stock = 40
                        },
                        new
                        {
                            ProductoId = 18,
                            Activo = true,
                            CategoriaId = 1,
                            Codigo = "ACER-NITRO-V-16",
                            Descripcion = "El portátil gaming Acer Nitro V 16 está equipado con un procesador AMD Ryzen 5, 16GB de RAM, 512GB de almacenamiento SSD y una tarjeta gráfica Nvidia RTX 4050. Con una pantalla de 16 pulgadas y sistema operativo Windows 11, ofrece un rendimiento excelente para juegos y multitarea.",
                            Imagen = "https://cdn.grupoelcorteingles.es/SGFM/dctm/MEDIA03/202406/10/00115215598713____7__1200x1200.jpg",
                            Marca = "Acer",
                            Modelo = "Nitro V 16",
                            Nombre = "Portátil Gaming Acer Nitro V 16",
                            Precio = 1049.00m,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Detalle_Pedido", b =>
                {
                    b.HasOne("MipequeniaTienda.Models.Pedido", "Pedido")
                        .WithMany("DetallesPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MipequeniaTienda.Models.Producto", "Producto")
                        .WithMany("DetallesPedido")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Direccion", b =>
                {
                    b.HasOne("MipequeniaTienda.Models.Usuario", "Usuario")
                        .WithMany("Direcciones")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Pedido", b =>
                {
                    b.HasOne("MipequeniaTienda.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Producto", b =>
                {
                    b.HasOne("MipequeniaTienda.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Usuario", b =>
                {
                    b.HasOne("MipequeniaTienda.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Pedido", b =>
                {
                    b.Navigation("DetallesPedido");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Producto", b =>
                {
                    b.Navigation("DetallesPedido");
                });

            modelBuilder.Entity("MipequeniaTienda.Models.Usuario", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
