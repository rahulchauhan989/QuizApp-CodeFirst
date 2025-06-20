using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppWebApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAttempId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttempId",
                table: "Userquizattempts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttempId",
                table: "Userquizattempts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
