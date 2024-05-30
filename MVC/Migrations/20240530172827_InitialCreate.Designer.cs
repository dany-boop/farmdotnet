﻿// <auto-generated />
using System;
using MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240530172827_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MVC.Models.Entity.CattleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Is_active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CattleType");
                });

            modelBuilder.Entity("MVC.Models.Entity.Farm", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("Buy_Price")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Female_Breeder")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Investor_Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Male_Breeder")
                        .HasColumnType("char(36)");

                    b.Property<int>("Sell_Price")
                        .HasColumnType("int");

                    b.Property<int>("Treament_Price")
                        .HasColumnType("int");

                    b.Property<string>("Type_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Investor_Id");

                    b.ToTable("Farm");
                });

            modelBuilder.Entity("MVC.Models.Entity.FarmExpense", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Farm_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img4")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img5")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FarmExpense");
                });

            modelBuilder.Entity("MVC.Models.Entity.FarmExpenseCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Is_active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FarmExpenseCategory");
                });

            modelBuilder.Entity("MVC.Models.Entity.FarmImg", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Category_Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Farm_Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Img1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Img3")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FarmImg");
                });

            modelBuilder.Entity("MVC.Models.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Is_active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MVC.Models.Entity.Farm", b =>
                {
                    b.HasOne("MVC.Models.Entity.CattleType", "Type")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Entity.User", "Investor")
                        .WithMany()
                        .HasForeignKey("Investor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MVC.Models.Entity.FarmExpense", b =>
                {
                    b.HasOne("MVC.Models.Entity.Farm", "Farm")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("MVC.Models.Entity.FarmImg", b =>
                {
                    b.HasOne("MVC.Models.Entity.Farm", "Farm")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Entity.FarmExpenseCategory", "Category")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Farm");
                });
#pragma warning restore 612, 618
        }
    }
}
