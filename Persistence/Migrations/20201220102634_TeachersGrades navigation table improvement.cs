using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class TeachersGradesnavigationtableimprovement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absense_Parents_ParentId",
                table: "Absense");

            migrationBuilder.DropForeignKey(
                name: "FK_Absense_Students_StudentId",
                table: "Absense");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Grades_GradeId",
                table: "TeacherGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Teachers_TeacherId",
                table: "TeacherGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherGrades",
                table: "TeacherGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absense",
                table: "Absense");

            migrationBuilder.RenameTable(
                name: "TeacherGrades",
                newName: "TeachersGrades");

            migrationBuilder.RenameTable(
                name: "Absense",
                newName: "Absences");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherGrades_GradeId",
                table: "TeachersGrades",
                newName: "IX_TeachersGrades_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Absense_StudentId",
                table: "Absences",
                newName: "IX_Absences_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Absense_ParentId",
                table: "Absences",
                newName: "IX_Absences_ParentId");

            migrationBuilder.AddColumn<string>(
                name: "ConversationId",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeachersGrades",
                table: "TeachersGrades",
                columns: new[] { "TeacherId", "GradeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absences",
                table: "Absences",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    MeetingRequestId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conversations_MeetingRequests_MeetingRequestId",
                        column: x => x.MeetingRequestId,
                        principalTable: "MeetingRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commnets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AutorName = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commnets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commnets_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParentConversations",
                columns: table => new
                {
                    ParentId = table.Column<string>(type: "TEXT", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentConversations", x => new { x.ParentId, x.ConversationId });
                    table.ForeignKey(
                        name: "FK_ParentConversations_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentConversations_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeachersConversations",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "TEXT", nullable: false),
                    ConversationId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersConversations", x => new { x.TeacherId, x.ConversationId });
                    table.ForeignKey(
                        name: "FK_TeachersConversations_Conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeachersConversations_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ConversationId",
                table: "Teachers",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Commnets_ConversationId",
                table: "Commnets",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_MeetingRequestId",
                table: "Conversations",
                column: "MeetingRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentConversations_ConversationId",
                table: "ParentConversations",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachersConversations_ConversationId",
                table: "TeachersConversations",
                column: "ConversationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_Parents_ParentId",
                table: "Absences",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_Students_StudentId",
                table: "Absences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Conversations_ConversationId",
                table: "Teachers",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Grades_GradeId",
                table: "TeachersGrades",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersGrades_Teachers_TeacherId",
                table: "TeachersGrades",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_Parents_ParentId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_Absences_Students_StudentId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Conversations_ConversationId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Grades_GradeId",
                table: "TeachersGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersGrades_Teachers_TeacherId",
                table: "TeachersGrades");

            migrationBuilder.DropTable(
                name: "Commnets");

            migrationBuilder.DropTable(
                name: "ParentConversations");

            migrationBuilder.DropTable(
                name: "TeachersConversations");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ConversationId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeachersGrades",
                table: "TeachersGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absences",
                table: "Absences");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "TeachersGrades",
                newName: "TeacherGrades");

            migrationBuilder.RenameTable(
                name: "Absences",
                newName: "Absense");

            migrationBuilder.RenameIndex(
                name: "IX_TeachersGrades_GradeId",
                table: "TeacherGrades",
                newName: "IX_TeacherGrades_GradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_StudentId",
                table: "Absense",
                newName: "IX_Absense_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_ParentId",
                table: "Absense",
                newName: "IX_Absense_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherGrades",
                table: "TeacherGrades",
                columns: new[] { "TeacherId", "GradeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absense",
                table: "Absense",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Absense_Parents_ParentId",
                table: "Absense",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Absense_Students_StudentId",
                table: "Absense",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGrades_Grades_GradeId",
                table: "TeacherGrades",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGrades_Teachers_TeacherId",
                table: "TeacherGrades",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
