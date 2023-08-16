using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerAPI.Migrations
{
    /// <inheritdoc />
    public partial class addTableVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleModel = table.Column<int>(type: "int", nullable: false),
                    VehiclePlaque = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
