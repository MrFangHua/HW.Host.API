using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_Table_HW_BackGroundImageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 292, DateTimeKind.Local).AddTicks(4168), new DateTime(2020, 11, 30, 19, 10, 43, 293, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 293, DateTimeKind.Local).AddTicks(8208), new DateTime(2020, 11, 30, 19, 10, 43, 293, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg1.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(5468), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg2.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6670), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg3.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6701), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg4.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6764), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg5.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6777), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg6.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6792), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg7.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6803), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg8.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6816), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg9.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6827), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg10.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6840), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg11.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6853), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg12.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6865), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg13.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6876), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg14.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6888), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg15.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6900), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg16.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6911), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg17.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg18.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6967), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg19.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6979), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg20.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6991), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg21.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7002), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg22.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7014), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg23.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7026), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg24.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7038), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg25.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7049), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg26.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7061), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg27.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7072), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg28.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7084), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg29.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7096), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg30.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7107), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg31.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7233), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg32.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7246), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg33.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7257), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg34.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7270), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg35.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7282), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg36.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7293), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg37.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7305), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg38.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7316), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg39.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7328), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg40.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7340), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg41.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7351), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg42.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7363), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg43.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7374), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg44.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7416), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg45.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7428), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg46.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7439), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg47.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7450), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg48.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7462), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg49.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7473), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg50.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7484), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg51.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7496), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg52.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7508), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg53.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7519), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg54.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7530), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg55.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7542), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg56.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7554), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg57.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7565), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg58.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7626), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg59.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7638), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg60.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7649), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg61.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg62.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7672), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg63.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7683), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg64.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg65.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7706), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg66.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7718), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg67.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7730), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg68.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7741), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg69.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7752), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg70.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg71.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7807), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg72.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7833), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg73.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg74.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7856), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg75.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7868), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg76.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7879), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg77.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7890), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg78.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7902), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg79.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg80.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7924), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg81.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg82.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7947), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg83.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7959), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg84.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7999), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg85.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8012), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg86.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8023), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg87.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8035), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg88.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8047), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg89.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8058), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg90.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8069), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg91.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8081), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg92.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8092), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg93.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8103), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg94.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8114), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg95.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8126), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg96.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8137), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg97.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg98.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8190), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg99.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8202), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "http://192.168.6.88:8888/assets/images/backGround/bg100.jpg", new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8214), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(3578), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4560), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4570), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4572), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4574), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4576), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4578), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(539), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(2584), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(2588) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 163, DateTimeKind.Local).AddTicks(5354), new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(2751), new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg1.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(6007), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg2.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7399), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg3.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7436), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg4.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7452), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg5.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7464), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg6.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7479), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg7.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7490), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg8.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7502), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg9.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7517), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg10.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7529), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg11.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7542), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg12.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7553), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg13.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7565), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg14.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7577), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg15.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7806), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg16.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7822), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg17.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7835), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg18.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7848), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg19.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7860), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg20.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7872), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg21.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7884), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg22.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7897), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg23.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7909), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg24.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7921), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg25.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7933), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg26.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7946), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg27.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7958), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg28.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7970), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg29.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7983), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg30.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8115), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg31.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8129), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg32.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8142), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg33.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8153), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg34.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8166), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg35.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8178), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg36.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8189), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg37.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8201), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg38.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8212), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg39.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8223), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg40.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8234), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg41.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8246), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg42.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8258), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg43.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8269), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg44.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8308), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg45.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8320), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg46.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8332), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg47.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8343), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg48.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8354), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg49.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8366), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg50.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8377), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg51.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8388), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg52.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8399), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg53.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8413), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg54.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8424), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg55.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8436), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg56.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8447), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg57.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8458), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg58.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8469), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg59.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8482), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg60.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8522), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg61.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8534), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg62.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8545), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg63.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8556), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg64.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8567), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg65.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8578), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg66.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8590), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg67.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8602), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg68.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8613), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg69.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8624), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg70.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8635), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg71.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8646), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg72.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8675), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg73.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8716), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg74.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8727), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg75.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8738), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg76.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8749), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg77.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8760), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg78.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8772), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg79.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8783), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg80.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8794), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg81.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8805), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg82.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8816), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg83.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8827), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg84.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8838), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg85.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8850), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg86.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8860), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg87.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8872), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg88.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9092), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg89.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9107), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg90.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9119), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg91.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9132), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg92.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9143), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg93.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9155), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg94.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9166), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg95.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9178), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg96.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9191), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg97.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9202), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg98.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9214), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg99.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9226), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "BGUrl", "CreateTime", "LastUpdateTime" },
                values: new object[] { "/assets/images/backGround/bg100.jpg", new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9238), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(2700), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4676), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4689), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4691), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4693), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4695), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4697), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(7241), new DateTime(2020, 11, 30, 16, 49, 52, 165, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(1518), new DateTime(2020, 11, 30, 16, 49, 52, 166, DateTimeKind.Local).AddTicks(1522) });
        }
    }
}