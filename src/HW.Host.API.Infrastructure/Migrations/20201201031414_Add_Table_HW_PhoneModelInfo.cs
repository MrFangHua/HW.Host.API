using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace HW.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_HW_PhoneModelInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HW_PhoneModelInfo",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneName = table.Column<string>(nullable: false),
                    PhoneRAM = table.Column<string>(nullable: false),
                    PhonePrice = table.Column<int>(nullable: false),
                    PhoneFineness = table.Column<string>(nullable: false),
                    PhoneColour = table.Column<string>(nullable: false),
                    PhoneCode = table.Column<string>(nullable: false),
                    PhoneLeaseTime = table.Column<DateTime>(nullable: false),
                    PhoneIsReturn = table.Column<int>(nullable: false),
                    PhoneReturnTime = table.Column<DateTime>(nullable: false),
                    PhoneRemarks = table.Column<string>(nullable: true),
                    PhoneReturnRemarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_PhoneModelInfo", x => x.PhoneID);
                });

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

            migrationBuilder.InsertData(
                table: "HW_PhoneModelInfo",
                columns: new[] { "PhoneID", "PhoneCode", "PhoneColour", "PhoneFineness", "PhoneIsReturn", "PhoneLeaseTime", "PhoneName", "PhonePrice", "PhoneRAM", "PhoneRemarks", "PhoneReturnRemarks", "PhoneReturnTime" },
                values: new object[,]
                {
                    { 9, "862474042226765", "黑", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为P30", 1800, "8+64", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "860133058133412", "黑", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为Nova7SE5G", 2100, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "99001332374714", "蓝", "9", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "小米9", 1150, "6+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "864928040295179", "蓝", "95", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为Nova5i", 1200, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "99001343870346", "黑", "95", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "小米9", 1500, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "861594045284619", "粉", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为P20", 1100, "6+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "868577030922627", "黑", "95", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为P20Pro", 1050, "6+64", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "99001302146726", "白", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "红米K20Pro", 1450, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "868034039428685", "黑", "9", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为Mate10 Pro", 950, "6+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "866216030724606", "粉", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为Mate10 Pro", 1000, "6+64", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "861189053704549", "蓝", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为畅享20Pro 5G", 1600, "6+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "860450040094555", "黑", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为畅享Z 5G", 1250, "6+64", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "862754045574919", "红", "95", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VIVO X23", 1000, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "99001583306158", "白", "靓", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "小米10青春版", 1700, "8+128", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "865043042963151", "蓝", "9", 0, new DateTime(2020, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "华为Mate20", 1200, "6+64", null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HW_PhoneModelInfo");

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
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(5468), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6670), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6701), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6764), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6777), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6792), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6803), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 8,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6816), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 9,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6827), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 10,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6840), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 11,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6853), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 12,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6865), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 13,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6876), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 14,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6888), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 15,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6900), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 16,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6911), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 17,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6952), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 18,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6967), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 19,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6979), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 20,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6991), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 21,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7002), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 22,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7014), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 23,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7026), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 24,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7038), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 25,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7049), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 26,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7061), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 27,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7072), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 28,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7084), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 29,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7096), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 30,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7107), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 31,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7233), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 32,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7246), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 33,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7257), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 34,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7270), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 35,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7282), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 36,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7293), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 37,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7305), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 38,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7316), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 39,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7328), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 40,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7340), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 41,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7351), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 42,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7363), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 43,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7374), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 44,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7416), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 45,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7428), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 46,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7439), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 47,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7450), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 48,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7462), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 49,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7473), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 50,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7484), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 51,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7496), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 52,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7508), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 53,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7519), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 54,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7530), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 55,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7542), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 56,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7554), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 57,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7565), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 58,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7626), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 59,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7638), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 60,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7649), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 61,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7660), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 62,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7672), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 63,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7683), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 64,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7694), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 65,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7706), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 66,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7718), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 67,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7730), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 68,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7741), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 69,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7752), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 70,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7794), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 71,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7807), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 72,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7833), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 73,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7845), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 74,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7856), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 75,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7868), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 76,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7879), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 77,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7890), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 78,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7902), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 79,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7913), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 80,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7924), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 81,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 82,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7947), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 83,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7959), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 84,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(7999), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 85,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8012), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 86,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8023), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 87,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8035), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 88,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8047), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 89,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8058), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 90,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8069), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 91,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8081), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 92,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8092), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 93,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8103), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 94,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8114), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 95,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8126), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 96,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8137), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 97,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8149), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 98,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8190), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 99,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8202), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "HW_BackGroundImageInfo",
                keyColumn: "BGId",
                keyValue: 100,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8214), new DateTime(2020, 11, 30, 19, 10, 43, 294, DateTimeKind.Local).AddTicks(8214) });

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
    }
}