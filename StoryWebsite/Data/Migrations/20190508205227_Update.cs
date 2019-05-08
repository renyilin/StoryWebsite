using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoryWebsite.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorySlide_stories_storyID",
                table: "StorySlide");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StorySlide",
                table: "StorySlide");

            migrationBuilder.RenameTable(
                name: "StorySlide",
                newName: "storySlides");

            migrationBuilder.RenameIndex(
                name: "IX_StorySlide_storyID",
                table: "storySlides",
                newName: "IX_storySlides_storyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_storySlides",
                table: "storySlides",
                column: "slideID");

            migrationBuilder.AddForeignKey(
                name: "FK_storySlides_stories_storyID",
                table: "storySlides",
                column: "storyID",
                principalTable: "stories",
                principalColumn: "storyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_storySlides_stories_storyID",
                table: "storySlides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_storySlides",
                table: "storySlides");

            migrationBuilder.RenameTable(
                name: "storySlides",
                newName: "StorySlide");

            migrationBuilder.RenameIndex(
                name: "IX_storySlides_storyID",
                table: "StorySlide",
                newName: "IX_StorySlide_storyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StorySlide",
                table: "StorySlide",
                column: "slideID");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    avatarURL = table.Column<string>(nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    password = table.Column<string>(maxLength: 200, nullable: false),
                    userName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StorySlide_stories_storyID",
                table: "StorySlide",
                column: "storyID",
                principalTable: "stories",
                principalColumn: "storyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
