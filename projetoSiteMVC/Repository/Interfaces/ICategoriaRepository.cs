using projetoSiteMVC.Models;

namespace projetoSiteMVC.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
