using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskFlow.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TaskItems",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime('now','localtime')");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "TaskItems",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CreatedAt", table: "TaskItems");
            migrationBuilder.DropColumn(name: "CompletedAt", table: "TaskItems");
        }
    }
}
