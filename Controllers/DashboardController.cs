using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MipequeniaTienda.Data;

namespace MipequeniaTienda.Controllers
{
    [Authorize(Policy = "RequiredAdminOrStaff")]
    public class DashboardController:BaseController
    {
        public DashboardController(ApplicationDbContext context):base(context){ }

        public IActionResult Index()
        {
            return View();
        }
    }
}
