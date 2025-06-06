﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaSalesApi.Models.Entities;

#nullable disable

namespace PizzaSalesApi.Migrations
{
    [DbContext(typeof(PizzaSalesContext))]
    [Migration("20250524195333_AddedPizzaTypeReferences")]
    partial class AddedPizzaTypeReferences
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "order_id");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "order_details_id");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "order_id");

                    b.Property<string>("PizzaId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "pizza_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.Pizza", b =>
                {
                    b.Property<string>("PizzaId")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "pizza_id");

                    b.Property<string>("PizzaTypeId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "pizza_type_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PizzaId");

                    b.HasIndex("PizzaTypeId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaType", b =>
                {
                    b.Property<string>("PizzaTypeId")
                        .HasColumnType("TEXT")
                        .HasAnnotation("Relational:JsonPropertyName", "pizza_type_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PizzaTypeId");

                    b.ToTable("PizzaTypes");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaTypeCategory", b =>
                {
                    b.Property<int>("PizzaTypeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PizzaTypeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PizzaTypeCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PizzaTypeId");

                    b.ToTable("PizzaTypeCategories");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaTypeIngredient", b =>
                {
                    b.Property<int>("PizzaTypeIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PizzaTypeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PizzaTypeIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("PizzaTypeId");

                    b.ToTable("PizzaTypeIngredients");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.OrderDetail", b =>
                {
                    b.HasOne("PizzaSalesApi.Models.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSalesApi.Models.Entities.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.Pizza", b =>
                {
                    b.HasOne("PizzaSalesApi.Models.Entities.PizzaType", "PizzaType")
                        .WithMany()
                        .HasForeignKey("PizzaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PizzaType");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaTypeCategory", b =>
                {
                    b.HasOne("PizzaSalesApi.Models.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSalesApi.Models.Entities.PizzaType", "PizzaType")
                        .WithMany("PizzaTypeCategories")
                        .HasForeignKey("PizzaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("PizzaType");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaTypeIngredient", b =>
                {
                    b.HasOne("PizzaSalesApi.Models.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSalesApi.Models.Entities.PizzaType", "PizzaType")
                        .WithMany("PizzaTypeIngredients")
                        .HasForeignKey("PizzaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("PizzaType");
                });

            modelBuilder.Entity("PizzaSalesApi.Models.Entities.PizzaType", b =>
                {
                    b.Navigation("PizzaTypeCategories");

                    b.Navigation("PizzaTypeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
