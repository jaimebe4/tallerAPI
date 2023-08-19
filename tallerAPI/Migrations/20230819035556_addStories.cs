using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    IdStorie = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorieDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StorieHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorieKm = table.Column<long>(type: "bigint", nullable: false),
                    StorieType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorieLocal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoriePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StorieNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdVehicle = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.IdStorie);
                    table.ForeignKey(
                        name: "FK_Stories_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stories_VehicleId",
                table: "Stories",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
