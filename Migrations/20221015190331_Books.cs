using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Winter.Migrations
{
  public partial class Books : Migration
  {
    protected override void Up(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder
        .CreateTable(
          name: "Books",
          columns: table =>
            new
            {
              Id = table
                .Column<int>(type: "int", nullable: false)
                .Annotation(
                  "MySql:ValueGenerationStrategy",
                  MySqlValueGenerationStrategy.IdentityColumn
                ),
              Author = table
                .Column<string>(
                  type: "longtext",
                  nullable: false
                )
                .Annotation("MySql:CharSet", "utf8mb4"),
              BookName = table
                .Column<string>(
                  type: "longtext",
                  nullable: false
                )
                .Annotation("MySql:CharSet", "utf8mb4"),
              UserId = table.Column<int>(
                type: "int",
                nullable: false
              )
            },
          constraints: table =>
          {
            table.PrimaryKey("PK_Books", x => x.Id);
            table.ForeignKey(
              name: "FK_Books_Users_UserId",
              column: x => x.UserId,
              principalTable: "Users",
              principalColumn: "Id",
              onDelete: ReferentialAction.Cascade
            );
          }
        )
        .Annotation("MySql:CharSet", "utf8mb4");

      migrationBuilder.InsertData(
        table: "Books",
        columns: new[]
        {
          "Id",
          "Author",
          "BookName",
          "UserId"
        },
        values: new object[,]
        {
          { 1, "Jane Austen", "Pride and Prejudice", 1 },
          { 2, "George Orwell", "1984", 1 },
          { 3, "Hamlet", "William Shakespeare", 3 }
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

      migrationBuilder.CreateIndex(
        name: "IX_Books_UserId",
        table: "Books",
        column: "UserId"
      );
    }

    protected override void Down(
      MigrationBuilder migrationBuilder
    )
    {
      migrationBuilder.DropTable(name: "Books");

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 1,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          9,
          16,
          5,
          4,
          206,
          DateTimeKind.Local
        ).AddTicks(6630)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 2,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          9,
          16,
          5,
          4,
          206,
          DateTimeKind.Local
        ).AddTicks(6680)
      );

      migrationBuilder.UpdateData(
        table: "Users",
        keyColumn: "Id",
        keyValue: 3,
        column: "CreatedAt",
        value: new DateTime(
          2022,
          10,
          9,
          16,
          5,
          4,
          206,
          DateTimeKind.Local
        ).AddTicks(6680)
      );
    }
  }
}
