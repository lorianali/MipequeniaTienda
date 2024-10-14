using MipequeniaTienda.Models;

namespace MipequeniaTienda.Services
{
    public interface ICategoriaService
    {
        Task<List<Categoria>> GetCategorias();
    }
}
