using Microsoft.EntityFrameworkCore.Migrations;

namespace TaxiQualifier.Web.Migrations
{
    public partial class ModifyingDatEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Qualification",
                table: "Trips",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Trips",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Trips");

            migrationBuilder.AlterColumn<int>(
                name: "Qualification",
                table: "Trips",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
