using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddingIsLockedColumnToAccountTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WrongTrails",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isLocked",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WrongTrails",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "isLocked",
                table: "Accounts");
        }
    }
}
