using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Money_Transaction.Migrations
{
    public partial class AddsDumyDataToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { new Guid("6f984986-652d-483c-87f8-a191329ea26a"), 32000.0, "xl43y@ermtia.com", "Mohamed", "./Images/profile-pic/3.jpg", "Sadek" },
                    { new Guid("4d84c786-c637-4e92-802e-d9948ea6cb55"), 20000.0, "paulallum@mobilekoki.com", "Ali", "./Images/profile-pic/1.jpg", "Yasser" },
                    { new Guid("814a58ed-f5a0-4343-bbc7-5c0b20448c8d"), 50000.0, "nloololo@aaskin.fr", "Mohamed", "./Images/profile-pic/3.jpg", "Shaaban" },
                    { new Guid("38ec1e4f-7573-48f0-86fa-0fb4a6e251b2"), 6000.0, "junemark@filevino.com", "Amr", "./Images/profile-pic/1.jpg", "Gaber" },
                    { new Guid("7a7ba57c-2696-4acd-9759-0cdb93804cf8"), 40000.0, "slatedust@boranora.com", "Belal", "./Images/profile-pic/3.jpg", "Arfa" },
                    { new Guid("c6c274d2-1f23-43df-a919-ea22f78dd683"), 20000.0, "grigorjevo@inadtia.com", "Ahmed", "./Images/profile-pic/1.jpg", "Rahoma" },
                    { new Guid("5cf1e92d-04cb-452f-b231-cbf985277c2d"), 55000.0, "fx91@mymailcr.com", "Ziyad", "./Images/profile-pic/3.jpg", "Ahmed" },
                    { new Guid("7372e17a-1d57-433b-a977-137626181b67"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("38ec1e4f-7573-48f0-86fa-0fb4a6e251b2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4d84c786-c637-4e92-802e-d9948ea6cb55"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5cf1e92d-04cb-452f-b231-cbf985277c2d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6f984986-652d-483c-87f8-a191329ea26a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7372e17a-1d57-433b-a977-137626181b67"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7a7ba57c-2696-4acd-9759-0cdb93804cf8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("814a58ed-f5a0-4343-bbc7-5c0b20448c8d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c6c274d2-1f23-43df-a919-ea22f78dd683"));
        }
    }
}
