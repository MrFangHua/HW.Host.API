using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Update_Table_Id_Other : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateAdminID",
                table: "HW_PhoneReceiveInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "HW_PhoneReceiveInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateUserID",
                table: "HW_PhoneReceiveInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeleteTimeAndRemark",
                table: "HW_PhoneReceiveInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "HW_PhoneReceiveInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateTime",
                table: "HW_PhoneReceiveInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateAdminID",
                table: "HW_PhoneModelInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "HW_PhoneModelInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreateUserID",
                table: "HW_PhoneModelInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeleteTimeAndRemark",
                table: "HW_PhoneModelInfo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "HW_PhoneModelInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateTime",
                table: "HW_PhoneModelInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 206, DateTimeKind.Local).AddTicks(8685), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "HW_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(2188), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(7732), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8503), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8533), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8548), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8561), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8576), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8590), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8601), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8612), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8625), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8637), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8648), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8725), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8737), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8748), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8759), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8771), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8783), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8794), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8806), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8817), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8828), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8839), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8850), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8861), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8898), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8910), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8921), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8932), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8944), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8954), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8965), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8977), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8989), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9000), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9011), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9022), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9033), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9069), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9081), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9092), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9103), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9114), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9125), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9136), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9147), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9158), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9169), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9180), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9192), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9202), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9213), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9250), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9262), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9273), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9284), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9295), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9306), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9317), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9328), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9339), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9350), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9361), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9373), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9383), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9422), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9433), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9457), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9469), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9480), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9491), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9502), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9513), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9524), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9536), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9547), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9558), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9569), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9580), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9618), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9629), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9640), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9651), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9662), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9673), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9684), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9696), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9706), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9717), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9740), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9751), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9762), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9799), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9810), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9821), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9832), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9843), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9855), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9888), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6279), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6791), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6801), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6802), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6803), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6805), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "HW_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6807), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(368), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5399), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5449), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5457), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5464), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5469), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5475), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5480), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5486), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5491), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5497), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5503), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5508), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5514), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneModelInfo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5519), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime", "ReceiveTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(6486), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(6487), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime", "ReceiveTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7687), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7688), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "HW_PhoneReceiveInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime", "ReceiveTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7740), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7740), new DateTime(2020, 12, 7, 14, 25, 2, 209, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(4570), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "HW_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(5545), new DateTime(2020, 12, 7, 14, 25, 2, 208, DateTimeKind.Local).AddTicks(5547) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAdminID",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "CreateUserID",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "DeleteTimeAndRemark",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "LastUpdateTime",
                table: "HW_PhoneReceiveInfo");

            migrationBuilder.DropColumn(
                name: "CreateAdminID",
                table: "HW_PhoneModelInfo");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "HW_PhoneModelInfo");

            migrationBuilder.DropColumn(
                name: "CreateUserID",
                table: "HW_PhoneModelInfo");

            migrationBuilder.DropColumn(
                name: "DeleteTimeAndRemark",
                table: "HW_PhoneModelInfo");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HW_PhoneModelInfo");

            migrationBuilder.DropColumn(
                name: "LastUpdateTime",
                table: "HW_PhoneModelInfo");

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
    }
}