﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Winter.Core;

#nullable disable

namespace Winter.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryUser", b =>
                {
                    b.Property<int>("LibrariesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("LibrariesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("LibraryUser");

                    b.HasData(
                        new
                        {
                            LibrariesId = 1,
                            UsersId = 1
                        },
                        new
                        {
                            LibrariesId = 1,
                            UsersId = 2
                        },
                        new
                        {
                            LibrariesId = 2,
                            UsersId = 3
                        });
                });

            modelBuilder.Entity("Winter.Models.Book", b =>
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

            modelBuilder.Entity("Winter.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Some street"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Work street"
                        });
                });

            modelBuilder.Entity("Winter.Models.User", b =>
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
                            CreatedAt = new DateTime(2022, 10, 18, 20, 43, 8, 89, DateTimeKind.Local).AddTicks(8490),
                            Email = "tt1@tt.tt",
                            FirstName = "Tester",
                            LastName = "Testerov",
                            Phone = "12-12-12"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 10, 18, 20, 43, 8, 89, DateTimeKind.Local).AddTicks(8530),
                            Email = "tt2@tt.tt",
                            FirstName = "Mike",
                            LastName = "Tyson",
                            Phone = "13-99-14"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 10, 18, 20, 43, 8, 89, DateTimeKind.Local).AddTicks(8540),
                            Email = "tt3@tt.tt",
                            FirstName = "Red",
                            LastName = "Sky",
                            Phone = "33-33-32"
                        });
                });

            modelBuilder.Entity("LibraryUser", b =>
                {
                    b.HasOne("Winter.Models.Library", null)
                        .WithMany()
                        .HasForeignKey("LibrariesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Winter.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Winter.Models.Book", b =>
                {
                    b.HasOne("Winter.Models.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Winter.Models.User", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
