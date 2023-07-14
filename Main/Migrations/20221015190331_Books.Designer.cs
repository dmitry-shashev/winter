﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Winter.Core;

#nullable disable

namespace Winter.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221015190331_Books")]
    partial class Books
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Main.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Jane Austen",
                            BookName = "Pride and Prejudice",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Author = "George Orwell",
                            BookName = "1984",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Author = "Hamlet",
                            BookName = "William Shakespeare",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Main.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 10, 15, 22, 3, 30, 898, DateTimeKind.Local).AddTicks(4430),
                            Email = "tt1@tt.tt",
                            FirstName = "Tester",
                            LastName = "Testerov",
                            Phone = "12-12-12"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 10, 15, 22, 3, 30, 898, DateTimeKind.Local).AddTicks(4470),
                            Email = "tt2@tt.tt",
                            FirstName = "Mike",
                            LastName = "Tyson",
                            Phone = "13-99-14"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 10, 15, 22, 3, 30, 898, DateTimeKind.Local).AddTicks(4480),
                            Email = "tt3@tt.tt",
                            FirstName = "Red",
                            LastName = "Sky",
                            Phone = "33-33-32"
                        });
                });

            modelBuilder.Entity("Main.Models.Book", b =>
                {
                    b.HasOne("Main.Models.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Main.Models.User", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}