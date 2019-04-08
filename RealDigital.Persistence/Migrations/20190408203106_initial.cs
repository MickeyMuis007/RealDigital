using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealDigital.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNo" },
                values: new object[,]
                {
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"), "michael@mah", "Michael", "Hendricks", "0784344321" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"), "jacob@mah", "Jacob", "Collins", "0784323421" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"), "adam@mah", "Adam", "Antons", "0784346789" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"), "james@mah", "James", "Barns", "0732343521" },
                    { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e5"), "tammy@mah", "Tammy", "Micthels", "0784347654" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
