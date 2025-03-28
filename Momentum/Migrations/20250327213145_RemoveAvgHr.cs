using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Momentum.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAvgHr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgHr",
                table: "Run");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvgHr",
                table: "Run",
                type: "int",
                nullable: true);
        }
    }
}
