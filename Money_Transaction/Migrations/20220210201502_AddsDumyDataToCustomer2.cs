using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Money_Transaction.Migrations
{
    public partial class AddsDumyDataToCustomer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { new Guid("1aaf1670-2c50-4a72-81db-15e624a19804"), 32000.0, "xl43y@ermtia.com", "Mohamed", "./Images/profile-pic/3.jpg", "Sadek" },
                    { new Guid("eff5fb64-2a66-42b7-a15c-69a71599ff2a"), 20000.0, "paulallum@mobilekoki.com", "Ali", "./Images/profile-pic/1.jpg", "Yasser" },
                    { new Guid("ec0f52d6-8102-4a3c-bb88-cfa368fa885a"), 50000.0, "nloololo@aaskin.fr", "Mohamed", "./Images/profile-pic/3.jpg", "Shaaban" },
                    { new Guid("3c9598fc-3c5e-48b1-8d29-b6eb061cf2a7"), 6000.0, "junemark@filevino.com", "Amr", "./Images/profile-pic/1.jpg", "Gaber" },
                    { new Guid("acb1a0e0-b76b-4624-ac39-41a272daec5f"), 40000.0, "slatedust@boranora.com", "Belal", "./Images/profile-pic/3.jpg", "Arfa" },
                    { new Guid("598d0ad7-b106-41e9-a791-b44a49aaa523"), 20000.0, "grigorjevo@inadtia.com", "Ahmed", "./Images/profile-pic/1.jpg", "Rahoma" },
                    { new Guid("259e3c25-62e0-4872-9edd-84db6d3c4caa"), 55000.0, "fx91@mymailcr.com", "Ziyad", "./Images/profile-pic/3.jpg", "Ahmed" },
                    { new Guid("dceded7e-982a-443b-88a3-9b7592063790"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("b0bd5a88-f9cc-4e60-854e-7fa8ccf2bff9"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("3ce79a35-ef3d-4549-afe1-3ca7df57f91f"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("81f1b812-2b8f-4955-abe0-70a6320cf09a"), 89000.0, "ivlievai85@fartovoe1.fun", "Amr", "./Images/profile-pic/3.jpg", "Ahmed" },
                    { new Guid("6f749b35-e313-4c50-83f3-c9deeb96f780"), 122000.0, "ivlievai85@fartovoe1.fun", "Ahmed", "./Images/profile-pic/1.jpg", "Salem" },
                    { new Guid("37e54ca5-c1f6-4806-9bfa-0b23ea97cddf"), 93000.0, "ivlievai85@fartovoe1.fun", "Eslam", "./Images/profile-pic/3.jpg", "Elsayed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1aaf1670-2c50-4a72-81db-15e624a19804"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("259e3c25-62e0-4872-9edd-84db6d3c4caa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("37e54ca5-c1f6-4806-9bfa-0b23ea97cddf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3c9598fc-3c5e-48b1-8d29-b6eb061cf2a7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3ce79a35-ef3d-4549-afe1-3ca7df57f91f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("598d0ad7-b106-41e9-a791-b44a49aaa523"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6f749b35-e313-4c50-83f3-c9deeb96f780"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("81f1b812-2b8f-4955-abe0-70a6320cf09a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("acb1a0e0-b76b-4624-ac39-41a272daec5f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b0bd5a88-f9cc-4e60-854e-7fa8ccf2bff9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("dceded7e-982a-443b-88a3-9b7592063790"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ec0f52d6-8102-4a3c-bb88-cfa368fa885a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("eff5fb64-2a66-42b7-a15c-69a71599ff2a"));

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
    }
}
