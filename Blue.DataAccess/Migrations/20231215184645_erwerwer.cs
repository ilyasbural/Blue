﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class erwerwer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BuildingType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BuildingType");
        }
    }
}