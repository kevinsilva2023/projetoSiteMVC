using Microsoft.EntityFrameworkCore;
using projetoSiteMVC.Context;
using projetoSiteMVC.Models;
using projetoSiteMVC.Repository.Interfaces;

namespace projetoSiteMVC.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos =>_context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutoPreferido => _context.Produtos
                                    .Where(p => p.ProdutoPreferido)
                                    .Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
        }
    }
}
