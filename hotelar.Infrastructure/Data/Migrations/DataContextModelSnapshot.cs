﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hotelar.Infrastructure.DataBase;

#nullable disable

namespace hotelar.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("hotelar.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHosted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Tb_Customer");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.DirectSell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeOut")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.HasIndex("RoomServiceId");

                    b.ToTable("Tb_DirectSell");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocIdNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocIdtype")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Tb_Person");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.PersonAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("NeighborNamr")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SquareName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tb_PersonAddress");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.PersonContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FaxNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModileNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tb_PersonContact");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WishDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.HasIndex("RoomServiceId");

                    b.ToTable("Tb_Reservation");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomType")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tb_Room");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.RoomService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ServicePrice")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tb_RoomService");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Customer", b =>
                {
                    b.HasOne("hotelar.Domain.Entities.Person", "Person")
                        .WithMany("Customers")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.DirectSell", b =>
                {
                    b.HasOne("hotelar.Domain.Entities.Customer", "Customer")
                        .WithMany("Sells")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelar.Domain.Entities.Room", "Room")
                        .WithMany("DirectSells")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelar.Domain.Entities.RoomService", "RoomService")
                        .WithMany("DirectSells")
                        .HasForeignKey("RoomServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Room");

                    b.Navigation("RoomService");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Person", b =>
                {
                    b.HasOne("hotelar.Domain.Entities.PersonAddress", "Address")
                        .WithMany("People")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelar.Domain.Entities.PersonContact", "PersonContact")
                        .WithOne("Person")
                        .HasForeignKey("hotelar.Domain.Entities.Person", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("PersonContact");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("hotelar.Domain.Entities.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("hotelar.Domain.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotelar.Domain.Entities.RoomService", "RoomService")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Room");

                    b.Navigation("RoomService");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Sells");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Person", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.PersonAddress", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.PersonContact", b =>
                {
                    b.Navigation("Person");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.Room", b =>
                {
                    b.Navigation("DirectSells");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("hotelar.Domain.Entities.RoomService", b =>
                {
                    b.Navigation("DirectSells");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
