using projetoSiteMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace projetoSiteMVC.Context
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        // carrega as informacoes de configuracao necessaria para configurar o DbContext
        }

        // definindo dbset (quais classes mapear para quais tabelas)
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }  
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }    
    }
}
