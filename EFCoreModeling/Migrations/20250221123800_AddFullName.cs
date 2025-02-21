using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreModeling.Migrations
{
    /// <inheritdoc />
    public partial class AddFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "employees",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[LastName] + ', ' + [FirstName]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ID",
                table: "employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Id");
        }
    }
}
