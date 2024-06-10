using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "DestinationLocation",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "ReceivingLocation",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "RentACars",
                newName: "ReceivingLocationID");

            migrationBuilder.RenameColumn(
                name: "LacationID",
                table: "RentACars",
                newName: "DestinationLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_LocationID",
                table: "RentACars",
                newName: "IX_RentACars_ReceivingLocationID");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Locations",
                newName: "ReceivingLocationID");

            migrationBuilder.CreateTable(
                name: "DestinationLocation",
                columns: table => new
                {
                    DestinationLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationLocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationLocation", x => x.DestinationLocationID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_DestinationLocationID",
                table: "RentACars",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_DestinationLocation_DestinationLocationID",
                table: "RentACars");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Locations_ReceivingLocationID",
                table: "RentACars");

            migrationBuilder.DropTable(
                name: "DestinationLocation");

            migrationBuilder.DropIndex(
                name: "IX_RentACars_DestinationLocationID",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "ReceivingLocationID",
                table: "RentACars",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "DestinationLocationID",
                table: "RentACars",
                newName: "LacationID");

            migrationBuilder.RenameIndex(
                name: "IX_RentACars_ReceivingLocationID",
                table: "RentACars",
                newName: "IX_RentACars_LocationID");

            migrationBuilder.RenameColumn(
                name: "ReceivingLocationID",
                table: "Locations",
                newName: "LocationID");

            migrationBuilder.AddColumn<string>(
                name: "DestinationLocation",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceivingLocation",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Locations_LocationID",
                table: "RentACars",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
