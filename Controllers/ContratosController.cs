using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class ContratosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Remover()
        {
            return View();
        }
    }
}
