using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Склад.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCourseId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "plz");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "plz",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
