using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvc.Migrations.Seller
{
    public partial class Ijln : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_username = table.Column<string>(nullable: true),
                    S_password = table.Column<string>(nullable: true),
                    S_comapnyname = table.Column<string>(nullable: true),
                    S_gstin = table.Column<string>(nullable: true),
                    S_abtcompany = table.Column<string>(nullable: true),
                    S_postaladdress = table.Column<string>(nullable: true),
                    S_website = table.Column<string>(nullable: true),
                    S_emailid = table.Column<string>(nullable: true),
                    S_mobilenum = table.Column<long>(nullable: false),
                    photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
