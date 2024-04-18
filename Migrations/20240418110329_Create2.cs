using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityTaskOne.Migrations
{
    /// <inheritdoc />
    public partial class Create2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "yousef", "www.google.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
