﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class jgjghjghjjkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Management",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hometown",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Management");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hometown");
        }
    }
}
