using Microsoft.EntityFrameworkCore.Migrations;

namespace sCTNSolution.Data.Migrations
{
    public partial class AspNetCoreIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApproleClaims",
                table: "ApproleClaims");

            migrationBuilder.RenameTable(
                name: "ApproleClaims",
                newName: "AppRoleClaims");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleClaims",
                table: "AppRoleClaims",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleClaims",
                table: "AppRoleClaims");

            migrationBuilder.RenameTable(
                name: "AppRoleClaims",
                newName: "ApproleClaims");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApproleClaims",
                table: "ApproleClaims",
                column: "Id");
        }
    }
}
