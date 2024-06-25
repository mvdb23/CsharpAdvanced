using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsharpAdvanced23_24.Migrations
{
    public partial class migrate_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location");

            migrationBuilder.AlterColumn<int>(
                name: "LandlordId",
                table: "Location",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location");

            migrationBuilder.AlterColumn<int>(
                name: "LandlordId",
                table: "Location",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Landlord_LandlordId",
                table: "Location",
                column: "LandlordId",
                principalTable: "Landlord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
