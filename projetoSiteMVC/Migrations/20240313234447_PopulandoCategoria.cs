using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoSiteMVC.Migrations
{
    public partial class PopulandoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Revenda','Produtos para Revenda')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Industrializado','Produtos para industrializacao')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
