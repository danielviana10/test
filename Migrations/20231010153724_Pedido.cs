using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.Migrations
{
    /// <inheritdoc />
    public partial class Pedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PEDIDO",
                columns: table => new
                {
                    cd_pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nm_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PEDIDO", x => x.cd_pedido);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PEDIDO");
        }
    }
}
