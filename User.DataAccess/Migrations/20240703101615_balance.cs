using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class balance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Balance = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("63b7adac-32c0-4d6c-9720-8eb8777adb35"), 0m, "Makenna.Daugherty@gmail.com", "Nikita", "Thiel", "(376) 806-5139 x24025" },
                    { new Guid("69301dc7-0aab-4cdb-b7d8-b9894fcc22cd"), 0m, "Julien65@gmail.com", "Savanah", "Welch", "(837) 595-8775 x3234" },
                    { new Guid("8d7ed149-f702-4694-907a-f20f9ba29c6f"), 0m, "Jody90@yahoo.com", "Rhett", "Kertzmann", "939.805.5582 x8811" },
                    { new Guid("8e4600ac-9362-446a-9f81-60350b3c27b8"), 0m, "Caleigh84@hotmail.com", "Jevon", "Stiedemann", "641.896.4574" },
                    { new Guid("98c942f9-45b5-4f56-b30b-a45b4c6be971"), 0m, "Bertram_Quigley2@hotmail.com", "Tyra", "Price", "301.326.0707 x01662" },
                    { new Guid("c97a23b0-13c9-4730-96b5-fdb571b52782"), 0m, "Geovany96@hotmail.com", "Marc", "Upton", "1-481-840-1715" },
                    { new Guid("d69f058d-1ae4-4b41-8f8c-b64ff4a0516c"), 0m, "Laurence10@hotmail.com", "Easton", "Hackett", "(751) 799-3209" },
                    { new Guid("dbf5435e-14a1-428e-82af-892eda3f431f"), 0m, "Adrien77@hotmail.com", "Maybell", "VonRueden", "208-835-4729" },
                    { new Guid("f20215ba-ee35-4be6-bfd1-7af26c9c3eaa"), 0m, "Jorge80@yahoo.com", "Adell", "Dare", "501-461-0193" },
                    { new Guid("f3d5b9cd-0ece-4102-b2fc-f4b49c4f6b2b"), 0m, "Jillian.Schumm@yahoo.com", "Cleveland", "Kuhic", "903-200-2538" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
