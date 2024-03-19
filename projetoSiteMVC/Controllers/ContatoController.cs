using Microsoft.AspNetCore.Mvc;

namespace projetoSiteMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
                return View();
        }
    }
}
