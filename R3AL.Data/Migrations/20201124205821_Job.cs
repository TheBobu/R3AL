using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class Job : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Quiz",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Milestones",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusProgress",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Goal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goal_JobId",
                table: "Goal",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_Job_JobId",
                table: "Goal",
                column: "JobId",
                principalTable: "Job",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_Job_JobId",
                table: "Goal");

            migrationBuilder.DropIndex(
                name: "IX_Goal_JobId",
                table: "Goal");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Quiz");

            migrationBuilder.DropColumn(
                name: "Milestones",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "StatusProgress",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Goal");
        }
    }
}
