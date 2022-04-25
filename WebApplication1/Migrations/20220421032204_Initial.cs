using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cateogries",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cateogries", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicID);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: false),
                    TopicID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQID);
                    table.ForeignKey(
                        name: "FK_FAQs_Cateogries_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Cateogries",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicID",
                        column: x => x.TopicID,
                        principalTable: "Topics",
                        principalColumn: "TopicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cateogries",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "his", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicID", "Name" },
                values: new object[,]
                {
                    { "js", "JavaScript" },
                    { "cpp", "C++" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQID", "Answer", "CategoryID", "Question", "TopicID" },
                values: new object[,]
                {
                    { 1, "sample", "gen", "sample", "js" },
                    { 4, "sample", "his", "sample", "js" },
                    { 2, "sample", "gen", "sample", "cpp" },
                    { 3, "sample", "his", "sample", "cpp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryID",
                table: "FAQs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicID",
                table: "FAQs",
                column: "TopicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Cateogries");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
