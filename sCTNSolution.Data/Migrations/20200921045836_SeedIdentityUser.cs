using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sCTNSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c8af3dff-8f86-4423-8d8e-b058ad31bc9a"), "49cd304d-481a-435f-899f-a4d6c2cbb40d", "Adminstrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("8082ad02-677a-46ae-954a-a223e8b8cf10"), new Guid("c8af3dff-8f86-4423-8d8e-b058ad31bc9a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8082ad02-677a-46ae-954a-a223e8b8cf10"), 0, "a1548fca-512b-4314-9a99-fe37c9e7ae49", new DateTime(1988, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "s_h22002@yahoo.com", true, "Cao", "Huong", false, null, "s_h22002@yahoo.com", "admin", "AQAAAAEAACcQAAAAEKWJnnYg3l/S/eMAkXSlIXjt8LXK3965PGb2Zseaglf1dtgt3B+6k9mEUkQHBntitQ==", null, false, "", false, "ctn.admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c8af3dff-8f86-4423-8d8e-b058ad31bc9a"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("8082ad02-677a-46ae-954a-a223e8b8cf10"), new Guid("c8af3dff-8f86-4423-8d8e-b058ad31bc9a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8082ad02-677a-46ae-954a-a223e8b8cf10"));
        }
    }
}
