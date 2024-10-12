using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WDevOrg.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00164e93-b93d-444d-b942-38498b006168", null, "User", "USER" },
                    { "af4c9970-044a-4659-b3e8-4e96d5fa73a1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3aabfbac-d2ad-490d-86e4-60f93f593830", 0, "b202ebbf-7c68-4e1d-ab68-139bfee82ae5", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAENtgOzGW5L4DSYLQePE/nDJZG2m7UYyGjFObthBvQJcd/M4YyZdDdaPcAkYkb+Mssg==", null, false, "5f6b52e8-d02c-4b26-8d76-0b8a70793822", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "af4c9970-044a-4659-b3e8-4e96d5fa73a1", "3aabfbac-d2ad-490d-86e4-60f93f593830" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00164e93-b93d-444d-b942-38498b006168");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "af4c9970-044a-4659-b3e8-4e96d5fa73a1", "3aabfbac-d2ad-490d-86e4-60f93f593830" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af4c9970-044a-4659-b3e8-4e96d5fa73a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aabfbac-d2ad-490d-86e4-60f93f593830");
        }
    }
}
