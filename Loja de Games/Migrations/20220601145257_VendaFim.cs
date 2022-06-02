using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja_de_Games.Migrations
{
    public partial class VendaFim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Vendas_VendaId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_VendaId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_VendaId",
                table: "Clientes",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Vendas_VendaId",
                table: "Clientes",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
