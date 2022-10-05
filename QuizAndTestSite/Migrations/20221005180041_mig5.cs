using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAndTestSite.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorrectAnswerCount",
                table: "Results",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswerCount",
                table: "Results");
        }
    }
}
