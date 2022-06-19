﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220615095252_new1")]
    partial class new1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("int");

                    b.Property<int>("ClassRoomType")
                        .HasColumnType("int");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<string>("LabType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("API.Models.BookingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("User")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("API.Models.ClassRoom_Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("ResourceId");

                    b.ToTable("ClassRooms_Resources");
                });

            modelBuilder.Entity("API.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("API.Models.BookingDetails", b =>
                {
                    b.HasOne("API.ClassRoom", "ClassRoom")
                        .WithMany("Bookings")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");
                });

            modelBuilder.Entity("API.Models.ClassRoom_Resource", b =>
                {
                    b.HasOne("API.ClassRoom", "ClassRoom")
                        .WithMany("ClassRoom_Resources")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Resource", "Resource")
                        .WithMany("ClassRoom_Resources")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRoom");

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("API.ClassRoom", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("ClassRoom_Resources");
                });

            modelBuilder.Entity("API.Models.Resource", b =>
                {
                    b.Navigation("ClassRoom_Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
