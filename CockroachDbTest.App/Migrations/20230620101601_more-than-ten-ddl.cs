using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CockroachDbTest.App.Migrations
{
    public partial class morethantenddl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities10",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities10", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities13",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities13", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities14",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities14", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities5",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities6",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities7",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities8",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities8", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities9",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities11",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Entities2Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities11", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities11_Entities2_Entities2Id",
                        column: x => x.Entities2Id,
                        principalTable: "Entities2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entities12",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Entities3Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities12", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entities12_Entities3_Entities3Id",
                        column: x => x.Entities3Id,
                        principalTable: "Entities3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entities11_Entities2Id",
                table: "Entities11",
                column: "Entities2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Entities12_Entities3Id",
                table: "Entities12",
                column: "Entities3Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities10");

            migrationBuilder.DropTable(
                name: "Entities11");

            migrationBuilder.DropTable(
                name: "Entities12");

            migrationBuilder.DropTable(
                name: "Entities13");

            migrationBuilder.DropTable(
                name: "Entities14");

            migrationBuilder.DropTable(
                name: "Entities4");

            migrationBuilder.DropTable(
                name: "Entities5");

            migrationBuilder.DropTable(
                name: "Entities6");

            migrationBuilder.DropTable(
                name: "Entities7");

            migrationBuilder.DropTable(
                name: "Entities8");

            migrationBuilder.DropTable(
                name: "Entities9");

            migrationBuilder.DropTable(
                name: "Entities2");

            migrationBuilder.DropTable(
                name: "Entities3");
        }
    }
}
