using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablesToWorkWithWallets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "WalletBalance",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "WalletBalance",
                table: "Accounts");
        }
    }
}
