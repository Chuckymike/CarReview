﻿// <auto-generated />
using System;
using CarReview.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarReview.Migrations
{
    [DbContext(typeof(CarBlogContext))]
    partial class CarBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarReview.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electric",
                            Image = "C8 Chevy Corvette Stingray.jpg"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Luxury",
                            Image = "C8 Chevy Corvette Stingray.jpg"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Exotic",
                            Image = "C8 Chevy Corvette Stingray.jpg"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Sport",
                            Image = "C8 Chevy Corvette Stingray.jpg"
                        });
                });

            modelBuilder.Entity("CarReview.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Steve Jobs",
                            Body = "My new car is amazing",
                            CategoryId = 1,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 706, DateTimeKind.Local).AddTicks(8416),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Steve Madden",
                            Body = "The candy apple red looks great in the summer.",
                            CategoryId = 1,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6124),
                            Title = "New Car"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Elon Musk",
                            Body = "My used car sucks",
                            CategoryId = 2,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6191),
                            Title = "Used Car"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Stradman",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6199),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Mr. Bloomberg",
                            Body = "Not a good good",
                            CategoryId = 3,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6203),
                            Title = "Certfied Preowned"
                        },
                        new
                        {
                            Id = 5,
                            Author = "DoctaM3",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6207),
                            Title = "Salvage Title"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Dr. Jay",
                            Body = "Great project car",
                            CategoryId = 4,
                            PublishDate = new DateTime(2020, 6, 28, 23, 16, 25, 711, DateTimeKind.Local).AddTicks(6210),
                            Title = "Lease"
                        });
                });

            modelBuilder.Entity("CarReview.Models.Content", b =>
                {
                    b.HasOne("CarReview.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
