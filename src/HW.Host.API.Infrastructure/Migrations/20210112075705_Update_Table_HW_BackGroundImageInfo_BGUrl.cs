using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_Table_HW_BackGroundImageInfo_BGUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 148, DateTimeKind.Local).AddTicks(3564), new DateTime(2021, 1, 12, 15, 57, 5, 149, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 149, DateTimeKind.Local).AddTicks(6978), new DateTime(2021, 1, 12, 15, 57, 5, 149, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg1.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1876), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg2.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2678), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg3.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2707), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg4.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2719), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg5.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2731), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg6.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2744), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg7.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2755), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg8.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2766), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg9.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2777), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg10.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2789), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg11.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2801), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg12.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2813), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg13.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2824), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg14.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2835), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg15.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2882), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg16.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2894), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg17.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2904), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg18.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2917), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg19.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2927), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg20.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2938), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg21.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg22.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg23.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2971), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg24.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg25.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2993), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg26.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3004), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg27.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3015), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg28.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3051), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg29.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg30.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3073), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg31.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3084), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg32.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3095), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg33.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3105), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg34.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3117), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg35.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3128), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg36.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3139), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg37.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3149), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg38.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3160), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg39.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3171), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg40.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3181), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg41.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3217), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg42.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3228), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg43.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3239), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg44.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3249), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg45.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3260), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg46.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3271), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg47.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3282), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg48.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3292), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg49.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3303), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg50.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3314), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg51.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3325), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg52.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3335), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg53.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3346), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg54.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3357), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg55.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3413), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg56.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3424), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg57.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3434), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg58.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg59.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3456), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg60.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3467), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg61.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3478), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg62.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3489), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg63.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3500), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg64.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3510), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg65.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3521), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg66.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3544), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg67.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3610), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg68.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3621), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg69.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3632), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg70.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3643), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg71.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3653), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg72.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3664), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg73.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3675), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg74.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3686), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg75.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg76.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3707), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg77.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3718), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg78.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3729), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg79.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3740), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg80.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3775), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg81.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3786), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg82.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3796), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg83.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3807), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg84.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3818), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg85.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3829), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg86.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3839), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg87.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3850), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg88.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3861), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg89.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3872), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg90.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3883), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg91.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3894), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg92.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3904), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg93.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3915), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg94.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3952), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg95.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3963), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg96.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3974), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg97.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3985), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg98.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3996), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg99.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4007), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "https://objstorage.fanghua.host//assets/images/backGround/bg100.jpg", new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4038), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(695), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1228), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1238), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1240), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1242), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1244), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1245), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4473), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9446), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9499), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9508), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9514), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9519), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9526), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9629), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9634), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9640), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9646), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9652), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9657), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9663), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9669), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 149, DateTimeKind.Local).AddTicks(8942), new DateTime(2021, 1, 12, 15, 57, 5, 149, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(53), new DateTime(2021, 1, 12, 15, 57, 5, 150, DateTimeKind.Local).AddTicks(55) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 189, DateTimeKind.Local).AddTicks(5222), new DateTime(2021, 1, 7, 11, 47, 1, 190, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(821), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg1.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(7324), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg2.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8492), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg3.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8525), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg4.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8539), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg5.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8601), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg6.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8619), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg7.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8632), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg8.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8644), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg9.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8656), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg10.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8669), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg11.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8681), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg12.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8694), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg13.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8705), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg14.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8717), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg15.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8729), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg16.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8741), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg17.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8753), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg18.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8793), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg19.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8806), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg20.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8817), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg21.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8829), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg22.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8841), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg23.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8852), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg24.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg25.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8876), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg26.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8887), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg27.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8899), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg28.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8910), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg29.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8922), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg30.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8933), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg31.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8945), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg32.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9015), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg33.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9027), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg34.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9040), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg35.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9051), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg36.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9063), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg37.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9074), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg38.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9086), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg39.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9098), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg40.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9110), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg41.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9121), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg42.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9133), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg43.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9144), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg44.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9156), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg45.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9195), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg46.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9207), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg47.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9219), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg48.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9231), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg49.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9242), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg50.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9254), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg51.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9265), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg52.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9277), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg53.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9289), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg54.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9301), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg55.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9312), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg56.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9324), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg57.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9335), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg58.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9375), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg59.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9387), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg60.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9399), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg61.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9410), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg62.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9422), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg63.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9433), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg64.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9445), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg65.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9456), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg66.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9482), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg67.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9494), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg68.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9506), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg69.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9517), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg70.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9577), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg71.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9589), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg72.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9600), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg73.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9612), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg74.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9624), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg75.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9635), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg76.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9647), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg77.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9659), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg78.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9670), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg79.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9682), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg80.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9693), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg81.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9705), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg82.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9717), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg83.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9728), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg84.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9784), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg85.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9796), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg86.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9807), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg87.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9819), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg88.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9831), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg89.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9842), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg90.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9854), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg91.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9866), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg92.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9877), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg93.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9888), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg94.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9900), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg95.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9912), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg96.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9923), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg97.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9959), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg98.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9972), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg99.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9983), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://objstorage.fanghua.host//assets/images/backGround/bg100.jpg", new DateTime(2021, 1, 7, 11, 47, 1, 192, DateTimeKind.Local).AddTicks(12), new DateTime(2021, 1, 7, 11, 47, 1, 192, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(5599), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6475), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6486), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6488), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6489), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6491), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6493), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 192, DateTimeKind.Local).AddTicks(640), new DateTime(2021, 1, 7, 11, 47, 1, 192, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5259), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5311), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5318), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5324), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5329), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5335), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5340), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5345), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5350), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5356), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5361), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5366), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5372), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5377), new DateTime(2021, 1, 7, 11, 47, 1, 194, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(3354), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(4747), new DateTime(2021, 1, 7, 11, 47, 1, 191, DateTimeKind.Local).AddTicks(4749) });
        }
    }
}
