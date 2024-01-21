﻿// <auto-generated />
using System;
using BooksAppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksAppData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240121100747_CreatePagesTable")]
    partial class CreatePagesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("BooksAppData.Entities.AnalyticsVisitEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("UserAgent")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_agent");

                    b.HasKey("Id");

                    b.ToTable("analytics_visits");
                });

            modelBuilder.Entity("BooksAppData.Entities.AuthorEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Andrew",
                            LastName = "Lock"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Christian",
                            LastName = "Gammelgaard"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Marinko",
                            LastName = "Spasojevic"
                        });
                });

            modelBuilder.Entity("BooksAppData.Entities.BookEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("author_id");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT")
                        .HasColumnName("isbn");

                    b.Property<int?>("Pages")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("pages");

                    b.Property<int?>("PublishYear")
                        .HasColumnType("INTEGER")
                        .HasColumnName("publish_year");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("publisher_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedAt = new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Pages = 370,
                            PublishYear = 2017,
                            PublisherId = 1,
                            Title = "ASP.NET Core in Action"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            CreatedAt = new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Pages = 300,
                            PublishYear = 2020,
                            PublisherId = 1,
                            Title = "Microservices in .NET"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CreatedAt = new DateTime(2018, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Pages = 250,
                            PublishYear = 2019,
                            PublisherId = 2,
                            Title = "Ultimate ASP.NET Core Web API"
                        });
                });

            modelBuilder.Entity("BooksAppData.Entities.PageEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("created_at");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("slug");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.ToTable("pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "<p>Welcome to my page</p>",
                            CreatedAt = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Slug = "home",
                            Title = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Content = "<p>This is the about page</p>",
                            CreatedAt = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Slug = "about",
                            Title = "About"
                        });
                });

            modelBuilder.Entity("BooksAppData.Entities.PublisherEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manning Publications"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Code Maze"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ef669323-2622-4fee-8907-bebeb8a5b6f9",
                            ConcurrencyStamp = "ef669323-2622-4fee-8907-bebeb8a5b6f9",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "298b0361-dfeb-47e5-881f-433e881b7660",
                            ConcurrencyStamp = "298b0361-dfeb-47e5-881f-433e881b7660",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5e507056-abab-44f2-843d-698458a5976e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ce7bea6-86dc-4e7c-bf3d-9c36c1b1304f",
                            Email = "admin@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEFL4Qzaimqtu5gmTT8a9ki0TA7c4YCyslbuEK+vLUWXdl5vLkWeQNc8vczC4FKJ3Iw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "42609fc8-b5b8-47d9-b697-1af948447a3a",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "b123c767-1ddc-4fdf-b7de-4ae6697c0a61",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9567d3f0-dee8-4b92-8481-20d5b27a8d71",
                            Email = "user@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@WSEI.EDU.PL",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAIAAYagAAAAEHE+cVf61oppCUPIjrY8aPAuPjiu1W7MLosqUpOTl7oqrErIeBAZF07fysUZ9SUubQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e99845c7-b65b-4acc-8e35-0bf6835812f3",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5e507056-abab-44f2-843d-698458a5976e",
                            RoleId = "ef669323-2622-4fee-8907-bebeb8a5b6f9"
                        },
                        new
                        {
                            UserId = "b123c767-1ddc-4fdf-b7de-4ae6697c0a61",
                            RoleId = "298b0361-dfeb-47e5-881f-433e881b7660"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BooksAppData.Entities.BookEntity", b =>
                {
                    b.HasOne("BooksAppData.Entities.AuthorEntity", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("BooksAppData.Entities.PublisherEntity", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BooksAppData.Entities.AuthorEntity", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BooksAppData.Entities.PublisherEntity", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}