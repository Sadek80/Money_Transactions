﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Money_Transaction.Model;

namespace Money_Transaction.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20220210203416_AddsDumyDataToTransactions")]
    partial class AddsDumyDataToTransactions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Money_Transaction.Model.Core.Domain.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("feac5339-e66b-4e57-aa0e-a9d75e951d8a"),
                            Balance = 32000.0,
                            Email = "xl43y@ermtia.com",
                            FirstName = "Mohamed",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Sadek"
                        },
                        new
                        {
                            Id = new Guid("57116cae-d9d0-4043-b97b-3dfafeaa1700"),
                            Balance = 20000.0,
                            Email = "paulallum@mobilekoki.com",
                            FirstName = "Ali",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Yasser"
                        },
                        new
                        {
                            Id = new Guid("8e28f8ab-f5ab-48dc-b75e-f5eff09d494b"),
                            Balance = 50000.0,
                            Email = "nloololo@aaskin.fr",
                            FirstName = "Mohamed",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Shaaban"
                        },
                        new
                        {
                            Id = new Guid("e9e8b89e-b075-4131-9eed-74d887b3203e"),
                            Balance = 6000.0,
                            Email = "junemark@filevino.com",
                            FirstName = "Amr",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Gaber"
                        },
                        new
                        {
                            Id = new Guid("19f3cd59-f490-425f-b9f4-0d2d059e5083"),
                            Balance = 40000.0,
                            Email = "slatedust@boranora.com",
                            FirstName = "Belal",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Arfa"
                        },
                        new
                        {
                            Id = new Guid("d483cb4c-6283-4e53-9a1c-4802398565eb"),
                            Balance = 20000.0,
                            Email = "grigorjevo@inadtia.com",
                            FirstName = "Ahmed",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Rahoma"
                        },
                        new
                        {
                            Id = new Guid("09eda771-f843-4c5e-b9e2-76b7ef22257a"),
                            Balance = 55000.0,
                            Email = "fx91@mymailcr.com",
                            FirstName = "Ziyad",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Ahmed"
                        },
                        new
                        {
                            Id = new Guid("41e5a039-dbe0-451b-8997-95afac228cd2"),
                            Balance = 33000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Mohamed",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Tolba"
                        },
                        new
                        {
                            Id = new Guid("dd01823d-e754-4d3f-b2fd-1181e34cf0e9"),
                            Balance = 33000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Mohamed",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Tolba"
                        },
                        new
                        {
                            Id = new Guid("29f53eca-5541-4f7e-b204-e7ad29e8d6ab"),
                            Balance = 33000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Mohamed",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Tolba"
                        },
                        new
                        {
                            Id = new Guid("36bb7085-aaf7-44ec-94c6-728d1dc7f264"),
                            Balance = 89000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Amr",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Ahmed"
                        },
                        new
                        {
                            Id = new Guid("38cf974e-f72c-49dc-b9cc-6740926320ef"),
                            Balance = 122000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Ahmed",
                            ImageUrl = "./Images/profile-pic/1.jpg",
                            LastName = "Salem"
                        },
                        new
                        {
                            Id = new Guid("b3787434-3928-462a-964d-70aba917b36d"),
                            Balance = 93000.0,
                            Email = "ivlievai85@fartovoe1.fun",
                            FirstName = "Eslam",
                            ImageUrl = "./Images/profile-pic/3.jpg",
                            LastName = "Elsayed"
                        });
                });

            modelBuilder.Entity("Money_Transaction.Model.Core.Domain.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("RecieverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("RecieverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57ebbf66-72ce-495d-bed2-816cc184bfe4"),
                            Amount = 32000.0,
                            Date = new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            RecieverId = new Guid("37e54ca5-c1f6-4806-9bfa-0b23ea97cddf"),
                            SenderId = new Guid("1aaf1670-2c50-4a72-81db-15e624a19804"),
                            Type = (byte)1
                        },
                        new
                        {
                            Id = new Guid("4e5e6bb5-31a3-4d25-a5ff-4d611c6c3eae"),
                            Amount = 2000.0,
                            Date = new DateTimeOffset(new DateTime(2021, 10, 10, 15, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            RecieverId = new Guid("acb1a0e0-b76b-4624-ac39-41a272daec5f"),
                            SenderId = new Guid("3ce79a35-ef3d-4549-afe1-3ca7df57f91f"),
                            Type = (byte)2
                        },
                        new
                        {
                            Id = new Guid("139d8501-e6e2-465b-afa5-c118d5cb8098"),
                            Amount = 3000.0,
                            Date = new DateTimeOffset(new DateTime(2022, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            RecieverId = new Guid("81f1b812-2b8f-4955-abe0-70a6320cf09a"),
                            SenderId = new Guid("eff5fb64-2a66-42b7-a15c-69a71599ff2a"),
                            Type = (byte)1
                        },
                        new
                        {
                            Id = new Guid("f3298e8e-74a5-45c8-ba42-ceaf46a808ae"),
                            Amount = 400.0,
                            Date = new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            RecieverId = new Guid("259e3c25-62e0-4872-9edd-84db6d3c4caa"),
                            SenderId = new Guid("b0bd5a88-f9cc-4e60-854e-7fa8ccf2bff9"),
                            Type = (byte)2
                        },
                        new
                        {
                            Id = new Guid("2ab12956-cad8-4ada-b266-3fc6ea477d5d"),
                            Amount = 3000.0,
                            Date = new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            RecieverId = new Guid("598d0ad7-b106-41e9-a791-b44a49aaa523"),
                            SenderId = new Guid("dceded7e-982a-443b-88a3-9b7592063790"),
                            Type = (byte)1
                        });
                });

            modelBuilder.Entity("Money_Transaction.Model.Core.Domain.Transaction", b =>
                {
                    b.HasOne("Money_Transaction.Model.Core.Domain.Customer", "Reciever")
                        .WithMany("RecievedTransactions")
                        .HasForeignKey("RecieverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Money_Transaction.Model.Core.Domain.Customer", "Sender")
                        .WithMany("SentTransactions")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reciever");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Money_Transaction.Model.Core.Domain.Customer", b =>
                {
                    b.Navigation("RecievedTransactions");

                    b.Navigation("SentTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
