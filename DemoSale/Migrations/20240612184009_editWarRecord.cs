using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSale.Migrations
{
    /// <inheritdoc />
    public partial class editWarRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarrantyRecord_Pkt_pktParentId",
                table: "WarrantyRecord");

            migrationBuilder.DropColumn(
                name: "dateShipment",
                table: "WarrantyRecord");

            migrationBuilder.RenameColumn(
                name: "pktParentId",
                table: "WarrantyRecord",
                newName: "pktId");

            migrationBuilder.RenameColumn(
                name: "dateUnsubscribe",
                table: "WarrantyRecord",
                newName: "warContractserviceContract");

            migrationBuilder.RenameIndex(
                name: "IX_WarrantyRecord_pktParentId",
                table: "WarrantyRecord",
                newName: "IX_WarrantyRecord_pktId");

            migrationBuilder.CreateIndex(
                name: "IX_WarrantyRecord_warContractserviceContract",
                table: "WarrantyRecord",
                column: "warContractserviceContract");

            migrationBuilder.AddForeignKey(
                name: "FK_WarrantyRecord_Pkt_pktId",
                table: "WarrantyRecord",
                column: "pktId",
                principalTable: "Pkt",
                principalColumn: "pktId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WarrantyRecord_WarrantyContract_warContractserviceContract",
                table: "WarrantyRecord",
                column: "warContractserviceContract",
                principalTable: "WarrantyContract",
                principalColumn: "serviceContract");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WarrantyRecord_Pkt_pktId",
                table: "WarrantyRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_WarrantyRecord_WarrantyContract_warContractserviceContract",
                table: "WarrantyRecord");

            migrationBuilder.DropIndex(
                name: "IX_WarrantyRecord_warContractserviceContract",
                table: "WarrantyRecord");

            migrationBuilder.RenameColumn(
                name: "warContractserviceContract",
                table: "WarrantyRecord",
                newName: "dateUnsubscribe");

            migrationBuilder.RenameColumn(
                name: "pktId",
                table: "WarrantyRecord",
                newName: "pktParentId");

            migrationBuilder.RenameIndex(
                name: "IX_WarrantyRecord_pktId",
                table: "WarrantyRecord",
                newName: "IX_WarrantyRecord_pktParentId");

            migrationBuilder.AddColumn<DateOnly>(
                name: "dateShipment",
                table: "WarrantyRecord",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WarrantyRecord_Pkt_pktParentId",
                table: "WarrantyRecord",
                column: "pktParentId",
                principalTable: "Pkt",
                principalColumn: "pktId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
