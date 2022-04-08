using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementTest.Data.Migrations
{
    public partial class AddedDefaultUsersAndrolesAndemailConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71714b26-b103-4deb-ae56-3e80f1c11f49",
                column: "ConcurrencyStamp",
                value: "6426f2ba-2771-4f73-93f0-d7b85ad2efdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "717b4b26-c103-4deb-ae66-3e80f1c21f49",
                column: "ConcurrencyStamp",
                value: "d10af309-748d-4e1a-8502-3284aa673e47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715b4a26-c002-1deb-ae46-2e8021c21d49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "af6db867-402e-4a1c-8281-6cc4229c480c", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENFAo96zG2AdXSLwM5zNGi1lC1+Gxd4XW8zbRPgDX8dWL4FT4G/p0+DbNB5rn1O00w==", "5306c48f-20b5-4f5b-8eb0-d76be047f399", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "717b4a26-c003-4deb-ae56-3e8021c21d49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "669f409b-f24e-4767-8e6f-800556a41eae", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEjuU1qIm/YMxhJmGV3XQeTD125pBQ2fKgsLVTd3BS41zLH/F+RWZtyVBSM6tAtwTg==", "a8bf6784-034f-442b-b1f9-3fccb6235867", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71714b26-b103-4deb-ae56-3e80f1c11f49",
                column: "ConcurrencyStamp",
                value: "3b28c401-7c5f-47e7-ac69-4d5dca697145");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "717b4b26-c103-4deb-ae66-3e80f1c21f49",
                column: "ConcurrencyStamp",
                value: "6c851103-63d6-4af6-a532-4d8487e5fb80");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715b4a26-c002-1deb-ae46-2e8021c21d49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dc16c4a3-28cf-42a2-879e-70ad89511e3d", false, null, "AQAAAAEAACcQAAAAEKBuNtJe8oRflXgfOq8pRl4nXX53br+KO6NQ2NyNP1a6V6Ktg0xuMI9gIv6CQfmXyQ==", "aab28a6b-b2bf-4402-be80-608e05859f9a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "717b4a26-c003-4deb-ae56-3e8021c21d49",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "65a99bcf-add7-484e-9a96-d45acdf82499", false, null, "AQAAAAEAACcQAAAAEK0Sr9NmP8OQELTCPJguNEk8Rdi40xBmzdNVyu2Zf7eqo62MmgKVnHJBMpknPb3MMg==", "06422231-025c-4cb7-af99-8f175ef2cb9f", null });
        }
    }
}
