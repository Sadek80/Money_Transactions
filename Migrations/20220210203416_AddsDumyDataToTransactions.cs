using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Money_Transaction.Migrations
{
    public partial class AddsDumyDataToTransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("13297bb4-6323-4c7f-9fa1-e2b7f865f980"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("264b977c-9447-42cc-b2f3-6f47a9caa77c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("62bbe057-a16b-414d-9284-8b243716a56e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6453c70e-f401-4c76-bd67-a282b06590bd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("78796545-fb65-4602-88a2-fdf75d7f8a25"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b9b44914-fd90-43fc-a023-07aa95d1ffc2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c589c0ab-af5a-498d-bc16-9f8fdabd6269"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d0bb08b0-3d94-4cce-bfc5-c121718e83ad"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d4553966-54fe-497a-a260-d7b82e4fdb09"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d748a8a8-513d-470d-b3cf-eb853e07f0c8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d8240883-36b9-400d-96ff-50907a272bf9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e2f0d9b0-fbb3-4a69-a3f9-b19306033627"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fcf97586-2241-4866-a350-13c835c55adc"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("10441073-d225-4b1f-ac0a-e9b58723fc09"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("7dd79706-3565-4fac-a369-d5366ba1f6e1"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("93f3913a-81fd-496a-af0a-826258dafb79"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("aee5fdd8-1d51-4d4b-8a08-594ff5ba60a5"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("ed38e54f-aa2d-4a0c-9888-0dc6c1c26684"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { new Guid("feac5339-e66b-4e57-aa0e-a9d75e951d8a"), 32000.0, "xl43y@ermtia.com", "Mohamed", "./Images/profile-pic/3.jpg", "Sadek" },
                    { new Guid("b3787434-3928-462a-964d-70aba917b36d"), 93000.0, "ivlievai85@fartovoe1.fun", "Eslam", "./Images/profile-pic/3.jpg", "Elsayed" },
                    { new Guid("38cf974e-f72c-49dc-b9cc-6740926320ef"), 122000.0, "ivlievai85@fartovoe1.fun", "Ahmed", "./Images/profile-pic/1.jpg", "Salem" },
                    { new Guid("36bb7085-aaf7-44ec-94c6-728d1dc7f264"), 89000.0, "ivlievai85@fartovoe1.fun", "Amr", "./Images/profile-pic/3.jpg", "Ahmed" },
                    { new Guid("29f53eca-5541-4f7e-b204-e7ad29e8d6ab"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("41e5a039-dbe0-451b-8997-95afac228cd2"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("dd01823d-e754-4d3f-b2fd-1181e34cf0e9"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("d483cb4c-6283-4e53-9a1c-4802398565eb"), 20000.0, "grigorjevo@inadtia.com", "Ahmed", "./Images/profile-pic/1.jpg", "Rahoma" },
                    { new Guid("19f3cd59-f490-425f-b9f4-0d2d059e5083"), 40000.0, "slatedust@boranora.com", "Belal", "./Images/profile-pic/3.jpg", "Arfa" },
                    { new Guid("e9e8b89e-b075-4131-9eed-74d887b3203e"), 6000.0, "junemark@filevino.com", "Amr", "./Images/profile-pic/1.jpg", "Gaber" },
                    { new Guid("8e28f8ab-f5ab-48dc-b75e-f5eff09d494b"), 50000.0, "nloololo@aaskin.fr", "Mohamed", "./Images/profile-pic/3.jpg", "Shaaban" },
                    { new Guid("57116cae-d9d0-4043-b97b-3dfafeaa1700"), 20000.0, "paulallum@mobilekoki.com", "Ali", "./Images/profile-pic/1.jpg", "Yasser" },
                    { new Guid("09eda771-f843-4c5e-b9e2-76b7ef22257a"), 55000.0, "fx91@mymailcr.com", "Ziyad", "./Images/profile-pic/3.jpg", "Ahmed" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "Date", "RecieverId", "SenderId", "Type" },
                values: new object[,]
                {
                    { new Guid("f3298e8e-74a5-45c8-ba42-ceaf46a808ae"), 400.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("259e3c25-62e0-4872-9edd-84db6d3c4caa"), new Guid("b0bd5a88-f9cc-4e60-854e-7fa8ccf2bff9"), (byte)2 },
                    { new Guid("57ebbf66-72ce-495d-bed2-816cc184bfe4"), 32000.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("37e54ca5-c1f6-4806-9bfa-0b23ea97cddf"), new Guid("1aaf1670-2c50-4a72-81db-15e624a19804"), (byte)1 },
                    { new Guid("4e5e6bb5-31a3-4d25-a5ff-4d611c6c3eae"), 2000.0, new DateTimeOffset(new DateTime(2021, 10, 10, 15, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("acb1a0e0-b76b-4624-ac39-41a272daec5f"), new Guid("3ce79a35-ef3d-4549-afe1-3ca7df57f91f"), (byte)2 },
                    { new Guid("139d8501-e6e2-465b-afa5-c118d5cb8098"), 3000.0, new DateTimeOffset(new DateTime(2022, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("81f1b812-2b8f-4955-abe0-70a6320cf09a"), new Guid("eff5fb64-2a66-42b7-a15c-69a71599ff2a"), (byte)1 },
                    { new Guid("2ab12956-cad8-4ada-b266-3fc6ea477d5d"), 3000.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("598d0ad7-b106-41e9-a791-b44a49aaa523"), new Guid("dceded7e-982a-443b-88a3-9b7592063790"), (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("09eda771-f843-4c5e-b9e2-76b7ef22257a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("19f3cd59-f490-425f-b9f4-0d2d059e5083"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("29f53eca-5541-4f7e-b204-e7ad29e8d6ab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("36bb7085-aaf7-44ec-94c6-728d1dc7f264"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("38cf974e-f72c-49dc-b9cc-6740926320ef"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("41e5a039-dbe0-451b-8997-95afac228cd2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("57116cae-d9d0-4043-b97b-3dfafeaa1700"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8e28f8ab-f5ab-48dc-b75e-f5eff09d494b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b3787434-3928-462a-964d-70aba917b36d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d483cb4c-6283-4e53-9a1c-4802398565eb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("dd01823d-e754-4d3f-b2fd-1181e34cf0e9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e9e8b89e-b075-4131-9eed-74d887b3203e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("feac5339-e66b-4e57-aa0e-a9d75e951d8a"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("139d8501-e6e2-465b-afa5-c118d5cb8098"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("2ab12956-cad8-4ada-b266-3fc6ea477d5d"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("4e5e6bb5-31a3-4d25-a5ff-4d611c6c3eae"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("57ebbf66-72ce-495d-bed2-816cc184bfe4"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("f3298e8e-74a5-45c8-ba42-ceaf46a808ae"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { new Guid("c589c0ab-af5a-498d-bc16-9f8fdabd6269"), 32000.0, "xl43y@ermtia.com", "Mohamed", "./Images/profile-pic/3.jpg", "Sadek" },
                    { new Guid("d8240883-36b9-400d-96ff-50907a272bf9"), 93000.0, "ivlievai85@fartovoe1.fun", "Eslam", "./Images/profile-pic/3.jpg", "Elsayed" },
                    { new Guid("264b977c-9447-42cc-b2f3-6f47a9caa77c"), 122000.0, "ivlievai85@fartovoe1.fun", "Ahmed", "./Images/profile-pic/1.jpg", "Salem" },
                    { new Guid("62bbe057-a16b-414d-9284-8b243716a56e"), 89000.0, "ivlievai85@fartovoe1.fun", "Amr", "./Images/profile-pic/3.jpg", "Ahmed" },
                    { new Guid("fcf97586-2241-4866-a350-13c835c55adc"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("13297bb4-6323-4c7f-9fa1-e2b7f865f980"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("d0bb08b0-3d94-4cce-bfc5-c121718e83ad"), 33000.0, "ivlievai85@fartovoe1.fun", "Mohamed", "./Images/profile-pic/1.jpg", "Tolba" },
                    { new Guid("d748a8a8-513d-470d-b3cf-eb853e07f0c8"), 20000.0, "grigorjevo@inadtia.com", "Ahmed", "./Images/profile-pic/1.jpg", "Rahoma" },
                    { new Guid("b9b44914-fd90-43fc-a023-07aa95d1ffc2"), 40000.0, "slatedust@boranora.com", "Belal", "./Images/profile-pic/3.jpg", "Arfa" },
                    { new Guid("e2f0d9b0-fbb3-4a69-a3f9-b19306033627"), 6000.0, "junemark@filevino.com", "Amr", "./Images/profile-pic/1.jpg", "Gaber" },
                    { new Guid("78796545-fb65-4602-88a2-fdf75d7f8a25"), 50000.0, "nloololo@aaskin.fr", "Mohamed", "./Images/profile-pic/3.jpg", "Shaaban" },
                    { new Guid("6453c70e-f401-4c76-bd67-a282b06590bd"), 20000.0, "paulallum@mobilekoki.com", "Ali", "./Images/profile-pic/1.jpg", "Yasser" },
                    { new Guid("d4553966-54fe-497a-a260-d7b82e4fdb09"), 55000.0, "fx91@mymailcr.com", "Ziyad", "./Images/profile-pic/3.jpg", "Ahmed" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "Date", "RecieverId", "SenderId", "Type" },
                values: new object[,]
                {
                    { new Guid("10441073-d225-4b1f-ac0a-e9b58723fc09"), 400.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("7372e17a-1d57-433b-a977-137626181b67"), new Guid("5cf1e92d-04cb-452f-b231-cbf985277c2d"), (byte)2 },
                    { new Guid("aee5fdd8-1d51-4d4b-8a08-594ff5ba60a5"), 32000.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4d84c786-c637-4e92-802e-d9948ea6cb55"), new Guid("6f984986-652d-483c-87f8-a191329ea26a"), (byte)1 },
                    { new Guid("ed38e54f-aa2d-4a0c-9888-0dc6c1c26684"), 2000.0, new DateTimeOffset(new DateTime(2021, 10, 10, 15, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("38ec1e4f-7573-48f0-86fa-0fb4a6e251b2"), new Guid("814a58ed-f5a0-4343-bbc7-5c0b20448c8d"), (byte)2 },
                    { new Guid("7dd79706-3565-4fac-a369-d5366ba1f6e1"), 3000.0, new DateTimeOffset(new DateTime(2022, 1, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("c6c274d2-1f23-43df-a919-ea22f78dd683"), new Guid("7a7ba57c-2696-4acd-9759-0cdb93804cf8"), (byte)1 },
                    { new Guid("93f3913a-81fd-496a-af0a-826258dafb79"), 3000.0, new DateTimeOffset(new DateTime(2021, 8, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new Guid("4d84c786-c637-4e92-802e-d9948ea6cb55"), new Guid("38ec1e4f-7573-48f0-86fa-0fb4a6e251b2"), (byte)1 }
                });
        }
    }
}
