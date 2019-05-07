using Microsoft.EntityFrameworkCore.Migrations;

namespace StoryWebsite.Data.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_users_authoruserID",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_stories_users_authoruserID",
                table: "stories");

            migrationBuilder.DropIndex(
                name: "IX_stories_authoruserID",
                table: "stories");

            migrationBuilder.DropIndex(
                name: "IX_comments_authoruserID",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "authoruserID",
                table: "stories");

            migrationBuilder.DropColumn(
                name: "authoruserID",
                table: "comments");

            migrationBuilder.AddColumn<string>(
                name: "authorId",
                table: "stories",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "authorId",
                table: "comments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_stories_authorId",
                table: "stories",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_authorId",
                table: "comments",
                column: "authorId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_AspNetUsers_authorId",
                table: "comments",
                column: "authorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stories_AspNetUsers_authorId",
                table: "stories",
                column: "authorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_AspNetUsers_authorId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_stories_AspNetUsers_authorId",
                table: "stories");

            migrationBuilder.DropIndex(
                name: "IX_stories_authorId",
                table: "stories");

            migrationBuilder.DropIndex(
                name: "IX_comments_authorId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "authorId",
                table: "stories");

            migrationBuilder.DropColumn(
                name: "authorId",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "authoruserID",
                table: "stories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "authoruserID",
                table: "comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_stories_authoruserID",
                table: "stories",
                column: "authoruserID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_authoruserID",
                table: "comments",
                column: "authoruserID");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_users_authoruserID",
                table: "comments",
                column: "authoruserID",
                principalTable: "users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stories_users_authoruserID",
                table: "stories",
                column: "authoruserID",
                principalTable: "users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
