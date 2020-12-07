using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_SqlDataBaseName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 911, DateTimeKind.Local).AddTicks(4060), new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(9314), new DateTime(2020, 11, 30, 16, 16, 35, 912, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg1.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(5572), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg2.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6865), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg3.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6897), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg4.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6911), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg5.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6922), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg6.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6935), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg7.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6946), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg8.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6956), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg9.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6967), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg10.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6978), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg11.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6990), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg12.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7000), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg13.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg14.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7059), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg15.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg16.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg17.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7091), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg18.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7103), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg19.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7113), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg20.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7124), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg21.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7135), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg22.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7145), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg23.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7156), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg24.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7166), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg25.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7177), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg26.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7187), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg27.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7198), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg28.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7237), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg29.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7248), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg30.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7258), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg31.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7269), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg32.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7280), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg33.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7290), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg34.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7302), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg35.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7313), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg36.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7323), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg37.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7333), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg38.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7344), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg39.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7354), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg40.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7365), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg41.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7375), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg42.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7478), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg43.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7489), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg44.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7500), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg45.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7510), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg46.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7521), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg47.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7531), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg48.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7541), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg49.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7552), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg50.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7563), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg51.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7573), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg52.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7584), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg53.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7594), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg54.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7604), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg55.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7615), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg56.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7625), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg57.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7666), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg58.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7677), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg59.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7687), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg60.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7698), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg61.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7708), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg62.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7718), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg63.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7728), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg64.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7739), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg65.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7749), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg66.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7761), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg67.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7772), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg68.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7782), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg69.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7792), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg70.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7828), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg71.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7840), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg72.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7866), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg73.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7877), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg74.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7887), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg75.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7898), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg76.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7908), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg77.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7919), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg78.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7929), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg79.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7940), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg80.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7950), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg81.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7960), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg82.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7971), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg83.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7981), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg84.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7992), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg85.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8002), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg86.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8044), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg87.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8054), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg88.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8065), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg89.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8075), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg90.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8086), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg91.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8096), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg92.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8107), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg93.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8117), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg94.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8128), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg95.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8138), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg96.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg97.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8159), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg98.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg99.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8180), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg100.jpg", new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8190), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3951), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4763), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4773), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4774), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4776), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4777), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4779), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(1833), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3130), new DateTime(2020, 11, 30, 16, 16, 35, 913, DateTimeKind.Local).AddTicks(3132) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg1.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(921), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg2.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1701), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg3.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1735), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg4.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1752), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg5.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1766), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg6.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1840), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg7.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1855), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg8.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1869), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg9.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1884), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg10.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1898), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg11.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1911), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg12.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1923), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg13.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1935), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg14.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1946), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg15.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1957), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg16.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1968), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg17.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1980), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg18.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1992), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg19.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2032), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg20.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2044), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg21.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2055), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg22.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2067), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg23.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2079), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg24.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2090), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg25.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2101), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg26.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2113), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg27.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg28.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2135), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg29.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2147), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg30.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2159), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg31.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2170), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg32.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2181), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg33.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2236), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg34.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2249), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg35.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2261), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg36.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2272), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg37.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2283), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg38.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2294), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg39.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2306), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg40.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2317), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg41.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2328), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg42.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2339), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg43.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2351), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg44.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2362), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg45.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2404), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg46.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2417), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg47.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg48.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2439), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg49.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2450), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg50.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2461), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg51.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2472), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg52.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2484), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg53.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2495), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg54.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2506), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg55.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2517), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg56.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2528), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg57.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2539), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg58.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2550), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg59.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2591), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg60.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2602), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg61.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2613), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg62.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2624), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg63.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2635), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg64.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2646), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg65.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2657), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg66.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2669), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg67.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2681), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg68.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2692), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg69.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2703), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg70.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2714), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg71.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2762), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg72.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2786), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg73.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2797), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg74.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2808), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg75.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2820), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg76.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2831), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg77.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2842), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg78.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2853), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg79.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2865), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg80.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2877), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg81.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2888), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg82.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2900), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg83.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2911), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg84.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2987), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg85.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3001), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg86.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3012), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg87.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3023), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg88.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3035), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg89.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3046), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg90.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3057), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg91.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3068), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg92.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3080), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg93.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3091), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg94.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3102), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg95.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3113), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg96.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3125), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg97.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3136), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg98.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3182), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg99.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3193), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "FH_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host/assets/images/backGround/bg100.jpg", new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3205), new DateTime(2020, 11, 30, 11, 46, 1, 873, DateTimeKind.Local).AddTicks(3205) });

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
    }
}