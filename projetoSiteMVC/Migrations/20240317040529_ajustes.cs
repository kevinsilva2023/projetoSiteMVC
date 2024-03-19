using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoSiteMVC.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes");

            migrationBuilder.RenameColumn(
                name: "PedidoEntregue",
                table: "Pedidos",
                newName: "PedidoEntregueEm");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quatidade",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes");

            migrationBuilder.DropColumn(
                name: "Quatidade",
                table: "PedidoDetalhes");

            migrationBuilder.RenameColumn(
                name: "PedidoEntregueEm",
                table: "Pedidos",
                newName: "PedidoEntregue");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Produtos_ProdutoId",
                table: "PedidoDetalhes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId");
        }
    }
}
