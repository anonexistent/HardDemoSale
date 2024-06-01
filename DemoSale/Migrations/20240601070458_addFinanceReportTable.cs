using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSale.Migrations
{
    /// <inheritdoc />
    public partial class addFinanceReportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinanceReport",
                columns: table => new
                {
                    id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pktId = table.Column<uint>(type: "INTEGER", nullable: false),
                    dateCreate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    headPart = table.Column<double>(type: "REAL", nullable: false),
                    agent = table.Column<string>(type: "TEXT", nullable: true),
                    agentPart = table.Column<double>(type: "REAL", nullable: false),
                    manager = table.Column<string>(type: "TEXT", nullable: false),
                    region = table.Column<string>(type: "TEXT", nullable: false),
                    document = table.Column<string>(type: "TEXT", nullable: false),
                    dateShipment = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    sellerAgent = table.Column<string>(type: "TEXT", nullable: false),
                    difference = table.Column<double>(type: "REAL", nullable: false),
                    managerPart = table.Column<double>(type: "REAL", nullable: false),
                    buyer = table.Column<string>(type: "TEXT", nullable: false),
                    buyerPart = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceReport", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinanceReport");
        }
    }
}
