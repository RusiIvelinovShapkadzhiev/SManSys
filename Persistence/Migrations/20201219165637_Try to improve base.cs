using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Trytoimprovebase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absense_Parents_ParentId",
                table: "Absense");

            migrationBuilder.DropForeignKey(
                name: "FK_Absense_Students_StudentId",
                table: "Absense");

            migrationBuilder.DropTable(
                name: "TeacherGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absense",
                table: "Absense");

            migrationBuilder.RenameTable(
                name: "Absense",
                newName: "Absences");

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

            migrationBuilder.AddColumn<string>(
                name: "GradeId",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConversationId",
                table: "Parents",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ConversationId",
                table: "Teachers",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_GradeId",
                table: "Teachers",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_ConversationId",
                table: "Parents",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Commnets_ConversationId",
                table: "Commnets",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversations_MeetingRequestId",
                table: "Conversations",
                column: "MeetingRequestId");

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
                name: "FK_Parents_Conversations_ConversationId",
                table: "Parents",
                column: "ConversationId",
                principalTable: "Conversations",
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
                name: "FK_Teachers_Grades_GradeId",
                table: "Teachers",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                name: "FK_Parents_Conversations_ConversationId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Conversations_ConversationId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Grades_GradeId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Commnets");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ConversationId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_GradeId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Parents_ConversationId",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absences",
                table: "Absences");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Parents");

            migrationBuilder.RenameTable(
                name: "Absences",
                newName: "Absense");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_StudentId",
                table: "Absense",
                newName: "IX_Absense_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Absences_ParentId",
                table: "Absense",
                newName: "IX_Absense_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absense",
                table: "Absense",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TeacherGrades",
                columns: table => new
                {
                    TeacherId = table.Column<string>(type: "TEXT", nullable: false),
                    GradeId = table.Column<string>(type: "TEXT", nullable: false),
                    IsTeaching = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherGrades", x => new { x.TeacherId, x.GradeId });
                    table.ForeignKey(
                        name: "FK_TeacherGrades_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherGrades_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherGrades_GradeId",
                table: "TeacherGrades",
                column: "GradeId");

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
        }
    }
}
