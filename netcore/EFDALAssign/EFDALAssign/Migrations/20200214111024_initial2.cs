using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDALAssign.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Item",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Item",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
