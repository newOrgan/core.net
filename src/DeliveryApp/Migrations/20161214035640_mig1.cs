using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryApp.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantID",
                table: "Dishes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_RestaurantID",
                table: "Dishes",
                column: "RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantID",
                table: "Dishes",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Restaurants_RestaurantID",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_RestaurantID",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "RestaurantID",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "Restaurant",
                table: "Dishes",
                nullable: false,
                defaultValue: 0);
        }
    }
}
