using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  public partial class MockUsers : Migration
  {
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.InsertData(
        table: "Users",
        columns: new[]
        {
          "Id",
          "CreatedAt",
          "FirstName",
          "LastName"
        },
        values: new object[]
        {
          1,
          new DateTime(
            2022,
            10,
            6,
            11,
            47,
            55,
            310,
            DateTimeKind.Local
          ).AddTicks(3260),
          "Tester",
          "Testerov"
        }
      );

      migrationBuilder.InsertData(
        table: "Users",
        columns: new[]
        {
          "Id",
          "CreatedAt",
          "FirstName",
          "LastName"
        },
        values: new object[]
        {
          2,
          new DateTime(
            2022,
            10,
            6,
            11,
            47,
            55,
            310,
            DateTimeKind.Local
          ).AddTicks(3320),
          "Mike",
          "Tyson"
        }
      );

      migrationBuilder.InsertData(
        table: "Users",
        columns: new[]
        {
          "Id",
          "CreatedAt",
          "FirstName",
          "LastName"
        },
        values: new object[]
        {
          3,
          new DateTime(
            2022,
            10,
            6,
            11,
            47,
            55,
            310,
            DateTimeKind.Local
          ).AddTicks(3320),
          "Red",
          "Sky"
        }
      );
    }

    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DeleteData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1
      );

      migrationBuilder.DeleteData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2
      );

      migrationBuilder.DeleteData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3
      );
    }
  }
}
