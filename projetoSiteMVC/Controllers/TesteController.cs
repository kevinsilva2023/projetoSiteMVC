using Microsoft.AspNetCore.Mvc;

namespace projetoSiteMVC.Controllers
{
    public class TesteController : Controller
    {
        public string Index()
        {
            return $"Testando o método Index de TesteControler : {DateTime.Now}";
        }
    }
}
