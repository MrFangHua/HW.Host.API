using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Delete_Table_FH_GuidePagesMenuInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_GuidePagesMenuInfo");

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 870, DateTimeKind.Local).AddTicks(8876), new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(5117), new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(921), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1701), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1735), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1752), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1766), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1840), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1855), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1869), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1884), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1898), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1911), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1923), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1935), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1946), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1957), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1968), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1980), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2032), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2044), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2055), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2067), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2079), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2101), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2113), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2135), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2147), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2159), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2170), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2181), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2236), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2249), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2261), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2272), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2283), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2294), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2306), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2317), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2328), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2339), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2351), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2362), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2417), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2439), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2450), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2461), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2472), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2484), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2495), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2506), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2517), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2528), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2539), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2550), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2591), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2602), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2613), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2624), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2635), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2646), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2657), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2669), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2681), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2692), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2703), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2714), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2762), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2786), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2797), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2808), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2820), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2831), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2842), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2853), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2865), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2877), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2888), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2900), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2911), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2987), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3001), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3023), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3035), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3046), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3057), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3068), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3080), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3091), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3102), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3113), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3125), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3136), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3182), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3193), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(9352), new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(96), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(106), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(108), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(111), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(113), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(115), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(7500), new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(8471), new DateTime(2020, 11, 30, 11, 46, 1, 872, DateTimeKind.Local).AddTicks(8473) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FH_GuidePagesMenuInfo",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    MenuName = table.Column<string>(nullable: false),
                    MenuOrder = table.Column<int>(nullable: false),
                    MenuUrl = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_GuidePagesMenuInfo", x => x.MenuID);
                });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 919, DateTimeKind.Local).AddTicks(886), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(5985), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3651), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4342), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4373), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4436), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4450), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4465), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4477), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4489), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4513), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4525), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4537), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4549), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4561), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4572), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4584), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4595), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4650), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4662), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4673), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4685), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4696), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4708), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4720), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4731), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4743), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4754), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4766), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4777), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4789), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4861), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4873), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4884), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4897), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4908), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4919), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4931), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4942), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4953), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4965), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4976), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4987), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4998), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5037), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5049), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5060), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5072), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5083), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5094), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5106), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5117), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5128), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5140), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5151), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5162), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5174), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5219), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5232), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5243), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5255), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5266), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5277), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5289), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5300), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5312), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5324), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5347), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5385), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5411), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5423), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5434), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5446), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5457), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5468), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5480), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5491), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5503), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5514), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5525), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5537), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5548), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5591), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5602), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5614), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5625), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5636), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5647), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5659), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5670), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5682), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5693), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5704), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5715), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5727), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5764), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5777), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5788), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5800), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5831), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2982), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2991), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2993), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2994), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2996), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2999), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.InsertData(
                table: "FH_GuidePagesMenuInfo",
                columns: new[] { "MenuID", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "MenuName", "MenuOrder", "MenuUrl", "ParentId" },
                values: new object[,]
                {
                    { 4, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1859), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1860), "微信", 4, "https://fanghua.host/assets/images/weixin.jpg", 0 },
                    { 3, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1857), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1858), "QQ", 3, "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes", 0 },
                    { 2, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1841), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1842), "首页", 2, "https://home.fanghua.host", 0 },
                    { 6, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1864), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1865), "休闲小游戏", 6, "https://game.fanghua.host", 0 },
                    { 5, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1861), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1863), "实用小工具", 5, "https://tool.fanghua.host", 0 },
                    { 1, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(896), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(898), "Mr.Fang♥Mrs.Zhou", 1, "https://love.fanghua.host", 0 }
                });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(9141), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(111), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(114) });
        }
    }
}