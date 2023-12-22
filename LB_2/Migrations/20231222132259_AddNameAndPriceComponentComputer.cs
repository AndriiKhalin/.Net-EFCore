using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LB_2.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAndPriceComponentComputer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ComponentComputers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "ComponentComputers",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ComponentComputers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ComponentComputers");
        }
    }
}
