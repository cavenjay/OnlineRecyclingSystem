using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineRecyclingSystem.Migrations.OnlineRecyclingSystemOrderMigrations
{
    public partial class createOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CusName = table.Column<string>(nullable: true),
                    CusContact = table.Column<string>(nullable: true),
                    CusAddress = table.Column<string>(nullable: true),
                    BigBottle = table.Column<string>(nullable: true),
                    SmallBottle = table.Column<string>(nullable: true),
                    Can = table.Column<string>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    DriverContact = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
