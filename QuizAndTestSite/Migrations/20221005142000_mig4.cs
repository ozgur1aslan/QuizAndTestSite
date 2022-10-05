using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAndTestSite.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Results");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Results",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
