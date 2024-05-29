using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rally.Server.Migrations
{
    /// <inheritdoc />
    public partial class Tabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    CourseSize = table.Column<double>(type: "float", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    visiability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Signs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Arrows",
                columns: new[] { "Id", "Direction", "Length", "Position" },
                values: new object[,]
                {
                    { 1, 0, 1, 1 },
                    { 2, 1, 2, 2 },
                    { 3, 2, 3, 3 },
                    { 4, 3, 4, 4 },
                    { 5, 4, 5, 5 },
                    { 6, 5, 6, 6 },
                    { 7, 7, 7, 7 },
                    { 8, 6, 8, 8 }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "MemberId", "Message" },
                values: new object[,]
                {
                    { 1, 1, "Hej Hans, jeg har oprettet en fælles bane i Course 4" },
                    { 2, 2, "Hej Grethe, jeg har færdiggjort Course 3 og delt den. Jeg går i gang med Course 4 nu." }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseSize", "Name", "Tag", "Theme", "level", "visiability" },
                values: new object[,]
                {
                    { 1, 1.0, "Course 1", "Tag1", "Theme 1", 0, 0 },
                    { 2, 2.0, "Course 2", "Tag2", "Theme 2", 1, 1 },
                    { 3, 3.0, "Course 3", "Tag3", "Theme 3", 2, 1 },
                    { 4, 4.0, "Course 4", "Tag4", "Theme 4", 3, 1 },
                    { 5, 5.0, "Course 5", "Tag5", "Theme 5", 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "Column", "Position", "Row", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, "Start" },
                    { 2, 0, 0, 0, "Kegler" },
                    { 3, 0, 0, 0, "fristelser" },
                    { 4, 0, 0, 0, "Spring" },
                    { 5, 0, 0, 0, "Feltet" },
                    { 6, 0, 0, 0, "Spanden/kurven" },
                    { 7, 0, 0, 0, "Slut" }
                });

            migrationBuilder.InsertData(
                table: "Signs",
                columns: new[] { "Id", "Description", "Position" },
                values: new object[,]
                {
                    { 1, "Højre øverst på banen", 1 },
                    { 2, "Højre midt på banen", 2 },
                    { 3, "Højre nederst på banen", 3 },
                    { 4, "Venstre øverst på banen", 4 },
                    { 5, "Venstre midt på banen", 5 },
                    { 6, "Venstre nederst på banen", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_MemberId",
                table: "Chats",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arrows");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Signs");
        }
    }
}
