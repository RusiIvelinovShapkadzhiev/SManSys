using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class NewentitieswereaddedConversationAbsenceComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildrens_Parents_ParentId",
                table: "ParentChildrens");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildrens_Students_StudentId",
                table: "ParentChildrens");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentMeetingRequests_MeetingRequests_MeetingRequestId",
                table: "ParentMeetingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentMeetingRequests_Parents_ParentId",
                table: "ParentMeetingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Grades_GradeId",
                table: "TeacherGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Teachers_TeacherId",
                table: "TeacherGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherMeetingsRequests_MeetingRequests_MeetingRequestId",
                table: "TeacherMeetingsRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherMeetingsRequests_Teachers_TeacherId",
                table: "TeacherMeetingsRequests");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Parents",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "MeetingRequests",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Absense",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absense_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Absense_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MeetingRequests_StudentId",
                table: "MeetingRequests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Absense_ParentId",
                table: "Absense",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Absense_StudentId",
                table: "Absense",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingRequests_Students_StudentId",
                table: "MeetingRequests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildrens_Parents_ParentId",
                table: "ParentChildrens",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildrens_Students_StudentId",
                table: "ParentChildrens",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentMeetingRequests_MeetingRequests_MeetingRequestId",
                table: "ParentMeetingRequests",
                column: "MeetingRequestId",
                principalTable: "MeetingRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentMeetingRequests_Parents_ParentId",
                table: "ParentMeetingRequests",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Users_UserId",
                table: "Parents",
                column: "UserId",
                principalTable: "Users",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherMeetingsRequests_MeetingRequests_MeetingRequestId",
                table: "TeacherMeetingsRequests",
                column: "MeetingRequestId",
                principalTable: "MeetingRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherMeetingsRequests_Teachers_TeacherId",
                table: "TeacherMeetingsRequests",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingRequests_Students_StudentId",
                table: "MeetingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildrens_Parents_ParentId",
                table: "ParentChildrens");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentChildrens_Students_StudentId",
                table: "ParentChildrens");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentMeetingRequests_MeetingRequests_MeetingRequestId",
                table: "ParentMeetingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentMeetingRequests_Parents_ParentId",
                table: "ParentMeetingRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Users_UserId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Grades_GradeId",
                table: "TeacherGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherGrades_Teachers_TeacherId",
                table: "TeacherGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherMeetingsRequests_MeetingRequests_MeetingRequestId",
                table: "TeacherMeetingsRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherMeetingsRequests_Teachers_TeacherId",
                table: "TeacherMeetingsRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Absense");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Parents_UserId",
                table: "Parents");

            migrationBuilder.DropIndex(
                name: "IX_MeetingRequests_StudentId",
                table: "MeetingRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "MeetingRequests");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildrens_Parents_ParentId",
                table: "ParentChildrens",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentChildrens_Students_StudentId",
                table: "ParentChildrens",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentMeetingRequests_MeetingRequests_MeetingRequestId",
                table: "ParentMeetingRequests",
                column: "MeetingRequestId",
                principalTable: "MeetingRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentMeetingRequests_Parents_ParentId",
                table: "ParentMeetingRequests",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGrades_Grades_GradeId",
                table: "TeacherGrades",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherGrades_Teachers_TeacherId",
                table: "TeacherGrades",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherMeetingsRequests_MeetingRequests_MeetingRequestId",
                table: "TeacherMeetingsRequests",
                column: "MeetingRequestId",
                principalTable: "MeetingRequests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherMeetingsRequests_Teachers_TeacherId",
                table: "TeacherMeetingsRequests",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");
        }
    }
}
