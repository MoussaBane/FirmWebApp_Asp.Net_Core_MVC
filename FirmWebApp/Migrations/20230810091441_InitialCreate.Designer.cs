﻿// <auto-generated />
using FirmWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirmWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230810091441_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirmWebApp.Models.Layout", b =>
                {
                    b.Property<int>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Oid"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Oid");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("FirmWebApp.Models.Machine", b =>
                {
                    b.Property<int>("Oid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Oid"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Info1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LayoutOid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PositionX")
                        .HasColumnType("float");

                    b.Property<double>("PositionY")
                        .HasColumnType("float");

                    b.Property<bool>("RunningStatus")
                        .HasColumnType("bit");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Oid");

                    b.HasIndex("LayoutOid");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("FirmWebApp.Models.Machine", b =>
                {
                    b.HasOne("FirmWebApp.Models.Layout", "Layout")
                        .WithMany()
                        .HasForeignKey("LayoutOid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Layout");
                });
#pragma warning restore 612, 618
        }
    }
}
