using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedExecCons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExecutionInfo",
                columns: new[] { "ExecutionId", "ExecutionIndex", "RelativeFolderPath" },
                values: new object[] { 1, "Run1", "samplepath" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExecutionInfo",
                keyColumn: "ExecutionId",
                keyValue: 1);
        }
    }
}
