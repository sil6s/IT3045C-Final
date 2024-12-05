using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3045C_Final.Migrations
{
    public partial class AddTeamMemberFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BreakfastFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakfastYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carbs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FruitsOrVeggies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BreakfastFood_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artistic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Athletic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Musical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Academic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobbies_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_TeamMembers_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalTable: "TeamMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BreakfastFood_TeamMemberId",
                table: "BreakfastFood",
                column: "TeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_TeamMemberId",
                table: "Hobbies",
                column: "TeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_TeamMemberId",
                table: "Pets",
                column: "TeamMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastFood");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
