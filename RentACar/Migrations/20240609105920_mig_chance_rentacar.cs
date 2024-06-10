using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class mig_chance_rentacar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "MotorPower",
                table: "RentACars");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "CarModel",
                table: "RentACars",
                newName: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_RentACars_CarID",
                table: "RentACars",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACars_Cars_CarID",
                table: "RentACars",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACars_Cars_CarID",
                table: "RentACars");

            migrationBuilder.DropIndex(
                name: "IX_RentACars_CarID",
                table: "RentACars");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "RentACars",
                newName: "CarModel");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarBrand",
                table: "RentACars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotorPower",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "RentACars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
