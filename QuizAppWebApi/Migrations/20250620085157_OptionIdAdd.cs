using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppWebApi.Migrations
{
    /// <inheritdoc />
    public partial class OptionIdAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OptionId",
                table: "Useranswers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Useranswers_OptionId",
                table: "Useranswers",
                column: "OptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Useranswers_Options_OptionId",
                table: "Useranswers",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Useranswers_Options_OptionId",
                table: "Useranswers");

            migrationBuilder.DropIndex(
                name: "IX_Useranswers_OptionId",
                table: "Useranswers");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "Useranswers");
        }
    }
}
