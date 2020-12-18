using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Cascadedeletionimplemented : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
