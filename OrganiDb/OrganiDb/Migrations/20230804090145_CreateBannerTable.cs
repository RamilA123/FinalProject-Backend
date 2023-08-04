using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganiDb.Migrations
{
    public partial class CreateBannerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "CreatedDate", "Image", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6926), "background2.png", false },
                    { 2, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6936), "banner1.png", false },
                    { 3, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6937), "banner2.png", false },
                    { 4, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6937), "banner4.png", false },
                    { 5, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6938), "banner5.png", false },
                    { 6, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6938), "banner3.jpg", false },
                    { 7, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6939), "banner6.jpg", false },
                    { 8, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6939), "banner7.webp", false },
                    { 9, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6940), "banner8.png", false },
                    { 10, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6941), "banner9.jpg", false },
                    { 11, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6941), "banner11.png", false },
                    { 12, new DateTime(2023, 8, 4, 13, 1, 44, 853, DateTimeKind.Local).AddTicks(6942), "banner10.webp", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");
        }
    }
}
