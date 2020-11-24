using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class ProjectGoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Goal_GoalId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_GoalId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "Project");

            migrationBuilder.CreateTable(
                name: "ProjectGoal",
                columns: table => new
                {
                    ProjectGoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    GoalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectGoal", x => x.ProjectGoalId);
                    table.ForeignKey(
                        name: "FK_ProjectGoal_Goal_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goal",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectGoal_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGoal_GoalId",
                table: "ProjectGoal",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectGoal_ProjectId",
                table: "ProjectGoal",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectGoal");

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Project_GoalId",
                table: "Project",
                column: "GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Goal_GoalId",
                table: "Project",
                column: "GoalId",
                principalTable: "Goal",
                principalColumn: "GoalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
