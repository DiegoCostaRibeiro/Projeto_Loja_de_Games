using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja_de_Games.Migrations
{
    public partial class AlteraVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Clientes_ClienteId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Jogos_JogoId",
                table: "Venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venda",
                table: "Venda");

            migrationBuilder.RenameTable(
                name: "Venda",
                newName: "Vendas");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_JogoId",
                table: "Vendas",
                newName: "IX_Vendas_JogoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ClienteId",
                table: "Vendas",
                newName: "IX_Vendas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Jogos_JogoId",
                table: "Vendas",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "JogoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Jogos_JogoId",
                table: "Vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas");

            migrationBuilder.RenameTable(
                name: "Vendas",
                newName: "Venda");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_JogoId",
                table: "Venda",
                newName: "IX_Venda_JogoId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_ClienteId",
                table: "Venda",
                newName: "IX_Venda_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venda",
                table: "Venda",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Clientes_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Jogos_JogoId",
                table: "Venda",
                column: "JogoId",
                principalTable: "Jogos",
                principalColumn: "JogoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
