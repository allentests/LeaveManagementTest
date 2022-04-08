using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementTest.Data.Migrations
{
    public partial class AddedDefaultUsersAndroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71714b26-b103-4deb-ae56-3e80f1c11f49", "3b28c401-7c5f-47e7-ac69-4d5dca697145", "User", "USER" },
                    { "717b4b26-c103-4deb-ae66-3e80f1c21f49", "6c851103-63d6-4af6-a532-4d8487e5fb80", "Administrator", "ADMINSTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "715b4a26-c002-1deb-ae46-2e8021c21d49", 0, "dc16c4a3-28cf-42a2-879e-70ad89511e3d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKBuNtJe8oRflXgfOq8pRl4nXX53br+KO6NQ2NyNP1a6V6Ktg0xuMI9gIv6CQfmXyQ==", null, false, "aab28a6b-b2bf-4402-be80-608e05859f9a", null, false, null },
                    { "717b4a26-c003-4deb-ae56-3e8021c21d49", 0, "65a99bcf-add7-484e-9a96-d45acdf82499", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEK0Sr9NmP8OQELTCPJguNEk8Rdi40xBmzdNVyu2Zf7eqo62MmgKVnHJBMpknPb3MMg==", null, false, "06422231-025c-4cb7-af99-8f175ef2cb9f", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "71714b26-b103-4deb-ae56-3e80f1c11f49", "715b4a26-c002-1deb-ae46-2e8021c21d49" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "717b4b26-c103-4deb-ae66-3e80f1c21f49", "717b4a26-c003-4deb-ae56-3e8021c21d49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71714b26-b103-4deb-ae56-3e80f1c11f49", "715b4a26-c002-1deb-ae46-2e8021c21d49" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "717b4b26-c103-4deb-ae66-3e80f1c21f49", "717b4a26-c003-4deb-ae56-3e8021c21d49" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71714b26-b103-4deb-ae56-3e80f1c11f49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "717b4b26-c103-4deb-ae66-3e80f1c21f49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "715b4a26-c002-1deb-ae46-2e8021c21d49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "717b4a26-c003-4deb-ae56-3e8021c21d49");
        }
    }
}
