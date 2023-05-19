using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  /// <inheritdoc />
  public partial class UploadedFile : Migration
  {
    /// <inheritdoc />
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder
        .CreateTable(
          name: "UploadedFiles",
          columns: table =>
            new
            {
              Id = table
                .Column<int>(type: "int", nullable: false)
                .Annotation(
                  "MySql:ValueGenerationStrategy",
                  MySqlValueGenerationStrategy.IdentityColumn
                ),
              Name = table
                .Column<string>(
                  type: "longtext",
                  nullable: false
                )
                .Annotation("MySql:CharSet", "utf8mb4"),
              Path = table
                .Column<string>(
                  type: "longtext",
                  nullable: false
                )
                .Annotation("MySql:CharSet", "utf8mb4")
            },
          constraints: table =>
          {
            table.PrimaryKey("PK_UploadedFiles", x => x.Id);
          }
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        column: "CreatedAt",
        value: new DateTime(
          2023,
          5,
          17,
          22,
          5,
          26,
          274,
          DateTimeKind.Local
        ).AddTicks(5980)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2023,
          5,
          17,
          22,
          5,
          26,
          274,
          DateTimeKind.Local
        ).AddTicks(6030)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2023,
          5,
          17,
          22,
          5,
          26,
          274,
          DateTimeKind.Local
        ).AddTicks(6030)
      );
    }

    /// <inheritdoc />
    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DropTable(name: "UploadedFiles");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          25,
          22,
          37,
          55,
          682,
          DateTimeKind.Local
        ).AddTicks(1990)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          25,
          22,
          37,
          55,
          682,
          DateTimeKind.Local
        ).AddTicks(2040)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          25,
          22,
          37,
          55,
          682,
          DateTimeKind.Local
        ).AddTicks(2050)
      );
    }
  }
}
