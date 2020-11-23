﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class UserFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "User");
        }
    }
}
