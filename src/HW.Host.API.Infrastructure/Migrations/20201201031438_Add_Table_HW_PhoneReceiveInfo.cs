using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_HW_PhoneReceiveInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HW_PhoneReceiveInfo",
                columns: table => new
                {
                    ReceiveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReceiveTime = table.Column<DateTime>(nullable: false),
                    ReceiveUserID = table.Column<int>(nullable: false),
                    ReceivePhoneModelID = table.Column<int>(nullable: false),
                    ReceiveIsReturn = table.Column<int>(nullable: false),
                    ReceiveReturnTime = table.Column<DateTime>(nullable: false),
                    ReceiveRemarks = table.Column<string>(nullable: true),
                    ReturnRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_PhoneReceiveInfo", x => x.ReceiveID);
                    table.ForeignKey(
                        name: "FK_HW_PhoneReceiveInfo_HW_PhoneModelInfo_ReceivePhoneModelID",
                        column: x => x.ReceivePhoneModelID,
                        principalTable: "HW_PhoneModelInfo",
                        principalColumn: "PhoneID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HW_PhoneReceiveInfo_HW_Users_ReceiveUserID",
                        column: x => x.ReceiveUserID,
                        principalTable: "HW_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "HW_PhoneReceiveInfo",
                columns: new[] { "ReceiveID", "ReceiveIsReturn", "ReceivePhoneModelID", "ReceiveRemarks", "ReceiveReturnTime", "ReceiveTime", "ReceiveUserID", "ReturnRemarks" },
                values: new object[,]
                {
                    { 1, 0, 1, "Hua.MrF测试~", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(6270), 2, null },
                    { 3, 0, 3, "Hua.MrF测试~", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(7969), 2, null },
                    { 2, 0, 2, "Hua.MrF测试~", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 1, 11, 14, 38, 601, DateTimeKind.Local).AddTicks(7954), 2, null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_HW_PhoneReceiveInfo_ReceivePhoneModelID",
                table: "HW_PhoneReceiveInfo",
                column: "ReceivePhoneModelID");

            migrationBuilder.CreateIndex(
                name: "IX_HW_PhoneReceiveInfo_ReceiveUserID",
                table: "HW_PhoneReceiveInfo",
                column: "ReceiveUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HW_PhoneReceiveInfo");

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 19, DateTimeKind.Local).AddTicks(4895), new DateTime(2020, 12, 1, 11, 14, 14, 20, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 20, DateTimeKind.Local).AddTicks(9542), new DateTime(2020, 12, 1, 11, 14, 14, 20, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5881), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(6950), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7026), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7040), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7052), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7068), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7080), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7092), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7103), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7116), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7129), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7141), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7153), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7165), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7177), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7189), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7230), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7244), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7256), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7268), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7280), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7291), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7304), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7315), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7327), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7339), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7351), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7363), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7374), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7413), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7425), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7437), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7448), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7461), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7473), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7485), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7497), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7509), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7520), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7532), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7544), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7556), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7621), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7634), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7646), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7657), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7669), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7681), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7693), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7704), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7716), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7728), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7739), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7751), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7763), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7775), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7848), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7862), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7874), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7886), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7897), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7909), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7921), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7933), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7945), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7958), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7970), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7981), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8019), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8032), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8063), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8075), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8087), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8099), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8110), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8122), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8134), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8146), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8157), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8181), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8273), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8308), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8320), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8331), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8342), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8353), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8364), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8375), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8386), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8398), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8408), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8420), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8431), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8442), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8453), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8464), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8500), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8511), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8522), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(4207), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5042), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5052), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5054), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5056), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5058), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5059), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(2024), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(3349), new DateTime(2020, 12, 1, 11, 14, 14, 21, DateTimeKind.Local).AddTicks(3351) });
        }
    }
}