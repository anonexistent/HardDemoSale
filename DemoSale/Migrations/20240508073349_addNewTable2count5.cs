using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSale.Migrations
{
    /// <inheritdoc />
    public partial class addNewTable2count5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TatarstanReport",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    count = table.Column<int>(type: "INTEGER", nullable: false),
                    dateShipment = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    paymentMethod = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", nullable: true),
                    pktId = table.Column<uint>(type: "INTEGER", nullable: false),
                    positionName = table.Column<string>(type: "TEXT", nullable: true),
                    realization = table.Column<double>(type: "REAL", nullable: false),
                    region = table.Column<string>(type: "TEXT", nullable: true),
                    seller = table.Column<string>(type: "TEXT", nullable: true),
                    sellerAgent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TatarstanReport", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
