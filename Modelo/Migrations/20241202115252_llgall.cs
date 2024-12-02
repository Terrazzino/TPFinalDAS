using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class llgall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesFacturas_Facturas_FacturaDelDetalleId",
                table: "DetallesFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesFacturas_Productos_ProductoDelDetalleId",
                table: "DetallesFacturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesFacturas",
                table: "DetallesFacturas");

            migrationBuilder.DropIndex(
                name: "IX_DetallesFacturas_FacturaDelDetalleId",
                table: "DetallesFacturas");

            migrationBuilder.DropColumn(
                name: "FacturaDelDetalleId",
                table: "DetallesFacturas");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "DetallesFacturas");

            migrationBuilder.RenameTable(
                name: "DetallesFacturas",
                newName: "DetalleFactura");

            migrationBuilder.RenameColumn(
                name: "ProductoDelDetalleId",
                table: "DetalleFactura",
                newName: "ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesFacturas_ProductoDelDetalleId",
                table: "DetalleFactura",
                newName: "IX_DetalleFactura_ProductoId");

            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "DetalleFactura",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleFactura",
                table: "DetalleFactura",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFactura_FacturaId",
                table: "DetalleFactura",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFactura_Facturas_FacturaId",
                table: "DetalleFactura",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFactura_Productos_ProductoId",
                table: "DetalleFactura",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFactura_Facturas_FacturaId",
                table: "DetalleFactura");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFactura_Productos_ProductoId",
                table: "DetalleFactura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleFactura",
                table: "DetalleFactura");

            migrationBuilder.DropIndex(
                name: "IX_DetalleFactura_FacturaId",
                table: "DetalleFactura");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "DetalleFactura");

            migrationBuilder.RenameTable(
                name: "DetalleFactura",
                newName: "DetallesFacturas");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "DetallesFacturas",
                newName: "ProductoDelDetalleId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleFactura_ProductoId",
                table: "DetallesFacturas",
                newName: "IX_DetallesFacturas_ProductoDelDetalleId");

            migrationBuilder.AddColumn<int>(
                name: "FacturaDelDetalleId",
                table: "DetallesFacturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "DetallesFacturas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesFacturas",
                table: "DetallesFacturas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesFacturas_FacturaDelDetalleId",
                table: "DetallesFacturas",
                column: "FacturaDelDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesFacturas_Facturas_FacturaDelDetalleId",
                table: "DetallesFacturas",
                column: "FacturaDelDetalleId",
                principalTable: "Facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesFacturas_Productos_ProductoDelDetalleId",
                table: "DetallesFacturas",
                column: "ProductoDelDetalleId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
