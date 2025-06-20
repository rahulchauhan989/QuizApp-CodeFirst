using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AttemIdAsFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Useranswers_Userquizattempts_AttempId",
                table: "Useranswers");

            migrationBuilder.RenameColumn(
                name: "AttempId",
                table: "Useranswers",
                newName: "UserquizattemptId");

            migrationBuilder.RenameIndex(
                name: "IX_Useranswers_AttempId",
                table: "Useranswers",
                newName: "IX_Useranswers_UserquizattemptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Useranswers_Userquizattempts_UserquizattemptId",
                table: "Useranswers",
                column: "UserquizattemptId",
                principalTable: "Userquizattempts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Useranswers_Userquizattempts_UserquizattemptId",
                table: "Useranswers");

            migrationBuilder.RenameColumn(
                name: "UserquizattemptId",
                table: "Useranswers",
                newName: "AttempId");

            migrationBuilder.RenameIndex(
                name: "IX_Useranswers_UserquizattemptId",
                table: "Useranswers",
                newName: "IX_Useranswers_AttempId");

            migrationBuilder.AddForeignKey(
                name: "FK_Useranswers_Userquizattempts_AttempId",
                table: "Useranswers",
                column: "AttempId",
                principalTable: "Userquizattempts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
