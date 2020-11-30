using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW.Host.API.Infrastructure.Migrations.FangHuaHostLogDb
{
    public partial class Update_TableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_Log");

            migrationBuilder.DropTable(
                name: "FH_SqlLog");

            migrationBuilder.CreateTable(
                name: "HW_Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Thread = table.Column<int>(nullable: false),
                    Level = table.Column<string>(maxLength: 50, nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 5000, nullable: true),
                    Exception = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HW_SqlLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Sql = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HW_SqlLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HW_Log");

            migrationBuilder.DropTable(
                name: "HW_SqlLog");

            migrationBuilder.CreateTable(
                name: "FH_Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Exception = table.Column<string>(maxLength: 5000, nullable: true),
                    Level = table.Column<string>(maxLength: 50, nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 5000, nullable: true),
                    Thread = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FH_SqlLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Sql = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_SqlLog", x => x.Id);
                });
        }
    }
}
