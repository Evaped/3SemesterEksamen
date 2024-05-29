using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rally.Server.Migrations
{
    /// <inheritdoc />
    public partial class Member1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Admin", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, true, "grethehansen8 7@mail.com", "Grethe", "Hansen", "StrongPassword87", "Grethe87" },
                    { 2, false, "HansenAuto@mail.com", "Hans", "Hansen", "MarriedToGrethe87", "Hans Hansen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
