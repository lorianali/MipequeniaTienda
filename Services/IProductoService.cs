using MipequeniaTienda.Models;
using MipequeniaTienda.Models.ViewModels;

namespace MipequeniaTienda.Services
{
    public interface IProductoService
    {
        Producto GetProducto(int id);
        Task<List<Producto>> GetProductosDestacados();
        Task<ProductosPaginadosViewModel> GetProductosPaginados(
            int? categoriaId, string? busqueda, int pagina, int productosPorPagina);
    }
    }
