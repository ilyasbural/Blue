using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class werwerew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DistrictId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FeaturesAroundId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FeaturesInsideId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FeaturesOutsideId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FromWhoId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuelTypeId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FurnitureId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HometownId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PriceId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SizeId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WarmingId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_CityId",
                table: "RealEstate",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_DistrictId",
                table: "RealEstate",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FeaturesAroundId",
                table: "RealEstate",
                column: "FeaturesAroundId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FeaturesInsideId",
                table: "RealEstate",
                column: "FeaturesInsideId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FeaturesOutsideId",
                table: "RealEstate",
                column: "FeaturesOutsideId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FromWhoId",
                table: "RealEstate",
                column: "FromWhoId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FuelTypeId",
                table: "RealEstate",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_FurnitureId",
                table: "RealEstate",
                column: "FurnitureId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_HometownId",
                table: "RealEstate",
                column: "HometownId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_PriceId",
                table: "RealEstate",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_RoomId",
                table: "RealEstate",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_SizeId",
                table: "RealEstate",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_StatusId",
                table: "RealEstate",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_TypeId",
                table: "RealEstate",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_WarmingId",
                table: "RealEstate",
                column: "WarmingId");

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_City_CityId",
                table: "RealEstate",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_District_DistrictId",
                table: "RealEstate",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_FeaturesAround_FeaturesAroundId",
                table: "RealEstate",
                column: "FeaturesAroundId",
                principalTable: "FeaturesAround",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_FeaturesInside_FeaturesInsideId",
                table: "RealEstate",
                column: "FeaturesInsideId",
                principalTable: "FeaturesInside",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_FeaturesOutside_FeaturesOutsideId",
                table: "RealEstate",
                column: "FeaturesOutsideId",
                principalTable: "FeaturesOutside",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_FromWho_FromWhoId",
                table: "RealEstate",
                column: "FromWhoId",
                principalTable: "FromWho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_FuelType_FuelTypeId",
                table: "RealEstate",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Furniture_FurnitureId",
                table: "RealEstate",
                column: "FurnitureId",
                principalTable: "Furniture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Hometown_HometownId",
                table: "RealEstate",
                column: "HometownId",
                principalTable: "Hometown",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Price_PriceId",
                table: "RealEstate",
                column: "PriceId",
                principalTable: "Price",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Room_RoomId",
                table: "RealEstate",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Size_SizeId",
                table: "RealEstate",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Status_StatusId",
                table: "RealEstate",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Type_TypeId",
                table: "RealEstate",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_Warming_WarmingId",
                table: "RealEstate",
                column: "WarmingId",
                principalTable: "Warming",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_City_CityId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_District_DistrictId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_FeaturesAround_FeaturesAroundId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_FeaturesInside_FeaturesInsideId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_FeaturesOutside_FeaturesOutsideId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_FromWho_FromWhoId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_FuelType_FuelTypeId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Furniture_FurnitureId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Hometown_HometownId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Price_PriceId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Room_RoomId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Size_SizeId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Status_StatusId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Type_TypeId",
                table: "RealEstate");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_Warming_WarmingId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_CityId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_DistrictId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FeaturesAroundId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FeaturesInsideId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FeaturesOutsideId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FromWhoId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FuelTypeId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_FurnitureId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_HometownId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_PriceId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_RoomId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_SizeId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_StatusId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_TypeId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_WarmingId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FeaturesAroundId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FeaturesInsideId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FeaturesOutsideId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FromWhoId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "FurnitureId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "HometownId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "WarmingId",
                table: "RealEstate");
        }
    }
}
