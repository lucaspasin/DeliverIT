using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverITTestAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NmBill = table.Column<string>(type: "TEXT", nullable: false),
                    VlOriginal = table.Column<double>(type: "REAL", nullable: false),
                    DtDue = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DtPayment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VlCorrected = table.Column<double>(type: "REAL", nullable: false),
                    NuDaysLate = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");
        }
    }
}
