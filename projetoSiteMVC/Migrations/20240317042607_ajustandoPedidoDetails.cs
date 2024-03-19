using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoSiteMVC.Migrations
{
    public partial class ajustandoPedidoDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LancheId",
                table: "PedidoDetalhes");

            migrationBuilder.DropColumn(
                name: "Quatidade",
                table: "PedidoDetalhes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LancheId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quatidade",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
