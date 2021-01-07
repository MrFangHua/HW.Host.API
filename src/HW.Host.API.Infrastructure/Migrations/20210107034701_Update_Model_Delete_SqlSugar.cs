using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_Model_Delete_SqlSugar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg1.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6018), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg2.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6819), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg3.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6848), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg4.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6861), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg5.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6872), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg6.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6886), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg7.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6897), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg8.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6908), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg9.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6919), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg10.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6930), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg11.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6941), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg12.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg13.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6962), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg14.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6973), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg15.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6983), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg16.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7032), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg17.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7042), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg18.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7054), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg19.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7065), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg20.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7076), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg21.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7087), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg22.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7097), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg23.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7108), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg24.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7118), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg25.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7129), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg26.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7140), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg27.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7150), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg28.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7161), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg29.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7197), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg30.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7208), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg31.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7218), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg32.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7228), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg33.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7239), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg34.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7250), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg35.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7261), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg36.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7272), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg37.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7282), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg38.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7293), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg39.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7303), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg40.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7314), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg41.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7324), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg42.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7361), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg43.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7372), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg44.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7383), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg45.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7393), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg46.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7404), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg47.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7414), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg48.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7425), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg49.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7435), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg50.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7446), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg51.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7456), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg52.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7467), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg53.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7478), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg54.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7488), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg55.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7499), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg56.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7533), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg57.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7544), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg58.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7555), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg59.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7565), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg60.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7576), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg61.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7586), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg62.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7597), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg63.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7607), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg64.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7618), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg65.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7628), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg66.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7652), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg67.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7663), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg68.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7698), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg69.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7710), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg70.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7721), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg71.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7732), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg72.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7742), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg73.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7753), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg74.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7763), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg75.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7774), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg76.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7785), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg77.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7796), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg78.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7806), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg79.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7817), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg80.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7828), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg81.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7838), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg82.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7874), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg83.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7886), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg84.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7897), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg85.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7907), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg86.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7918), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg87.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7929), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg88.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7939), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg89.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7950), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg90.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7961), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg91.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7971), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg92.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7982), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg93.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7993), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg94.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8003), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg95.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8014), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg96.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8080), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg97.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8093), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg98.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8104), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg99.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8115), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg100.jpg", new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8145), new DateTime(2020, 12, 13, 17, 45, 6, 224, DateTimeKind.Local).AddTicks(8145) });

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
        }
    }
}
