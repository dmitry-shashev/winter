using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  public partial class UsersPhone : Migration
  {
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder
        .AddColumn<string>(
          name: "Phone",
          table: "Users",
          type: "longtext",
          nullable: false
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        columns: new[] { "CreatedAt", "Phone" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            9,
            16,
            5,
            4,
            206,
            DateTimeKind.Local
          ).AddTicks(6630),
          "12-12-12"
        }
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        columns: new[] { "CreatedAt", "Phone" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            9,
            16,
            5,
            4,
            206,
            DateTimeKind.Local
          ).AddTicks(6680),
          "13-99-14"
        }
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        columns: new[] { "CreatedAt", "Phone" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            9,
            16,
            5,
            4,
            206,
            DateTimeKind.Local
          ).AddTicks(6680),
          "33-33-32"
        }
      );
    }

    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DropColumn(
        name: "Phone",
        table: "Users"
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          6,
          18,
          54,
          56,
          580,
          DateTimeKind.Local
        ).AddTicks(8130)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          6,
          18,
          54,
          56,
          580,
          DateTimeKind.Local
        ).AddTicks(8170)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          6,
          18,
          54,
          56,
          580,
          DateTimeKind.Local
        ).AddTicks(8170)
      );
    }
  }
}
