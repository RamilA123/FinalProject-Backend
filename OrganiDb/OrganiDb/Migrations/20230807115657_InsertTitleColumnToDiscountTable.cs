using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class InsertTitleColumnToDiscountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Discounts",
                type: "nvarchar(max)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Discounts");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 55, 3, 505, DateTimeKind.Local).AddTicks(8815));
        }
    }
}
