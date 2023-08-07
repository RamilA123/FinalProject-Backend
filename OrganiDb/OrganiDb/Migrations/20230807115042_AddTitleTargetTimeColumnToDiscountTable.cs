using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class AddTitleTargetTimeColumnToDiscountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TargetTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Title",
                table: "Discounts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 50, 42, 414, DateTimeKind.Local).AddTicks(5185));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetTime",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Discounts");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 7, 15, 7, 56, 67, DateTimeKind.Local).AddTicks(6752));
        }
    }
}
