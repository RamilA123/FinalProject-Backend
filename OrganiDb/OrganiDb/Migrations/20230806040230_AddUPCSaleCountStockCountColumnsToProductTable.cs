using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class AddUPCSaleCountStockCountColumnsToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaleCount",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockCount",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UPC",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 8, 2, 29, 830, DateTimeKind.Local).AddTicks(6368));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleCount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockCount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UPC",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 6, 7, 56, 26, 128, DateTimeKind.Local).AddTicks(250));
        }
    }
}
