using Microsoft.EntityFrameworkCore.Migrations;

namespace ItSutra.SecondDemo.Migrations
{
    public partial class _2ndPlayerScoreEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Players",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Score",
                table: "Players",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
