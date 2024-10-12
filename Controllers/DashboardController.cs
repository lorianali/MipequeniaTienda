using Microsoft.AspNetCore.Mvc;
using MipequeniaTienda.Data;

namespace MipequeniaTienda.Controllers
{
    public class DashboardController:BaseController
    {
        public DashboardController(ApplicationDbContext context):base(context){ }

        public IActionResult Index()
        {
            return View();
        }
    }
}
