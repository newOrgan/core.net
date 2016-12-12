using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryApp.Migrations
{
    public partial class intiasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    adress = table.Column<string>(nullable: true),
                    kitchen = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    spec = table.Column<int>(nullable: false),
                    string_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Restaurantid = table.Column<int>(nullable: true),
                    key = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    string_id = table.Column<string>(nullable: true),
                    type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Dishes_Restaurants_Restaurantid",
                        column: x => x.Restaurantid,
                        principalTable: "Restaurants",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Dishesid = table.Column<int>(nullable: true),
                    adress = table.Column<string>(nullable: true),
                    key = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                    table.ForeignKey(
                        name: "FK_Order_Dishes_Dishesid",
                        column: x => x.Dishesid,
                        principalTable: "Dishes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_Restaurantid",
                table: "Dishes",
                column: "Restaurantid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Dishesid",
                table: "Order",
                column: "Dishesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
