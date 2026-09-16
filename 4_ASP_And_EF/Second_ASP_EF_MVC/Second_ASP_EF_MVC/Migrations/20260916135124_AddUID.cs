using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Second_ASP_EF_MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddUID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UID",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UID",
                table: "Categories");
        }
    }
}
