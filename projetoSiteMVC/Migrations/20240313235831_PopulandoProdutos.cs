using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoSiteMVC.Migrations
{
    public partial class PopulandoProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque) " +
                "VALUES(1, 'Primeiro Item', 'Desc Prod 1', 'Descricao do Produto 1', 9.99, '', '', 1,2)");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque) " +
                "VALUES(2, 'Segundo Item', 'Desc Prod 2', 'Descricao do Produto 2', 19.99, '', '', 1,0)");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque) " +
                "VALUES(1, 'Terceiro Item', 'Desc Prod 3', 'Descricao do Produto 3', 229.99, '', '', 1,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
