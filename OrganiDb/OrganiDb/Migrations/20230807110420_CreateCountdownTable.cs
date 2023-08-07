using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class CreateCountdownTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countdowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countdowns", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 4, 20, 47, DateTimeKind.Local).AddTicks(6247));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countdowns");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 39, 26, 904, DateTimeKind.Local).AddTicks(2262));
        }
    }
}
