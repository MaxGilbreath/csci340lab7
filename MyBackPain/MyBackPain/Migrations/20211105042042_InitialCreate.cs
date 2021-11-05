using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBackPain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackPain",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoIHaveBackPain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsItMyFault = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DidITakeIbuprofen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoIShakeMyFistsAtTheSky = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackPain", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackPain");
        }
    }
}
