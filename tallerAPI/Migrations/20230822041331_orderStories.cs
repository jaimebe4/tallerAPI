using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tallerAPI.Migrations
{
    /// <inheritdoc />
    public partial class orderStories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stories",
                table: "Stories");

            migrationBuilder.RenameTable(
                name: "Stories",
                newName: "Storie");

            migrationBuilder.RenameIndex(
                name: "IX_Stories_VehicleId",
                table: "Storie",
                newName: "IX_Storie_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storie",
                table: "Storie",
                column: "IdStorie");

            migrationBuilder.AddForeignKey(
                name: "FK_Storie_Vehicle_VehicleId",
                table: "Storie",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Storie_Vehicle_VehicleId",
                table: "Storie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storie",
                table: "Storie");

            migrationBuilder.RenameTable(
                name: "Storie",
                newName: "Stories");

            migrationBuilder.RenameIndex(
                name: "IX_Storie_VehicleId",
                table: "Stories",
                newName: "IX_Stories_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stories",
                table: "Stories",
                column: "IdStorie");

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Vehicle_VehicleId",
                table: "Stories",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
