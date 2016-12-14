using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryApp.Migrations
{
    public partial class sad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Restaurants_Restaurantid",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_Restaurantid",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "Restaurantid",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "Restaurant",
                table: "Dishes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Restaurant",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "Restaurantid",
                table: "Dishes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_Restaurantid",
                table: "Dishes",
                column: "Restaurantid");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Restaurants_Restaurantid",
                table: "Dishes",
                column: "Restaurantid",
                principalTable: "Restaurants",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
