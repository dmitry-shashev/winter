using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  public partial class UserPasswordRole : Migration
  {
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder
        .AddColumn<string>(
          name: "Password",
          table: "Users",
          type: "longtext",
          nullable: false
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder
        .AddColumn<string>(
          name: "Role",
          table: "Users",
          type: "longtext",
          nullable: false
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        columns: new[] { "CreatedAt", "Password", "Role" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            25,
            22,
            37,
            55,
            682,
            DateTimeKind.Local
          ).AddTicks(1990),
          "123456",
          "Admin"
        }
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        columns: new[] { "CreatedAt", "Password", "Role" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            25,
            22,
            37,
            55,
            682,
            DateTimeKind.Local
          ).AddTicks(2040),
          "123456",
          ""
        }
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        columns: new[] { "CreatedAt", "Password", "Role" },
        values: new object[]
        {
          new DateTime(
            2022,
            10,
            25,
            22,
            37,
            55,
            682,
            DateTimeKind.Local
          ).AddTicks(2050),
          "123456",
          "Owner"
        }
      );
    }

    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DropColumn(
        name: "Password",
        table: "Users"
      );

      migrationBuilder.DropColumn(
        name: "Role",
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
          18,
          20,
          43,
          8,
          89,
          DateTimeKind.Local
        ).AddTicks(8490)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          18,
          20,
          43,
          8,
          89,
          DateTimeKind.Local
        ).AddTicks(8530)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          18,
          20,
          43,
          8,
          89,
          DateTimeKind.Local
        ).AddTicks(8540)
      );
    }
  }
}
