using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WADWebsite.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    FestivalID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FestivalName = table.Column<string>(type: "varchar(23)", nullable: false),
                    Location = table.Column<string>(type: "varchar(22)", nullable: false),
                    TicketType = table.Column<string>(type: "varchar(27)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(28,0)", nullable: false),
                    CampingIncluded = table.Column<bool>(type: "bit", nullable: false),
                    LineupLink = table.Column<string>(type: "varchar(57)", nullable: true),
                    FestivalImage = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.FestivalID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Festivals");
        }
    }
}
