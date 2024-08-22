﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using User.DataAccess.Context;

#nullable disable

namespace User.DataAccess.Migrations
{
    [DbContext(typeof(UsersDbContext))]
    partial class UsersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("User.DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsRenting")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fd84854b-06ac-4c0d-b539-6ee31bc66670"),
                            Balance = 11584.799740120450000m,
                            Email = "Priscilla85@hotmail.com",
                            FirstName = "Gretchen",
                            IsRenting = false,
                            LastName = "Bartell",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("b7526463-635c-425b-bde2-f7ee5afc21f5"),
                            Balance = 22350.894261302700000m,
                            Email = "Roxanne_Lynch@hotmail.com",
                            FirstName = "Chester",
                            IsRenting = false,
                            LastName = "Williamson",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("b7cdae4f-ec8f-48bc-86cd-28f13d32c4e7"),
                            Balance = 5944.011214830550000m,
                            Email = "Jamal57@yahoo.com",
                            FirstName = "Alexandra",
                            IsRenting = true,
                            LastName = "Quigley",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("ad66c6cc-b719-4850-ae64-6814e96a6538"),
                            Balance = 14974.118470660700000m,
                            Email = "Neha85@gmail.com",
                            FirstName = "Roman",
                            IsRenting = true,
                            LastName = "Zboncak",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("027a7423-c35c-4b86-a258-34b4b8b79ddc"),
                            Balance = 47650.956730164150000m,
                            Email = "Flo.Spencer63@gmail.com",
                            FirstName = "Davion",
                            IsRenting = false,
                            LastName = "Maggio",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("c9c4ad86-ac62-4977-9fd0-605242bcc8d4"),
                            Balance = 30153.580322385200000m,
                            Email = "Annamae.Aufderhar@hotmail.com",
                            FirstName = "Jack",
                            IsRenting = false,
                            LastName = "Moore",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("93f75a0b-070b-498a-b3d9-b3426cba8137"),
                            Balance = 22712.507427203650000m,
                            Email = "Furman.Gerlach@yahoo.com",
                            FirstName = "Michelle",
                            IsRenting = false,
                            LastName = "Hoppe",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("a7654ee3-9283-481c-8814-175108db2b3e"),
                            Balance = 32158.45624852850000m,
                            Email = "Damaris52@yahoo.com",
                            FirstName = "Coty",
                            IsRenting = false,
                            LastName = "Herzog",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("60918948-6bd0-4322-92f0-b6aded7bdcf7"),
                            Balance = 18289.699407872200000m,
                            Email = "Clare44@yahoo.com",
                            FirstName = "Eino",
                            IsRenting = false,
                            LastName = "Glover",
                            UserId = ""
                        },
                        new
                        {
                            Id = new Guid("1900c2a9-16f7-43dd-9b7f-0703ef9c1474"),
                            Balance = 37961.059584877700000m,
                            Email = "Jude.Homenick@yahoo.com",
                            FirstName = "Arely",
                            IsRenting = false,
                            LastName = "O'Keefe",
                            UserId = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
