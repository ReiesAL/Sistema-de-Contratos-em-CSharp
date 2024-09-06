using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class ContratosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
