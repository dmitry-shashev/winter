using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
    public partial class NewField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2022, 10, 6, 18, 54, 56, 580, DateTimeKind.Local).AddTicks(8130), "tt1@tt.tt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2022, 10, 6, 18, 54, 56, 580, DateTimeKind.Local).AddTicks(8170), "tt2@tt.tt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email" },
                values: new object[] { new DateTime(2022, 10, 6, 18, 54, 56, 580, DateTimeKind.Local).AddTicks(8170), "tt3@tt.tt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 6, 11, 47, 55, 310, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 6, 11, 47, 55, 310, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 10, 6, 11, 47, 55, 310, DateTimeKind.Local).AddTicks(3320));
        }
    }
}
