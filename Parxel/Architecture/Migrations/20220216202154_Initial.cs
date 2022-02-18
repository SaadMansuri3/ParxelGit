using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(20)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    Mobile = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
