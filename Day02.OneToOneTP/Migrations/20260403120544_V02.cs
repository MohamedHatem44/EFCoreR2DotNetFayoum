using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day02.OneToOneTP.Migrations
{
    /// <inheritdoc />
    public partial class V02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Instructors_InstructorId",
                table: "Cars");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Instructors_InstructorId",
                table: "Cars",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Instructors_InstructorId",
                table: "Cars");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Instructors_InstructorId",
                table: "Cars",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
