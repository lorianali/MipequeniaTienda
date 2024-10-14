using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MipequeniaTienda.Data;
using MipequeniaTienda.Models;
using MipequeniaTienda.Models.ViewModels;
using Newtonsoft.Json;
using System.Data.Common;
using System.Diagnostics;

namespace MipequeniaTienda.Controllers
{
    public class BaseController : Controller //para agregar todas las funciones que necesita
    {

        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public override ViewResult View(string? viewName, object? model) //aqui viewName y model
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
        protected IActionResult HandleError(Exception e)
        {

            return View(
                "Error", new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                });
        }
        protected IActionResult HandleDbError(DbException dbException)
        {
            var ViewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de base de datos",
                Details = dbException.Message
            };
            return View("dbError", ViewModel);
        }
        protected IActionResult HandleDbUpdateError(DbUpdateException dbUpdateException)
        {
            var ViewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de actualización de base de datos",
                Details = dbUpdateException.Message
            };
            return View("dbError", ViewModel);
        }

    }

}

