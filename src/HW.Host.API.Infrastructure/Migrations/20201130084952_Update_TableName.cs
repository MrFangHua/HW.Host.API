using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_TableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_Admin");

            migrationBuilder.DropTable(
                name: "FH_BackGroundImageInfo");

            migrationBuilder.DropTable(
                name: "FH_CopywritingInfo");

            migrationBuilder.DropTable(
                name: "FH_EmailHistoryInfo");

            migrationBuilder.DropTable(
                name: "FH_Users");

            migrationBuilder.CreateTable(
                name: "HW_Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    AdminName = table.Column<string>(nullable: false),
                    AdminPwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HW_BackGroundImageInfo",
                columns: table => new
                {
                    BGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    BGUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_BackGroundImageInfo", x => x.BGId);
                });

            migrationBuilder.CreateTable(
                name: "HW_CopywritingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    Content = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_CopywritingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HW_EmailHistoryInfo",
                columns: table => new
                {
                    EHID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    RecipientId = table.Column<string>(nullable: false),
                    EmailBody = table.Column<string>(nullable: false),
                    EmailCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_EmailHistoryInfo", x => x.EHID);
                });

            migrationBuilder.CreateTable(
                name: "HW_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    UserPwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HW_Admin",
                columns: new[] { "Id", "AdminName", "AdminPwd", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 1, "Admin", "Admin123456", 0, new DateTime(2020, 11, 30, 16, 49, 52, 163, DateTimeKind.Local).AddTicks(5354), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(1048) },
                    { 2, "Mr.Fang", "Fh2269...", 0, new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(2751), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(2754) }
                });

            migrationBuilder.InsertData(
                table: "HW_BackGroundImageInfo",
                columns: new[] { "BGId", "BGUrl", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 74, "/assets/images/backGround/bg74.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8727), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8728) },
                    { 73, "/assets/images/backGround/bg73.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8716), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8716) },
                    { 72, "/assets/images/backGround/bg72.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8675), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8676) },
                    { 71, "/assets/images/backGround/bg71.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8646), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8647) },
                    { 70, "/assets/images/backGround/bg70.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8635), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8636) },
                    { 69, "/assets/images/backGround/bg69.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8624), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8624) },
                    { 68, "/assets/images/backGround/bg68.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8613), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8613) },
                    { 67, "/assets/images/backGround/bg67.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8602), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8602) },
                    { 66, "/assets/images/backGround/bg66.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8590), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8591) },
                    { 65, "/assets/images/backGround/bg65.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8578), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8579) },
                    { 64, "/assets/images/backGround/bg64.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8567), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8568) },
                    { 63, "/assets/images/backGround/bg63.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8556), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8556) },
                    { 62, "/assets/images/backGround/bg62.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8545), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8545) },
                    { 61, "/assets/images/backGround/bg61.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8534), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8534) },
                    { 60, "/assets/images/backGround/bg60.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8522), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8522) },
                    { 59, "/assets/images/backGround/bg59.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8482), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8482) },
                    { 58, "/assets/images/backGround/bg58.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8469), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8471) },
                    { 57, "/assets/images/backGround/bg57.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8458), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8459) },
                    { 56, "/assets/images/backGround/bg56.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8447), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8448) },
                    { 55, "/assets/images/backGround/bg55.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8436), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8436) },
                    { 54, "/assets/images/backGround/bg54.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8424), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8425) },
                    { 53, "/assets/images/backGround/bg53.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8413), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8414) },
                    { 75, "/assets/images/backGround/bg75.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8738), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8739) },
                    { 76, "/assets/images/backGround/bg76.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8749), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8750) },
                    { 77, "/assets/images/backGround/bg77.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8760), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8761) },
                    { 78, "/assets/images/backGround/bg78.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8772), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8772) },
                    { 100, "/assets/images/backGround/bg100.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9238), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9239) },
                    { 99, "/assets/images/backGround/bg99.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9226), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9227) },
                    { 98, "/assets/images/backGround/bg98.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9214), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9215) },
                    { 97, "/assets/images/backGround/bg97.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9202), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9203) },
                    { 96, "/assets/images/backGround/bg96.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9191), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9191) },
                    { 95, "/assets/images/backGround/bg95.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9178), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9179) },
                    { 94, "/assets/images/backGround/bg94.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9166), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9167) },
                    { 93, "/assets/images/backGround/bg93.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9155), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9155) },
                    { 92, "/assets/images/backGround/bg92.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9143), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9144) },
                    { 91, "/assets/images/backGround/bg91.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9132), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9132) },
                    { 51, "/assets/images/backGround/bg51.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8388), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8388) },
                    { 90, "/assets/images/backGround/bg90.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9119), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9120) },
                    { 88, "/assets/images/backGround/bg88.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9092), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9093) },
                    { 87, "/assets/images/backGround/bg87.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8872), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8872) },
                    { 86, "/assets/images/backGround/bg86.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8860), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8861) },
                    { 85, "/assets/images/backGround/bg85.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8850), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8850) },
                    { 84, "/assets/images/backGround/bg84.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8838), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8839) },
                    { 83, "/assets/images/backGround/bg83.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8827), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8828) },
                    { 82, "/assets/images/backGround/bg82.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8816), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8817) },
                    { 81, "/assets/images/backGround/bg81.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8805), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8806) },
                    { 80, "/assets/images/backGround/bg80.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8794), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8794) },
                    { 79, "/assets/images/backGround/bg79.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8783), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8783) },
                    { 89, "/assets/images/backGround/bg89.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9107), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9108) },
                    { 50, "/assets/images/backGround/bg50.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8377), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8377) },
                    { 52, "/assets/images/backGround/bg52.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8399), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8400) },
                    { 48, "/assets/images/backGround/bg48.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8354), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8355) },
                    { 22, "/assets/images/backGround/bg22.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7897), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7897) },
                    { 49, "/assets/images/backGround/bg49.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8366), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8366) },
                    { 20, "/assets/images/backGround/bg20.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7872), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7873) },
                    { 19, "/assets/images/backGround/bg19.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7860), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7860) },
                    { 18, "/assets/images/backGround/bg18.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7848), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7848) },
                    { 17, "/assets/images/backGround/bg17.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7835), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7835) },
                    { 16, "/assets/images/backGround/bg16.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7822), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7823) },
                    { 15, "/assets/images/backGround/bg15.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7806), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7806) },
                    { 14, "/assets/images/backGround/bg14.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7577), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7577) },
                    { 13, "/assets/images/backGround/bg13.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7565), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7566) },
                    { 23, "/assets/images/backGround/bg23.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7909), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7909) },
                    { 12, "/assets/images/backGround/bg12.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7553), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7554) },
                    { 10, "/assets/images/backGround/bg10.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7529), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7530) },
                    { 9, "/assets/images/backGround/bg9.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7517), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7517) },
                    { 8, "/assets/images/backGround/bg8.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7502), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7503) },
                    { 7, "/assets/images/backGround/bg7.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7490), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7491) },
                    { 6, "/assets/images/backGround/bg6.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7479), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7479) },
                    { 5, "/assets/images/backGround/bg5.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7464), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7465) },
                    { 4, "/assets/images/backGround/bg4.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7452), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7453) },
                    { 3, "/assets/images/backGround/bg3.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7436), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7437) },
                    { 2, "/assets/images/backGround/bg2.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7399), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7401) },
                    { 1, "/assets/images/backGround/bg1.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(6007), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(6010) },
                    { 11, "/assets/images/backGround/bg11.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7542), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7542) },
                    { 24, "/assets/images/backGround/bg24.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7921), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7922) },
                    { 21, "/assets/images/backGround/bg21.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7884), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7884) },
                    { 26, "/assets/images/backGround/bg26.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7946), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7947) },
                    { 47, "/assets/images/backGround/bg47.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8343), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8344) },
                    { 46, "/assets/images/backGround/bg46.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8332), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8332) },
                    { 45, "/assets/images/backGround/bg45.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8320), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8321) },
                    { 44, "/assets/images/backGround/bg44.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8308), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8309) },
                    { 43, "/assets/images/backGround/bg43.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8269), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8269) },
                    { 42, "/assets/images/backGround/bg42.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8258), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8258) },
                    { 25, "/assets/images/backGround/bg25.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7933), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7934) },
                    { 40, "/assets/images/backGround/bg40.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8234), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8235) },
                    { 39, "/assets/images/backGround/bg39.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8223), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8224) },
                    { 38, "/assets/images/backGround/bg38.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8212), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8212) },
                    { 41, "/assets/images/backGround/bg41.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8246), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8247) },
                    { 36, "/assets/images/backGround/bg36.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8189), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8190) },
                    { 35, "/assets/images/backGround/bg35.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8178), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8178) },
                    { 34, "/assets/images/backGround/bg34.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8166), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8167) },
                    { 33, "/assets/images/backGround/bg33.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8153), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8154) },
                    { 32, "/assets/images/backGround/bg32.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8142), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8142) },
                    { 31, "/assets/images/backGround/bg31.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8129), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8130) },
                    { 30, "/assets/images/backGround/bg30.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8115), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8115) },
                    { 29, "/assets/images/backGround/bg29.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7983), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7984) },
                    { 28, "/assets/images/backGround/bg28.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7970), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7970) },
                    { 37, "/assets/images/backGround/bg37.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8201), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8201) },
                    { 27, "/assets/images/backGround/bg27.jpg", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7958), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7958) }
                });

            migrationBuilder.InsertData(
                table: "HW_CopywritingInfo",
                columns: new[] { "Id", "Content", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 5, "生活便是寻求新的知识。——门捷列夫", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4693), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4694) },
                    { 4, "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4691), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4692) },
                    { 3, "你羡慕的生活都是你没熬过的苦。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4689), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4690) },
                    { 6, "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4695), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4696) },
                    { 1, "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(2700), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(2702) },
                    { 2, "脏的人多了，干净反倒成了一种错。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4676), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4680) },
                    { 7, "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。", 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4697), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4698) }
                });

            migrationBuilder.InsertData(
                table: "HW_Users",
                columns: new[] { "Id", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "UserName", "UserPwd" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(7241), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(7246), "Admin", "Admin123456" },
                    { 2, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(1518), 0, null, 0, new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(1522), "Mr.Fang", "Fh2269..." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HW_Admin");

            migrationBuilder.DropTable(
                name: "HW_BackGroundImageInfo");

            migrationBuilder.DropTable(
                name: "HW_CopywritingInfo");

            migrationBuilder.DropTable(
                name: "HW_EmailHistoryInfo");

            migrationBuilder.DropTable(
                name: "HW_Users");

            migrationBuilder.CreateTable(
                name: "FH_Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminName = table.Column<string>(nullable: false),
                    AdminPwd = table.Column<string>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FH_BackGroundImageInfo",
                columns: table => new
                {
                    BGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BGUrl = table.Column<string>(nullable: true),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_BackGroundImageInfo", x => x.BGId);
                });

            migrationBuilder.CreateTable(
                name: "FH_CopywritingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(maxLength: 200, nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_CopywritingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FH_EmailHistoryInfo",
                columns: table => new
                {
                    EHID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    EmailBody = table.Column<string>(nullable: false),
                    EmailCode = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    RecipientId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_EmailHistoryInfo", x => x.EHID);
                });

            migrationBuilder.CreateTable(
                name: "FH_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    UserPwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FH_Admin",
                columns: new[] { "Id", "AdminName", "AdminPwd", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 1, "Admin", "Admin123456", 0, new DateTime(2020, 11, 30, 16, 16, 35, 911, DateTimeKind.Local).AddTicks(4060), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(7646) },
                    { 2, "Mr.Fang", "Fh2269...", 0, new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(9314), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(9317) }
                });

            migrationBuilder.InsertData(
                table: "FH_BackGroundImageInfo",
                columns: new[] { "BGId", "BGUrl", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 74, "/assets/images/backGround/bg74.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7887), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7888) },
                    { 73, "/assets/images/backGround/bg73.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7877), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7877) },
                    { 72, "/assets/images/backGround/bg72.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7866), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7867) },
                    { 71, "/assets/images/backGround/bg71.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7840), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7841) },
                    { 70, "/assets/images/backGround/bg70.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7828), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7829) },
                    { 69, "/assets/images/backGround/bg69.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7792), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7793) },
                    { 68, "/assets/images/backGround/bg68.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7782), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7782) },
                    { 67, "/assets/images/backGround/bg67.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7772), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7772) },
                    { 66, "/assets/images/backGround/bg66.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7761), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7762) },
                    { 65, "/assets/images/backGround/bg65.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7749), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7750) },
                    { 64, "/assets/images/backGround/bg64.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7739), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7740) },
                    { 63, "/assets/images/backGround/bg63.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7728), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7729) },
                    { 62, "/assets/images/backGround/bg62.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7718), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7719) },
                    { 61, "/assets/images/backGround/bg61.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7708), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7708) },
                    { 60, "/assets/images/backGround/bg60.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7698), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7698) },
                    { 59, "/assets/images/backGround/bg59.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7687), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7688) },
                    { 58, "/assets/images/backGround/bg58.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7677), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7678) },
                    { 57, "/assets/images/backGround/bg57.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7666), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7667) },
                    { 56, "/assets/images/backGround/bg56.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7625), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7625) },
                    { 55, "/assets/images/backGround/bg55.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7615), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7615) },
                    { 54, "/assets/images/backGround/bg54.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7604), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7605) },
                    { 53, "/assets/images/backGround/bg53.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7594), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7594) },
                    { 75, "/assets/images/backGround/bg75.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7898), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7898) },
                    { 76, "/assets/images/backGround/bg76.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7908), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7909) },
                    { 77, "/assets/images/backGround/bg77.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7919), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7919) },
                    { 78, "/assets/images/backGround/bg78.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7929), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7930) },
                    { 100, "/assets/images/backGround/bg100.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8190), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8191) },
                    { 99, "/assets/images/backGround/bg99.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8180), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8180) },
                    { 98, "/assets/images/backGround/bg98.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8169), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8170) },
                    { 97, "/assets/images/backGround/bg97.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8159), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8159) },
                    { 96, "/assets/images/backGround/bg96.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8149), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8149) },
                    { 95, "/assets/images/backGround/bg95.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8138), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8139) },
                    { 94, "/assets/images/backGround/bg94.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8128), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8128) },
                    { 93, "/assets/images/backGround/bg93.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8117), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8118) },
                    { 92, "/assets/images/backGround/bg92.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8107), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8107) },
                    { 91, "/assets/images/backGround/bg91.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8096), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8097) },
                    { 51, "/assets/images/backGround/bg51.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7573), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7574) },
                    { 90, "/assets/images/backGround/bg90.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8086), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8086) },
                    { 88, "/assets/images/backGround/bg88.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8065), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8065) },
                    { 87, "/assets/images/backGround/bg87.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8054), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8055) },
                    { 86, "/assets/images/backGround/bg86.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8044), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8044) },
                    { 85, "/assets/images/backGround/bg85.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8002), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8003) },
                    { 84, "/assets/images/backGround/bg84.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7992), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7992) },
                    { 83, "/assets/images/backGround/bg83.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7981), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7982) },
                    { 82, "/assets/images/backGround/bg82.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7971), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7972) },
                    { 81, "/assets/images/backGround/bg81.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7960), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7961) },
                    { 80, "/assets/images/backGround/bg80.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7950), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7951) },
                    { 79, "/assets/images/backGround/bg79.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7940), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7940) },
                    { 89, "/assets/images/backGround/bg89.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8075), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8076) },
                    { 50, "/assets/images/backGround/bg50.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7563), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7563) },
                    { 52, "/assets/images/backGround/bg52.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7584), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7584) },
                    { 48, "/assets/images/backGround/bg48.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7541), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7542) },
                    { 22, "/assets/images/backGround/bg22.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7145), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7146) },
                    { 49, "/assets/images/backGround/bg49.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7552), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7552) },
                    { 20, "/assets/images/backGround/bg20.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7124), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7125) },
                    { 19, "/assets/images/backGround/bg19.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7113), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7114) },
                    { 18, "/assets/images/backGround/bg18.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7103), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7103) },
                    { 17, "/assets/images/backGround/bg17.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7091), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7091) },
                    { 16, "/assets/images/backGround/bg16.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7080), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7081) },
                    { 15, "/assets/images/backGround/bg15.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7070), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7070) },
                    { 14, "/assets/images/backGround/bg14.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7059), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7059) },
                    { 13, "/assets/images/backGround/bg13.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7048), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7048) },
                    { 23, "/assets/images/backGround/bg23.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7156), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7156) },
                    { 12, "/assets/images/backGround/bg12.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7000), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7001) },
                    { 10, "/assets/images/backGround/bg10.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6978), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6979) },
                    { 9, "/assets/images/backGround/bg9.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6967), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6967) },
                    { 8, "/assets/images/backGround/bg8.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6956), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6957) },
                    { 7, "/assets/images/backGround/bg7.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6946), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6946) },
                    { 6, "/assets/images/backGround/bg6.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6935), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6935) },
                    { 5, "/assets/images/backGround/bg5.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6922), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6922) },
                    { 4, "/assets/images/backGround/bg4.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6911), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6911) },
                    { 3, "/assets/images/backGround/bg3.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6897), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6898) },
                    { 2, "/assets/images/backGround/bg2.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6865), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6867) },
                    { 1, "/assets/images/backGround/bg1.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(5572), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(5574) },
                    { 11, "/assets/images/backGround/bg11.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6990), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6990) },
                    { 24, "/assets/images/backGround/bg24.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7166), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7167) },
                    { 21, "/assets/images/backGround/bg21.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7135), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7135) },
                    { 26, "/assets/images/backGround/bg26.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7187), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7188) },
                    { 47, "/assets/images/backGround/bg47.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7531), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7531) },
                    { 46, "/assets/images/backGround/bg46.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7521), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7521) },
                    { 45, "/assets/images/backGround/bg45.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7510), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7511) },
                    { 44, "/assets/images/backGround/bg44.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7500), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7500) },
                    { 43, "/assets/images/backGround/bg43.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7489), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7490) },
                    { 42, "/assets/images/backGround/bg42.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7478), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7479) },
                    { 25, "/assets/images/backGround/bg25.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7177), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7177) },
                    { 40, "/assets/images/backGround/bg40.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7365), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7365) },
                    { 39, "/assets/images/backGround/bg39.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7354), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7355) },
                    { 38, "/assets/images/backGround/bg38.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7344), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7344) },
                    { 41, "/assets/images/backGround/bg41.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7375), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7376) },
                    { 36, "/assets/images/backGround/bg36.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7323), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7323) },
                    { 35, "/assets/images/backGround/bg35.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7313), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7313) },
                    { 34, "/assets/images/backGround/bg34.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7302), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7302) },
                    { 33, "/assets/images/backGround/bg33.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7290), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7291) },
                    { 32, "/assets/images/backGround/bg32.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7280), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7280) },
                    { 31, "/assets/images/backGround/bg31.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7269), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7269) },
                    { 30, "/assets/images/backGround/bg30.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7258), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7259) },
                    { 29, "/assets/images/backGround/bg29.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7248), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7249) },
                    { 28, "/assets/images/backGround/bg28.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7237), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7238) },
                    { 37, "/assets/images/backGround/bg37.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7333), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7334) },
                    { 27, "/assets/images/backGround/bg27.jpg", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7198), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7198) }
                });

            migrationBuilder.InsertData(
                table: "FH_CopywritingInfo",
                columns: new[] { "Id", "Content", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 5, "生活便是寻求新的知识。——门捷列夫", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4776), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4777) },
                    { 4, "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4774), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4775) },
                    { 3, "你羡慕的生活都是你没熬过的苦。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4773), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4773) },
                    { 6, "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4777), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4778) },
                    { 1, "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3951), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3954) },
                    { 2, "脏的人多了，干净反倒成了一种错。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4763), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4766) },
                    { 7, "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。", 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4779), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4780) }
                });

            migrationBuilder.InsertData(
                table: "FH_Users",
                columns: new[] { "Id", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "UserName", "UserPwd" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(1833), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(1836), "Admin", "Admin123456" },
                    { 2, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3130), 0, null, 0, new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3132), "Mr.Fang", "Fh2269..." }
                });
        }
    }
}