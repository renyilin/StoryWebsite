using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoryWebsite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userName = table.Column<string>(maxLength: 30, nullable: false),
                    password = table.Column<string>(maxLength: 200, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false),
                    avatarURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "stories",
                columns: table => new
                {
                    storyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 100, nullable: false),
                    content = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    categoryID = table.Column<int>(nullable: false),
                    createTime = table.Column<DateTime>(nullable: false),
                    updateTime = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    authoruserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stories", x => x.storyID);
                    table.ForeignKey(
                        name: "FK_stories_users_authoruserID",
                        column: x => x.authoruserID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stories_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(maxLength: 500, nullable: false),
                    postTime = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    authoruserID = table.Column<int>(nullable: false),
                    storyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentID);
                    table.ForeignKey(
                        name: "FK_comments_users_authoruserID",
                        column: x => x.authoruserID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_stories_storyID",
                        column: x => x.storyID,
                        principalTable: "stories",
                        principalColumn: "storyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_authoruserID",
                table: "comments",
                column: "authoruserID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_storyID",
                table: "comments",
                column: "storyID");

            migrationBuilder.CreateIndex(
                name: "IX_stories_authoruserID",
                table: "stories",
                column: "authoruserID");

            migrationBuilder.CreateIndex(
                name: "IX_stories_categoryID",
                table: "stories",
                column: "categoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "stories");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
