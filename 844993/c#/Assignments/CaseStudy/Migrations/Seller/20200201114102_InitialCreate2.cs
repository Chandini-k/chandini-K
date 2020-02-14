using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseStudy.Migrations.Seller
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "sellers",
               columns: table => new
               {
                   Sid = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   UserName = table.Column<string>(maxLength: 10, nullable: false),
                   Password = table.Column<string>(nullable: false),
                   Email = table.Column<string>(nullable: true),
                   MobileNo = table.Column<long>(nullable: false),
                   Companyname = table.Column<string>(nullable: false),
                   BriefabtCompany = table.Column<string>(nullable: false),
                   Address = table.Column<string>(nullable: false),
                   Website = table.Column<string>(nullable: false),
                   GSTIN = table.Column<int>(nullable: false),
                   PhotoPath = table.Column<string>(nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_sellers", x => x.Sid);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sellers");
        }
    }
}
