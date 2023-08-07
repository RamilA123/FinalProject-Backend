using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class RemoveTargetTimeColumnFromDiscountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetTime",
                table: "Discounts");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 17, 16, 35, 919, DateTimeKind.Local).AddTicks(1925));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TargetTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 56, 57, 310, DateTimeKind.Local).AddTicks(8190));
        }
    }
}
