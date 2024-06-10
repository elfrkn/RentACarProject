using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_DestinationLocation_DestinationLocationID",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_ReceivingLocationID",
                table: "RentACars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestinationLocation",
                table: "DestinationLocation");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "ReceivingLocations");

            migrationBuilder.RenameTable(
                name: "DestinationLocation",
                newName: "DestinationLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReceivingLocations",
                table: "ReceivingLocations",
                column: "ReceivingLocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestinationLocations",
                table: "DestinationLocations",
                column: "DestinationLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_DestinationLocations_DestinationLocationID",
                table: "RentACars",
                column: "DestinationLocationID",
                principalTable: "DestinationLocations",
                principalColumn: "DestinationLocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_ReceivingLocations_ReceivingLocationID",
                table: "RentACars",
                column: "ReceivingLocationID",
                principalTable: "ReceivingLocations",
                principalColumn: "ReceivingLocationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_DestinationLocations_DestinationLocationID",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_ReceivingLocations_ReceivingLocationID",
                table: "RentACars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReceivingLocations",
                table: "ReceivingLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DestinationLocations",
                table: "DestinationLocations");

            migrationBuilder.RenameTable(
                name: "ReceivingLocations",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "DestinationLocations",
                newName: "DestinationLocation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "ReceivingLocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DestinationLocation",
                table: "DestinationLocation",
                column: "DestinationLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_DestinationLocation_DestinationLocationID",
                table: "RentACars",
                column: "DestinationLocationID",
                principalTable: "DestinationLocation",
                principalColumn: "DestinationLocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Locations_ReceivingLocationID",
                table: "RentACars",
                column: "ReceivingLocationID",
                principalTable: "Locations",
                principalColumn: "ReceivingLocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
