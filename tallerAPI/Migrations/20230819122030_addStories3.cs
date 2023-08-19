using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerAPI.Migrations
{
    /// <inheritdoc />
    public partial class addStories3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories");

            migrationBuilder.DropColumn(
                name: "IdVehicle",
                table: "Stories");

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId",
                table: "Stories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories");

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId",
                table: "Stories",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "IdVehicle",
                table: "Stories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id");
        }
    }
}
