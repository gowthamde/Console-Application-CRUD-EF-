using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodStop.Migrations
{
    /// <inheritdoc />
    public partial class BranchSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "Location", "Name", "PhoneNo" },
                values: new object[,]
                {
                    { 5, "covai", "A2B Restraurant", 1234567890L },
                    { 6, "covai", "Covai Koli Restraurant", 1234567890L },
                    { 7, "SAP", "Gowtham Restraurant", 1234567890L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
