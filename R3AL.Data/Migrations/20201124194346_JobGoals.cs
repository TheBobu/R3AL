using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class JobGoals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Milestones",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
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
                name: "Milestones",
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
