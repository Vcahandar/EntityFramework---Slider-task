using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntytiFramework_Slider.Migrations
{
    public partial class RemoveCountColumToSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Sliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
