using Microsoft.EntityFrameworkCore.Migrations;

namespace ItSutra.SecondDemo.Migrations
{
    public partial class PlayerScoreEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Score",
                table: "Players",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Players",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
