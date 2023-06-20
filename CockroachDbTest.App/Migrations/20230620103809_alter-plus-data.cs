using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CockroachDbTest.App.Migrations
{
    public partial class alterplusdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entities1",
                columns: new[] { "Id", "Name", "Age" },
                values: new object[] { Guid.NewGuid(), "Ferrari3", 14});
            
            migrationBuilder.AddColumn<bool>(
                name: "IsTrue",
                table: "Entities1",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            // Not Working in CocroachDB
            //https://github.com/cockroachdb/cockroach/issues/31463
            // migrationBuilder.InsertData(
            //     table: "Entities1",
            //     columns: new[] { "Id", "Name", "Age", "IsTrue" },
            //     values: new object[] { Guid.NewGuid(), "Ferrari4", 1, true});

            migrationBuilder.CreateTable(
                name: "Entities15",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities15", x => x.Id);
                });
            
            migrationBuilder.InsertData(
                table: "Entities15",
                columns: new[] { "Id", "Name", "Age" },
                values: new object[] { Guid.NewGuid(), "Ferrari", 1});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities15");

            migrationBuilder.DropColumn(
                name: "IsTrue",
                table: "Entities1");
        }
    }
}
