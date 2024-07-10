using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class randombalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("63b7adac-32c0-4d6c-9720-8eb8777adb35"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("69301dc7-0aab-4cdb-b7d8-b9894fcc22cd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed149-f702-4694-907a-f20f9ba29c6f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8e4600ac-9362-446a-9f81-60350b3c27b8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("98c942f9-45b5-4f56-b30b-a45b4c6be971"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c97a23b0-13c9-4730-96b5-fdb571b52782"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d69f058d-1ae4-4b41-8f8c-b64ff4a0516c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("dbf5435e-14a1-428e-82af-892eda3f431f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f20215ba-ee35-4be6-bfd1-7af26c9c3eaa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("f3d5b9cd-0ece-4102-b2fc-f4b49c4f6b2b"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("011561ba-8d4e-481d-91ae-75aa8affad42"), 36977.191754503900000m, "Deion_Ryan@hotmail.com", "Ricardo", "Daugherty", "938-761-3952" },
                    { new Guid("0488a522-746e-4b1a-88d7-3e848b123b0d"), 23652.007032829450000m, "Lowell_Russel@gmail.com", "Sigrid", "Bartoletti", "564-447-9599 x515" },
                    { new Guid("1403f621-41d7-435d-903e-b3a20be2a462"), 21409.004313048700000m, "Mariela4@gmail.com", "Nicholaus", "Klein", "(484) 667-7643" },
                    { new Guid("168a9c7c-7db6-4c9c-b9cf-90acf49adc8e"), 42122.762235839100000m, "Celestino25@hotmail.com", "Maritza", "Hoeger", "(987) 617-2955 x813" },
                    { new Guid("368d2e55-a0b8-4458-9b6a-a386037e20c3"), 47061.281206437700000m, "Ashley_Gerlach@yahoo.com", "Odessa", "Jacobson", "(884) 660-7429 x9788" },
                    { new Guid("5df911ec-0da3-4285-a3bc-1bfcff08b446"), 10342.346360873400000m, "Paula.Sauer7@gmail.com", "Parker", "Douglas", "257.913.6247" },
                    { new Guid("a8f645db-f2fc-4ab5-947f-d4252f67829f"), 2266.720401470150000m, "Mozelle66@yahoo.com", "Luis", "Crona", "1-381-415-7000 x12877" },
                    { new Guid("aa6e6ede-140b-4ff2-a207-0393e3360dce"), 11480.72142170950000m, "Monte.Torp@yahoo.com", "Kelton", "Nitzsche", "(502) 763-5149" },
                    { new Guid("c9cbbd43-5027-490d-8f97-620ceb9768bc"), 17386.614475165400000m, "Ronaldo.Torp@yahoo.com", "Lue", "Walker", "1-978-917-5184" },
                    { new Guid("cc24f848-b128-4d08-a388-02011bf2ad4a"), 39056.622368568800000m, "Emmitt50@hotmail.com", "Ellie", "MacGyver", "981.529.1267 x950" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("011561ba-8d4e-481d-91ae-75aa8affad42"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("0488a522-746e-4b1a-88d7-3e848b123b0d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1403f621-41d7-435d-903e-b3a20be2a462"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("168a9c7c-7db6-4c9c-b9cf-90acf49adc8e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("368d2e55-a0b8-4458-9b6a-a386037e20c3"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5df911ec-0da3-4285-a3bc-1bfcff08b446"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a8f645db-f2fc-4ab5-947f-d4252f67829f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("aa6e6ede-140b-4ff2-a207-0393e3360dce"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c9cbbd43-5027-490d-8f97-620ceb9768bc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cc24f848-b128-4d08-a388-02011bf2ad4a"));

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
    }
}
