using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exercises_ExerciseId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExerciseId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "ExerciseQuestions",
                columns: table => new
                {
                    ExerciseQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseQuestions", x => x.ExerciseQuestionId);
                    table.ForeignKey(
                        name: "FK_ExerciseQuestions_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseQuestions_ExerciseId",
                table: "ExerciseQuestions",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseQuestions_QuestionId",
                table: "ExerciseQuestions",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseQuestions");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExerciseId",
                table: "Questions",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exercises_ExerciseId",
                table: "Questions",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId");
        }
    }
}
