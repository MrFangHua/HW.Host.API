using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Delete_Table_HW_ReportMealInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HW_ReportMealInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    Dinner = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    Lunch = table.Column<int>(nullable: false),
                    ReportMealTime = table.Column<string>(nullable: false),
                    ReportMealUserID = table.Column<int>(nullable: false)
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
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 473, DateTimeKind.Local).AddTicks(6183), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(1816), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(7370), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8120), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8153), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8165), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8177), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8191), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8201), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8213), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8223), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8235), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8246), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8257), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8268), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8279), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8324), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8335), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8346), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8357), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8368), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8379), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8389), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8401), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8412), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8422), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8433), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8443), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8454), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8489), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8502), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8513), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8524), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8534), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8545), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8557), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8568), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8579), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8589), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8600), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8610), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8621), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8656), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8667), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8678), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8689), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8700), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8710), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8721), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8731), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8742), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8753), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8763), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8774), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8784), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8795), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8805), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8842), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8853), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8863), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8874), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8885), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8895), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8906), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8916), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8927), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8938), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8961), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8972), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9041), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9052), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9062), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9073), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9084), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9094), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9104), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9115), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9126), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9136), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9147), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9158), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9168), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9192), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9229), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9586), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9662), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9789), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9812), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9828), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9840), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9855), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9868), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9965), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9978), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9990), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(4), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(15), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3262), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3283), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3295), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3307), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3379), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6067), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6591), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6600), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6602), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6604), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6606), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6608), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(4139), new DateTime(2020, 12, 13, 17, 44, 4, 476, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(370), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(430), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(438), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(444), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(450), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(455), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(462), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(467), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(473), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(478), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(484), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(489), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(496), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(501), new DateTime(2020, 12, 13, 17, 44, 4, 477, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(4503), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(5350), new DateTime(2020, 12, 13, 17, 44, 4, 475, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.CreateIndex(
                name: "IX_HW_ReportMealInfo_ReportMealUserID",
                table: "HW_ReportMealInfo",
                column: "ReportMealUserID");
        }
    }
}
