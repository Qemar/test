using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Склад.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseIdToStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "plz");

            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "plz",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_plz",
                table: "plz",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_plz",
                table: "plz");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "plz");

            migrationBuilder.RenameTable(
                name: "plz",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
