﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DeliveryApp.Models;

namespace DeliveryApp.Migrations
{
    [DbContext(typeof(DeliveryContext))]
    [Migration("20161211071514_intiasd")]
    partial class intiasd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("DeliveryApp.Models.Dishes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Restaurantid");

                    b.Property<int>("key");

                    b.Property<string>("name");

                    b.Property<double>("price");

                    b.Property<string>("string_id");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.HasIndex("Restaurantid");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("DeliveryApp.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Dishesid");

                    b.Property<string>("adress");

                    b.Property<int>("key");

                    b.Property<string>("name");

                    b.Property<string>("phone");

                    b.HasKey("id");

                    b.HasIndex("Dishesid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DeliveryApp.Models.Restaurants", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adress");

                    b.Property<int>("kitchen");

                    b.Property<string>("name");

                    b.Property<int>("spec");

                    b.Property<string>("string_id");

                    b.HasKey("id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("DeliveryApp.Models.Dishes", b =>
                {
                    b.HasOne("DeliveryApp.Models.Restaurants", "Restaurant")
                        .WithMany()
                        .HasForeignKey("Restaurantid");
                });

            modelBuilder.Entity("DeliveryApp.Models.Order", b =>
                {
                    b.HasOne("DeliveryApp.Models.Dishes", "Dishes")
                        .WithMany()
                        .HasForeignKey("Dishesid");
                });
        }
    }
}
