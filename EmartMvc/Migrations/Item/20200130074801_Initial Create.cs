using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMvc.Migrations.Item
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    I_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_id = table.Column<int>(nullable: false),
                    SC_id = table.Column<int>(nullable: false),
                    I_price = table.Column<double>(nullable: false),
                    I_des = table.Column<string>(nullable: true),
                    I_stocknum = table.Column<int>(nullable: false),
                    I_remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.I_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
