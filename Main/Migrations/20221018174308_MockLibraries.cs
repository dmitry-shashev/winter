using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  public partial class MockLibraries : Migration
  {
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder
        .CreateTable(
          name: "Libraries",
          columns: table =>
            new
            {
              Id = table
                .Column<int>(type: "int", nullable: false)
                .Annotation(
                  "MySql:ValueGenerationStrategy",
                  MySqlValueGenerationStrategy.IdentityColumn
                ),
              Address = table
                .Column<string>(
                  type: "longtext",
                  nullable: false
                )
                .Annotation("MySql:CharSet", "utf8mb4")
            },
          constraints: table =>
          {
            table.PrimaryKey("PK_Libraries", x => x.Id);
          }
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder
        .CreateTable(
          name: "LibraryUser",
          columns: table =>
            new
            {
              LibrariesId = table.Column<int>(
                type: "int",
                nullable: false
              ),
              UsersId = table.Column<int>(
                type: "int",
                nullable: false
              )
            },
          constraints: table =>
          {
            table.PrimaryKey(
              "PK_LibraryUser",
              x => new { x.LibrariesId, x.UsersId }
            );
            table.ForeignKey(
              name: "FK_LibraryUser_Libraries_LibrariesId",
              column: x => x.LibrariesId,
              principalTable: "Libraries",
              principalColumn: "Id",
              onDelete: ReferentialAction.Cascade
            );
            table.ForeignKey(
              name: "FK_LibraryUser_Users_UsersId",
              column: x => x.UsersId,
              principalTable: "Users",
              principalColumn: "Id",
              onDelete: ReferentialAction.Cascade
            );
          }
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.InsertData(
        table: "Libraries",
        columns: new[] { "Id", "Address" },
        values: new object[,]
        {
          { 1, "Some street" },
          { 2, "Work street" }
        }
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

      migrationBuilder.InsertData(
        table: "LibraryUser",
        columns: new[] { "LibrariesId", "UsersId" },
        values: new object[] { 1, 1 }
      );

      migrationBuilder.InsertData(
        table: "LibraryUser",
        columns: new[] { "LibrariesId", "UsersId" },
        values: new object[] { 1, 2 }
      );

      migrationBuilder.InsertData(
        table: "LibraryUser",
        columns: new[] { "LibrariesId", "UsersId" },
        values: new object[] { 2, 3 }
      );

      migrationBuilder.CreateIndex(
        name: "IX_LibraryUser_UsersId",
        table: "LibraryUser",
        column: "UsersId"
      );
    }

    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DropTable(name: "LibraryUser");

      migrationBuilder.DropTable(name: "Libraries");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          15,
          22,
          3,
          30,
          898,
          DateTimeKind.Local
        ).AddTicks(4430)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          15,
          22,
          3,
          30,
          898,
          DateTimeKind.Local
        ).AddTicks(4470)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          15,
          22,
          3,
          30,
          898,
          DateTimeKind.Local
        ).AddTicks(4480)
      );
    }
  }
}
