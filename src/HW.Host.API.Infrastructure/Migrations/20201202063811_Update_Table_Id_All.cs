using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_Table_Id_All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiveID",
                table: "HW_PhoneReceiveInfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PhoneID",
                table: "HW_PhoneModelInfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EHID",
                table: "HW_EmailHistoryInfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BGId",
                table: "HW_BackGroundImageInfo",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 769, DateTimeKind.Local).AddTicks(9179), new DateTime(2020, 12, 2, 14, 38, 10, 771, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 771, DateTimeKind.Local).AddTicks(4917), new DateTime(2020, 12, 2, 14, 38, 10, 771, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(4139), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5498), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5537), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5555), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5569), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5585), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5601), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5617), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5630), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5644), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5659), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5672), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5686), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5748), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5761), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5773), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5786), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5800), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5812), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5824), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5837), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5849), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5862), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5874), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5886), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5898), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5941), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5954), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5967), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5979), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5991), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6003), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6015), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6030), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6042), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6055), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6068), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6080), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6093), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6134), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6148), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6160), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6173), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6186), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6199), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6212), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6224), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6236), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6249), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6261), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6274), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6286), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6298), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6370), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6386), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6398), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6411), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6423), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6435), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6447), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6459), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6472), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6484), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6497), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6509), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6524), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6568), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6608), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6621), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6633), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6646), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6658), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6671), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6684), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6696), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6708), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6720), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6733), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6745), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6758), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6862), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6875), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6887), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6899), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6912), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6924), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6936), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6948), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6960), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6985), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6997), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7009), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7021), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7065), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7078), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7090), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7102), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7114), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7164), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(1868), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2879), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2890), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2893), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2944), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2945), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2947), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 2, 14, 38, 10, 773, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 2, 14, 38, 10, 774, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 2, 14, 38, 10, 774, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 771, DateTimeKind.Local).AddTicks(8292), new DateTime(2020, 12, 2, 14, 38, 10, 771, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(608), new DateTime(2020, 12, 2, 14, 38, 10, 772, DateTimeKind.Local).AddTicks(614) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HW_PhoneReceiveInfo",
                newName: "ReceiveID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HW_PhoneModelInfo",
                newName: "PhoneID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HW_EmailHistoryInfo",
                newName: "EHID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HW_BackGroundImageInfo",
                newName: "BGId");

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 598, DateTimeKind.Local).AddTicks(3239), new DateTime(2020, 12, 1, 11, 14, 38, 599, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 599, DateTimeKind.Local).AddTicks(8075), new DateTime(2020, 12, 1, 11, 14, 38, 599, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(5106), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6411), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6445), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6510), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6524), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6539), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6550), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6561), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6572), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6584), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6597), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6608), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6619), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6630), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6641), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6652), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6663), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6709), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6720), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6731), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6742), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6753), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6764), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6775), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6786), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6797), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6808), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6819), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6829), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6840), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6915), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6928), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6939), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6951), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6962), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6984), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6996), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7007), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7018), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7029), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7051), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7102), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7115), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7126), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7137), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7148), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7159), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7170), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7181), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7192), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7203), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7213), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7225), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7235), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7246), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7291), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7303), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7314), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7325), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7336), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7346), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7358), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7368), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7380), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7391), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7424), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7435), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7489), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7500), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7511), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7522), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7533), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7543), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7554), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7566), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7577), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7588), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7599), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7609), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7620), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7631), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7679), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7690), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7701), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7712), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7723), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7734), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7744), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7756), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7767), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7777), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7788), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7799), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7810), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7821), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7868), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7905), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(3340), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4197), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4208), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4210), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4212), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4214), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4216), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "ReceiveID",
                keyValue: 1,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "ReceiveID",
                keyValue: 2,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "ReceiveID",
                keyValue: 3,
                column: "ReceiveTime",
                value: new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(735), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(2290), new DateTime(2020, 12, 1, 11, 14, 38, 600, DateTimeKind.Local).AddTicks(2292) });
        }
    }
}