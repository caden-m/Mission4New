using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Drama/Romance", "Gus Van Sant", false, "N/A", "N/A", "R", "Good Will Hunting", 1997 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama/Crime", "Steven Spielberg", false, "N/A", "N/A", "PG-13", "Catch Me If You Can", 2002 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Grabriele Muccino", false, "Jonah", "Feel Good Movie", "PG-13", "The Pursuit of Happyness", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
