﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int?>("BuyerUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("BuyerUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SellerUserId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SellerUserId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StreetBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNbr")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users", t =>
                        {
                            t.HasCheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
                        });

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            City = "Brussels",
                            Country = "Belgium",
                            Email = "jeremy.bazin@email.com",
                            Firstname = "Jeremy",
                            Lastname = "Bazin",
                            Password = "Test123=",
                            Phone = "+32 2 123 45 67",
                            Role = 0,
                            Street = "Rue de la Paix",
                            StreetNbr = 10,
                            ZipCode = "1000"
                        },
                        new
                        {
                            UserId = 2,
                            City = "New York",
                            Country = "USA",
                            Email = "bob.martin@email.com",
                            Firstname = "Bob",
                            Lastname = "Martin",
                            Password = "5Gh#zBvKw3PxYrE",
                            Phone = "+1 123-456-7890",
                            Role = 2,
                            Street = "Main Street",
                            StreetNbr = 25,
                            ZipCode = "12345"
                        },
                        new
                        {
                            UserId = 3,
                            City = "Los Angeles",
                            Country = "USA",
                            Email = "charlie.nguyen@email.com",
                            Firstname = "Charlie",
                            Lastname = "Nguyen",
                            Password = "fT7#eRm2QxLz9Dy$",
                            Phone = "+1 234-567-8901",
                            Role = 1,
                            Street = "Highway Road",
                            StreetNbr = 50,
                            ZipCode = "67890"
                        },
                        new
                        {
                            UserId = 4,
                            City = "London",
                            Country = "UK",
                            Email = "david.lee@email.com",
                            Firstname = "David",
                            Lastname = "Lee",
                            Password = "V6b$UwPcNz @hM8xK",
                            Phone = "+44 20 1234 5678",
                            Role = 2,
                            Street = "Oxford Street",
                            StreetNbr = 15,
                            ZipCode = "W1D 1BS"
                        },
                        new
                        {
                            UserId = 5,
                            City = "Barcelona",
                            Country = "Spain",
                            Email = "emma.garcia@email.com",
                            Firstname = "Emma",
                            Lastname = "Garcia",
                            Password = "aH5%kXjL9$qBm2W",
                            Phone = "+34 93 123 45 67",
                            Role = 1,
                            Street = "Carrer de Balmes",
                            StreetNbr = 12,
                            ZipCode = "08007"
                        },
                        new
                        {
                            UserId = 6,
                            City = "Shanghai",
                            Country = "China",
                            Email = "frank.chen@email.com",
                            Firstname = "Frank",
                            Lastname = "Chen",
                            Password = "qJ9@fM8cWu5$xLrE",
                            Phone = "+86 21 1234 5678",
                            Role = 2,
                            Street = "Nanjing Road",
                            StreetNbr = 100,
                            ZipCode = "200000"
                        },
                        new
                        {
                            UserId = 7,
                            City = "Brussels",
                            Country = "Belgium",
                            Email = "grace.wong@email.com",
                            Firstname = "Grace",
                            Lastname = "Wong",
                            Password = "7Km&zRb#vGy2hNj",
                            Phone = "555-1234",
                            Role = 2,
                            Street = "3 Main St",
                            StreetNbr = 35,
                            ZipCode = "1000"
                        },
                        new
                        {
                            UserId = 8,
                            City = "Brussels",
                            Country = "Belgium",
                            Email = "henry.zhang@email.com",
                            Firstname = "Henry",
                            Lastname = "Zhang",
                            Password = "T4c#nSv@wGj2RkF",
                            Phone = "555-1234",
                            Role = 1,
                            Street = "9 High St",
                            StreetNbr = 45,
                            ZipCode = "1000"
                        },
                        new
                        {
                            UserId = 9,
                            City = "Brussels",
                            Country = "Belgium",
                            Email = "isabella.lopez@email.com",
                            Firstname = "Isabella",
                            Lastname = "Lopez",
                            Password = "H8f$kL3q#sVp9Xy",
                            Phone = "555-1234",
                            Role = 1,
                            Street = "12 Park Ave",
                            StreetNbr = 24,
                            ZipCode = "1000"
                        },
                        new
                        {
                            UserId = 10,
                            City = "Brussels",
                            Country = "Belgium",
                            Email = "jack.kim@email.com",
                            Firstname = "Jack",
                            Lastname = "Kim",
                            Password = "3ZgY*6tLx#pVfDhN",
                            Phone = "555-1234",
                            Role = 2,
                            Street = "15 Rue de la Loi",
                            StreetNbr = 4,
                            ZipCode = "1000"
                        });
                });

            modelBuilder.Entity("DAL.Models.Invoice", b =>
                {
                    b.HasOne("DAL.Models.User", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerUserId");

                    b.HasOne("DAL.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Buyer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.HasOne("DAL.Models.User", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerUserId");

                    b.Navigation("Seller");
                });
#pragma warning restore 612, 618
        }
    }
}
