using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class werwerwer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BuyingTypeId",
                table: "RealEstate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RealEstate_BuyingTypeId",
                table: "RealEstate",
                column: "BuyingTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstate_BuyingType_BuyingTypeId",
                table: "RealEstate",
                column: "BuyingTypeId",
                principalTable: "BuyingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RealEstate_BuyingType_BuyingTypeId",
                table: "RealEstate");

            migrationBuilder.DropIndex(
                name: "IX_RealEstate_BuyingTypeId",
                table: "RealEstate");

            migrationBuilder.DropColumn(
                name: "BuyingTypeId",
                table: "RealEstate");
        }
    }
}
