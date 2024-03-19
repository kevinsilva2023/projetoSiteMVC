using Microsoft.AspNetCore.Mvc;
using projetoSiteMVC.Models;
using projetoSiteMVC.Repository.Interfaces;
using projetoSiteMVC.ViewModels;
using System.Diagnostics;

namespace projetoSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosPreferidos = _produtoRepository.ProdutoPreferido
            };

            return View(homeViewModel);
        }

        public IActionResult Demo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
