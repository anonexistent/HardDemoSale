using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSale.Migrations
{
    /// <inheritdoc />
    public partial class editFinanceReportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sellerAgent",
                table: "FinanceReport",
                newName: "seller");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "dateShipment",
                table: "Pkt",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "dateEntry",
                table: "Pkt",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "buyer",
                table: "FinanceReport",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "seller",
                table: "FinanceReport",
                newName: "sellerAgent");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "dateShipment",
                table: "Pkt",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "dateEntry",
                table: "Pkt",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "buyer",
                table: "FinanceReport",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
