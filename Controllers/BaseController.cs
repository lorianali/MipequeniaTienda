using Microsoft.AspNetCore.Mvc;
using MipequeniaTienda.Data;

namespace MipequeniaTienda.Controllers
{
    public class BaseController : Controller
    {

        public readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
