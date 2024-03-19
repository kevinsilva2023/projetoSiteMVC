using projetoSiteMVC.Models;

namespace projetoSiteMVC.Repository.Interfaces
{
    public interface IProdutoRepository 
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutoPreferido { get; }
        Produto GetProdutoById(int produtoId);
    }
}
