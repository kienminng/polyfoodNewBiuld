﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolyFood.Repository.Context;

#nullable disable

namespace PolyFood.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231223090541_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PolyFood.Entity.Entity.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Decentralization_Id")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResestPasswordToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetPasswordTokenExpiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("id")
                        .HasColumnType("bigint");

                    b.HasKey("AccountId");

                    b.HasIndex("Decentralization_Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Cart", b =>
                {
                    b.Property<int>("Cart_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cart_Id"));

                    b.Property<DateTime?>("Create_At")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("User_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<long>("id")
                        .HasColumnType("bigint");

                    b.HasKey("Cart_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.CartItem", b =>
                {
                    b.Property<int>("Cart_Item_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cart_Item_Id"));

                    b.Property<int>("Cart_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Product_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Cart_Item_Id");

                    b.HasIndex("Cart_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Decentralization", b =>
                {
                    b.Property<int>("Decentralization_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Decentralization_Id"));

                    b.Property<string>("Authority_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Decentralization_Id");

                    b.ToTable("Decentralizations");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Order", b =>
                {
                    b.Property<int>("Order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_Id"));

                    b.Property<double>("Actual_Price")
                        .HasColumnType("float");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Created")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order_Status_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double>("Original_Price")
                        .HasColumnType("float");

                    b.Property<int?>("Payment_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Order_Id");

                    b.HasIndex("Order_Status_Id");

                    b.HasIndex("Payment_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.OrderDetail", b =>
                {
                    b.Property<int>("Order_Detail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_Detail_Id"));

                    b.Property<DateTime?>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Order_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double>("Price_Total")
                        .HasColumnType("float");

                    b.Property<int?>("Product_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Order_Detail_Id");

                    b.HasIndex("Order_Id");

                    b.HasIndex("Product_Id");

                    b.ToTable("OrdersDetail");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.OrderStatus", b =>
                {
                    b.Property<int>("Order_Status_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_Status_Id"));

                    b.Property<string>("Status_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_Status_Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Payment", b =>
                {
                    b.Property<int>("Payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Payment_Id"));

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment_Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Payment_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Id"));

                    b.Property<string>("Avatar_Image_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Name_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Number_Of_View")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductType_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Product_Id");

                    b.HasIndex("ProductType_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.ProductReview", b =>
                {
                    b.Property<int>("Product_Review_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Review_Id"));

                    b.Property<string>("Content_Seen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content_rated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ponit_Evaluation")
                        .HasColumnType("int");

                    b.Property<int?>("Product_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<int?>("User_Id")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Product_Review_Id");

                    b.HasIndex("Product_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.ProductType", b =>
                {
                    b.Property<int>("Product_Type_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Type_Id"));

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image_Type_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Product_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.HasKey("Product_Type_Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Token", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TokenId"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.HasKey("TokenId");

                    b.HasIndex("AccountId")
                        .IsUnique()
                        .HasFilter("[AccountId] IS NOT NULL");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("Account_Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Create_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Account_Id")
                        .IsUnique()
                        .HasFilter("[Account_Id] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Account", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Decentralization", "Decentralization")
                        .WithMany("Accounts")
                        .HasForeignKey("Decentralization_Id");

                    b.Navigation("Decentralization");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Cart", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.CartItem", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("Cart_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyFood.Entity.Entity.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Order", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.OrderStatus", "Order_Status")
                        .WithMany("Orders")
                        .HasForeignKey("Order_Status_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyFood.Entity.Entity.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("Payment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyFood.Entity.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id");

                    b.Navigation("Order_Status");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.OrderDetail", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyFood.Entity.Entity.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Product", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductType_Id");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.ProductReview", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyFood.Entity.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Token", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Account", "Account")
                        .WithOne("Token")
                        .HasForeignKey("PolyFood.Entity.Entity.Token", "AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.User", b =>
                {
                    b.HasOne("PolyFood.Entity.Entity.Account", "Account")
                        .WithOne("Users")
                        .HasForeignKey("PolyFood.Entity.Entity.User", "Account_Id");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Account", b =>
                {
                    b.Navigation("Token");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Decentralization", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PolyFood.Entity.Entity.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}