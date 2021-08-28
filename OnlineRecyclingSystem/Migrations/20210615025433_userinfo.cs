using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRecyclingSystem.Migrations
{
    public partial class userinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User_Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "User_DOB",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "User_Name",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_DOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_Name",
                table: "AspNetUsers");
        }
    }
}
