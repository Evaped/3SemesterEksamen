﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rally.Server.Data;

#nullable disable

namespace Rally.Server.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20240529060446_UpdatedElement")]
    partial class UpdatedElement
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Rally.Domain.Models.Arrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Arrows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direction = 0,
                            Length = 1,
                            Position = 1
                        },
                        new
                        {
                            Id = 2,
                            Direction = 1,
                            Length = 2,
                            Position = 2
                        },
                        new
                        {
                            Id = 3,
                            Direction = 2,
                            Length = 3,
                            Position = 3
                        },
                        new
                        {
                            Id = 4,
                            Direction = 3,
                            Length = 4,
                            Position = 4
                        },
                        new
                        {
                            Id = 5,
                            Direction = 4,
                            Length = 5,
                            Position = 5
                        },
                        new
                        {
                            Id = 6,
                            Direction = 5,
                            Length = 6,
                            Position = 6
                        },
                        new
                        {
                            Id = 7,
                            Direction = 7,
                            Length = 7,
                            Position = 7
                        },
                        new
                        {
                            Id = 8,
                            Direction = 6,
                            Length = 8,
                            Position = 8
                        });
                });

            modelBuilder.Entity("Rally.Domain.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Chats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MemberId = 1,
                            Message = "Hej Hans, jeg har oprettet en fælles bane i Course 4"
                        },
                        new
                        {
                            Id = 2,
                            MemberId = 2,
                            Message = "Hej Grethe, jeg har færdiggjort Course 3 og delt den. Jeg går i gang med Course 4 nu."
                        });
                });

            modelBuilder.Entity("Rally.Domain.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CourseSize")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int>("visiability")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseSize = 1.0,
                            Name = "Course 1",
                            Tag = "Tag1",
                            Theme = "Theme 1",
                            level = 0,
                            visiability = 0
                        },
                        new
                        {
                            Id = 2,
                            CourseSize = 2.0,
                            Name = "Course 2",
                            Tag = "Tag2",
                            Theme = "Theme 2",
                            level = 1,
                            visiability = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseSize = 3.0,
                            Name = "Course 3",
                            Tag = "Tag3",
                            Theme = "Theme 3",
                            level = 2,
                            visiability = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseSize = 4.0,
                            Name = "Course 4",
                            Tag = "Tag4",
                            Theme = "Theme 4",
                            level = 3,
                            visiability = 1
                        },
                        new
                        {
                            Id = 5,
                            CourseSize = 5.0,
                            Name = "Course 5",
                            Tag = "Tag5",
                            Theme = "Theme 5",
                            level = 4,
                            visiability = 0
                        });
                });

            modelBuilder.Entity("Rally.Domain.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Elements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Start"
                        },
                        new
                        {
                            Id = 2,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Kegler"
                        },
                        new
                        {
                            Id = 3,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "fristelser"
                        },
                        new
                        {
                            Id = 4,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Spring"
                        },
                        new
                        {
                            Id = 5,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Feltet"
                        },
                        new
                        {
                            Id = 6,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Spanden"
                        },
                        new
                        {
                            Id = 7,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "kurven"
                        },
                        new
                        {
                            Id = 8,
                            Column = 0,
                            Position = 0,
                            Row = 0,
                            Type = "Slut"
                        });
                });

            modelBuilder.Entity("Rally.Domain.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Admin = true,
                            Email = "grethehansen8 7@mail.com",
                            FirstName = "Grethe",
                            LastName = "Hansen",
                            Password = "StrongPassword87",
                            UserName = "Grethe87"
                        },
                        new
                        {
                            Id = 2,
                            Admin = false,
                            Email = "HansenAuto@mail.com",
                            FirstName = "Hans",
                            LastName = "Hansen",
                            Password = "MarriedToGrethe87",
                            UserName = "Hans Hansen"
                        });
                });

            modelBuilder.Entity("Rally.Domain.Models.Sign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Signs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Højre øverst på banen",
                            Position = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Højre midt på banen",
                            Position = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Højre nederst på banen",
                            Position = 3
                        },
                        new
                        {
                            Id = 4,
                            Description = "Venstre øverst på banen",
                            Position = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Venstre midt på banen",
                            Position = 5
                        },
                        new
                        {
                            Id = 6,
                            Description = "Venstre nederst på banen",
                            Position = 6
                        });
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

            modelBuilder.Entity("Rally.Domain.Models.Chat", b =>
                {
                    b.HasOne("Rally.Domain.Models.Member", "member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("member");
                });
#pragma warning restore 612, 618
        }
    }
}
