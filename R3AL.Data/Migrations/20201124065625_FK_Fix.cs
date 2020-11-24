using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class FK_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Question",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quiz_GoalId",
                table: "Quiz",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuizId",
                table: "Question",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_GoalId",
                table: "Project",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_UserId",
                table: "Goal",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_User_UserId",
                table: "Goal",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Goal_GoalId",
                table: "Project",
                column: "GoalId",
                principalTable: "Goal",
                principalColumn: "GoalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Quiz_QuizId",
                table: "Question",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "QuizId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quiz_Goal_GoalId",
                table: "Quiz",
                column: "GoalId",
                principalTable: "Goal",
                principalColumn: "GoalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_User_UserId",
                table: "Goal");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Goal_GoalId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Quiz_QuizId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Quiz_Goal_GoalId",
                table: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_Quiz_GoalId",
                table: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_Question_QuizId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Project_GoalId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Goal_UserId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Project");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Question",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);
        }
    }
}
