using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class house : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    qu_site_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qu_site_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.qu_site_ID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    shi_site_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shi_site_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.shi_site_ID);
                });

            migrationBuilder.CreateTable(
                name: "Finance",
                columns: table => new
                {
                    finance_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    finance_number = table.Column<string>(nullable: true),
                    finance_contract = table.Column<string>(nullable: true),
                    finance_time = table.Column<DateTime>(nullable: false),
                    finance_ysmoney = table.Column<string>(nullable: true),
                    finance_yfmoney = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finance", x => x.finance_ID);
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    house_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    house_name = table.Column<string>(nullable: true),
                    house_sheng = table.Column<int>(nullable: false),
                    house_shi = table.Column<int>(nullable: false),
                    house_qu = table.Column<int>(nullable: false),
                    House_img = table.Column<string>(nullable: true),
                    house_floor = table.Column<string>(nullable: true),
                    house_lxname = table.Column<string>(nullable: true),
                    house_phone = table.Column<string>(nullable: true),
                    house_area = table.Column<string>(nullable: true),
                    house_rent = table.Column<string>(nullable: true),
                    house_state = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.house_id);
                });

            migrationBuilder.CreateTable(
                name: "landlord",
                columns: table => new
                {
                    landlord_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    landlord_name = table.Column<string>(nullable: true),
                    landlord_Sex = table.Column<int>(nullable: false),
                    landlord_Age = table.Column<int>(nullable: false),
                    landlord_Img = table.Column<string>(nullable: true),
                    landlord_poc = table.Column<string>(nullable: true),
                    landlord_phone = table.Column<string>(nullable: true),
                    landlord_HouseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_landlord", x => x.landlord_ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Menus_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Menus_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Menus_ID);
                });

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    sheng_site_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sheng_site_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.sheng_site_ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Roles_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roles_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Roles_ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    RoleMenu_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleMenu_RolrID = table.Column<int>(nullable: false),
                    RoleMenu_MenuID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.RoleMenu_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Users_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Users_Name = table.Column<string>(nullable: true),
                    User_Pwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Users_ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRole_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRole_UserID = table.Column<int>(nullable: false),
                    UserRole_RoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRole_ID);
                });

            migrationBuilder.CreateTable(
                name: "yonghu",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    sex = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    img = table.Column<string>(nullable: true),
                    dentification_card_img = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yonghu", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Finance");

            migrationBuilder.DropTable(
                name: "House");

            migrationBuilder.DropTable(
                name: "landlord");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "yonghu");
        }
    }
}
