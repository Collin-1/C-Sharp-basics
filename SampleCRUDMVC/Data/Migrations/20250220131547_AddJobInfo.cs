using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SampleCRUDMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddJobInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobTiltle",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Seniority",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "yearsAtCompany",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobTiltle",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Seniority",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "yearsAtCompany",
                table: "Employees");
        }
    }
}
