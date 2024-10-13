using Microsoft.AspNetCore.Mvc;
using MipequeniaTienda.Data;
using MipequeniaTienda.Models;
using Newtonsoft.Json;

namespace MipequeniaTienda.Controllers
{
    public class BaseController : Controller
    {

        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
        //para agregar todas las funciones que necesita
        public override ViewResult View(string? viewName, object? model)
        {
            @ViewBag.NumeroProductos = GetCarritoCount();
            return base.View(viewName, model);
        }

        protected int GetCarritoCount()
        {
            int count = 0;

            string? carritoJson = Request.Cookies["carrito"]; //vamos usar cookie para almacenar en formato json
            //deserializar json
            if (!string.IsNullOrEmpty(carritoJson))
            {
                var carrito = JsonConvert.DeserializeObject<List<ProductoIdAndCantidad>>(carritoJson);
                if (carrito != null)
                {
                    count = carrito.Count;
                }
            }
            return count;
        }
    }
}
