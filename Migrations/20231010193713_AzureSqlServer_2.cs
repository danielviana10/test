using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.Migrations
{
    /// <inheritdoc />
    public partial class AzureSqlServer_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    cd_item = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nm_nome_item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ds_categoria = table.Column<int>(type: "int", nullable: false),
                    ds_descrica = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.cd_item);
                });

            migrationBuilder.CreateTable(
                name: "TB_PEDIDO",
                columns: table => new
                {
                    cd_pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nm_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vl_produto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FkItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PEDIDO", x => x.cd_pedido);
                    table.ForeignKey(
                        name: "FK_TB_PEDIDO_TB_PRODUTO_FkItemId",
                        column: x => x.FkItemId,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "cd_item",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PEDIDO_FkItemId",
                table: "TB_PEDIDO",
                column: "FkItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PEDIDO");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");
        }
    }
}
