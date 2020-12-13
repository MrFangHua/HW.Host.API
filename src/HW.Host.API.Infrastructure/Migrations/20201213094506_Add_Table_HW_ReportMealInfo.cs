using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_HW_ReportMealInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HW_ReportMealInfo",
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
                    ReportMealUserID = table.Column<int>(nullable: false),
                    ReportMealTime = table.Column<string>(nullable: false),
                    Lunch = table.Column<int>(nullable: false),
                    Dinner = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_ReportMealInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HW_ReportMealInfo_HW_Users_ReportMealUserID",
                        column: x => x.ReportMealUserID,
                        principalTable: "HW_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 222, DateTimeKind.Local).AddTicks(6253), new DateTime(2020, 12, 13, 17, 45, 6, 223, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(347), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6018), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6819), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6848), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6861), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6872), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6886), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6897), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6908), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6919), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6930), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6941), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6962), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6983), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7032), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7042), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7054), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7065), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7076), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7087), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7097), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7108), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7118), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7129), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7161), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7197), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7208), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7218), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7228), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7239), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7250), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7261), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7272), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7282), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7293), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7303), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7314), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7324), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7361), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7372), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7383), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7393), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7404), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7414), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7425), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7435), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7456), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7467), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7478), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7488), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7499), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7533), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7544), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7555), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7565), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7576), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7586), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7597), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7607), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7618), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7628), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7652), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7663), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7698), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7721), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7732), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7742), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7753), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7763), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7774), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7785), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7796), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7806), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7817), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7828), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7838), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7874), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7886), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7897), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7907), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7918), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7929), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7950), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7961), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7971), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7982), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8003), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8014), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8080), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8093), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8104), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8115), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(4384), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5039), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5048), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5050), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5052), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5054), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5168), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8598), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4708), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4763), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4770), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4776), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4781), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4786), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4792), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4797), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4802), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4808), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4813), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4818), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4823), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4828), new DateTime(2020, 12, 13, 17, 45, 6, 225, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(2826), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(3712), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.CreateIndex(
                name: "IX_HW_ReportMealInfo_ReportMealUserID",
                table: "HW_ReportMealInfo",
                column: "ReportMealUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HW_ReportMealInfo");

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 165, DateTimeKind.Local).AddTicks(9928), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(4494), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(81), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1429), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1468), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1572), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1584), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1599), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1665), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1677), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1688), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1700), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1712), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1723), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1734), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1745), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1756), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1767), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1778), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1790), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1801), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1841), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1853), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1864), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1875), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1886), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1897), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1908), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1918), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1930), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1941), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1952), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1963), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1974), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1984), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2026), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2037), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2048), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2059), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2158), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2168), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2178), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2189), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2199), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2209), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2219), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2229), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2239), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2275), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2286), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2296), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2306), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2317), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2327), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2337), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2347), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2357), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2368), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2378), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2388), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2398), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2408), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2444), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2456), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2466), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2476), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2487), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2498), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2508), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2532), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2542), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2553), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2563), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2573), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2583), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2620), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2630), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2641), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2651), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2661), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2671), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2681), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2691), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2702), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2712), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2722), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2732), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2743), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2753), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2823), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2833), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2844), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2854), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2864), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2874), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2884), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2894), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2905), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2915), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2925), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2935), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2969), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(8756), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9387), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9396), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9399), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9400), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9402), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9404), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(3626), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8902), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8955), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8962), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8967), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8972), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8977), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8984), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8990), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8995), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9000), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9005), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9010), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9015), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9020), new DateTime(2020, 12, 13, 17, 44, 41, 168, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(7161), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(8046), new DateTime(2020, 12, 13, 17, 44, 41, 167, DateTimeKind.Local).AddTicks(8048) });
        }
    }
}
