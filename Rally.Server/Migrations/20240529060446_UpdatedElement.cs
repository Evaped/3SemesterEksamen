using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rally.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedElement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "Spanden");

            migrationBuilder.UpdateData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "kurven");

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "Column", "Position", "Row", "Type" },
                values: new object[] { 8, 0, 0, 0, "Slut" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 6,
                column: "Type",
                value: "Spanden/kurven");

            migrationBuilder.UpdateData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 7,
                column: "Type",
                value: "Slut");
        }
    }
}
