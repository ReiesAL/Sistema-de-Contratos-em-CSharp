using Microsoft.AspNetCore.Mvc;

namespace SistemaContratos.Controllers
{
    public class ContratosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Adição de contrato
        public IActionResult Adicionar()
        {
            return View();
        }

        // Edição de contrato
        public IActionResult Editar()
        {
            return View();
        }

        // Confirmação de remoção do contrato
        public IActionResult Remover()
        {
            return View();
        }
    }
}
