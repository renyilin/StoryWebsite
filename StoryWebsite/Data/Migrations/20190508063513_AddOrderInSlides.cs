using Microsoft.EntityFrameworkCore.Migrations;

namespace StoryWebsite.Data.Migrations
{
    public partial class AddOrderInSlides : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "StorySlide",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "StorySlide");
        }
    }
}
