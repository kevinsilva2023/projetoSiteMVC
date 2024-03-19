using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoSiteMVC.Migrations
{
    public partial class addmigrationPedidoDetalhe2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pedidoDetalhes_Pedidos_PedidoId",
                table: "pedidoDetalhes");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidoDetalhes_Produtos_ProdutoId",
                table: "pedidoDetalhes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidoDetalhes",
                table: "pedidoDetalhes");

            migrationBuilder.RenameTable(
                name: "pedidoDetalhes",
                newName: "PedidoDetalhes");

            migrationBuilder.RenameIndex(
                name: "IX_pedidoDetalhes_ProdutoId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidoDetalhes_PedidoId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoDetalhes",
                table: "PedidoDetalhes",
                column: "PedidoDetalheId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoDetalhes",
                table: "PedidoDetalhes");

            migrationBuilder.RenameTable(
                name: "PedidoDetalhes",
                newName: "pedidoDetalhes");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_ProdutoId",
                table: "pedidoDetalhes",
                newName: "IX_pedidoDetalhes_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_PedidoId",
                table: "pedidoDetalhes",
                newName: "IX_pedidoDetalhes_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidoDetalhes",
                table: "pedidoDetalhes",
                column: "PedidoDetalheId");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidoDetalhes_Pedidos_PedidoId",
                table: "pedidoDetalhes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidoDetalhes_Produtos_ProdutoId",
                table: "pedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId");
        }
    }
}
