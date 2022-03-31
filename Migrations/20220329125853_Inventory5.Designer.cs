﻿// <auto-generated />
using System;
using InventoryManagementSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagementSystem.Migrations
{
    [DbContext(typeof(MyDebContext))]
    [Migration("20220329125853_Inventory5")]
    partial class Inventory5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("InventoryManagementSystem.INVOICE", b =>
                {
                    b.Property<int>("Invoice_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Customer_ID")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<DateTime>("Payment_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total_Price")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.Property<int>("Unit_Sold")
                        .HasMaxLength(15)
                        .HasColumnType("int");

                    b.HasKey("Invoice_ID");

                    b.ToTable("INVOICE_DATA");
                });

            modelBuilder.Entity("InventoryManagementSystem.ProductCategories", b =>
                {
                    b.Property<int>("Product_Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Product_Category_ID");

                    b.ToTable("PRODUCT_CATEGORIES");
                });

            modelBuilder.Entity("InventoryManagementSystem.Products", b =>
                {
                    b.Property<int>("Products_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Current_Storage")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Product_Category_ID")
                        .HasColumnType("int");

                    b.Property<int>("Remaining_Quantity")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<int>("Sold")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("SubProduct_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Total_Selling_Amount")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<int>("Unit_Price")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.HasKey("Products_ID");

                    b.HasIndex("Product_Category_ID");

                    b.ToTable("PRODUCTS");
                });

            modelBuilder.Entity("InventoryManagementSystem.ROLE", b =>
                {
                    b.Property<int>("Role_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Role_ID");

                    b.ToTable("ROLES");
                });

            modelBuilder.Entity("InventoryManagementSystem.SHIPPING", b =>
                {
                    b.Property<int>("Shipping_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Customer_ID")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("Invoice_ID")
                        .HasColumnType("int");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<string>("Shipped_From")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Shipped_To")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Shipping_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sold_Quantity")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Total_Price")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.HasKey("Shipping_ID");

                    b.HasIndex("Invoice_ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("SHIPPING");
                });

            modelBuilder.Entity("InventoryManagementSystem.USERS", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Role_ID")
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Zip_Code")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.HasKey("User_ID");

                    b.HasIndex("Role_ID");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("InventoryManagementSystem.Products", b =>
                {
                    b.HasOne("InventoryManagementSystem.ProductCategories", "ProductCategories")
                        .WithMany("Products")
                        .HasForeignKey("Product_Category_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("InventoryManagementSystem.SHIPPING", b =>
                {
                    b.HasOne("InventoryManagementSystem.INVOICE", "INVOICE")
                        .WithMany("SHIPPING")
                        .HasForeignKey("Invoice_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagementSystem.Products", "Product")
                        .WithMany("SHIPPING")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("INVOICE");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InventoryManagementSystem.USERS", b =>
                {
                    b.HasOne("InventoryManagementSystem.ROLE", "ROLE")
                        .WithMany("USERS")
                        .HasForeignKey("Role_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ROLE");
                });

            modelBuilder.Entity("InventoryManagementSystem.INVOICE", b =>
                {
                    b.Navigation("SHIPPING");
                });

            modelBuilder.Entity("InventoryManagementSystem.ProductCategories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InventoryManagementSystem.Products", b =>
                {
                    b.Navigation("SHIPPING");
                });

            modelBuilder.Entity("InventoryManagementSystem.ROLE", b =>
                {
                    b.Navigation("USERS");
                });
#pragma warning restore 612, 618
        }
    }
}
