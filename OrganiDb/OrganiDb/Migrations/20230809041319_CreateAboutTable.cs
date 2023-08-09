using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class CreateAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Assistances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 9, 8, 13, 18, 911, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.CreateIndex(
                name: "IX_Assistances_AboutId",
                table: "Assistances",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assistances_Abouts_AboutId",
                table: "Assistances",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assistances_Abouts_AboutId",
                table: "Assistances");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Assistances_AboutId",
                table: "Assistances");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Assistances");

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 9, 50, 44, 312, DateTimeKind.Local).AddTicks(6408));
        }
    }
}
