using Microsoft.EntityFrameworkCore.Migrations;

namespace R3AL.Data.Migrations
{
    public partial class Responses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "Descritption",
                table: "Project",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_Response_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_QuestionId",
                table: "Response",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Quiz");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Project",
                newName: "Descritption");

            migrationBuilder.AddColumn<int>(
                name: "Answer",
                table: "Question",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
