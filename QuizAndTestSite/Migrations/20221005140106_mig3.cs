using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAndTestSite.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizes_Results_ResultModelId",
                table: "Quizes");

            migrationBuilder.DropIndex(
                name: "IX_Quizes_ResultModelId",
                table: "Quizes");

            migrationBuilder.DropColumn(
                name: "ResultModelId",
                table: "Quizes");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Results",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Results");

            migrationBuilder.AddColumn<int>(
                name: "ResultModelId",
                table: "Quizes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizes_ResultModelId",
                table: "Quizes",
                column: "ResultModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizes_Results_ResultModelId",
                table: "Quizes",
                column: "ResultModelId",
                principalTable: "Results",
                principalColumn: "Id");
        }
    }
}
