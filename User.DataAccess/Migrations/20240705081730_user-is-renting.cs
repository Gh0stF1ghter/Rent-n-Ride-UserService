using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userisrenting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsRenting",
                table: "Clients",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "IsRenting", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("13de463e-cf29-4d60-a6ba-f3cbe40f84ba"), 36994.938191281450000m, "Sierra_Jones8@hotmail.com", "Ahmad", false, "Smith", "(938) 889-1432 x134" },
                    { new Guid("1d9b1097-8bea-4f39-a38f-8057992ed723"), 20259.14285047050000m, "Raegan10@gmail.com", "Asa", true, "Kreiger", "1-394-390-6886 x271" },
                    { new Guid("33371ffa-14fd-47c8-a3cd-f5f7477d3af5"), 4481.5336643129350000m, "Sammy_Torphy27@hotmail.com", "Madeline", true, "Ernser", "279.362.8246" },
                    { new Guid("5229cec4-c992-483d-9e9a-bc6fc41eae2c"), 41482.077445750250000m, "Gregorio.Padberg4@yahoo.com", "Sid", true, "Hackett", "318.505.7465" },
                    { new Guid("7a409eb9-d45e-45f9-bc9e-c367ad121e26"), 35017.201065673100000m, "Elton_Trantow@hotmail.com", "Camilla", true, "Wolff", "1-978-604-5531 x776" },
                    { new Guid("a8978887-498b-4406-b8bb-b3928031086b"), 30202.928451868800000m, "Samanta.Hickle75@hotmail.com", "Amparo", true, "Johns", "(631) 863-5260 x9394" },
                    { new Guid("b7b55cff-b622-44b9-ba6e-2b62b64fe0f7"), 14363.908345085700000m, "Johann54@yahoo.com", "Gracie", true, "Donnelly", "523-998-0189 x019" },
                    { new Guid("bdded6cb-f91e-4fc6-b893-45a42ec077aa"), 27101.903974455200000m, "Carole48@yahoo.com", "Verla", true, "Hilpert", "953-352-9161" },
                    { new Guid("d0d21820-7f21-48d4-9222-4e1d49313f0f"), 47038.815394989600000m, "Clementine48@gmail.com", "Anika", true, "Von", "1-748-380-4972" },
                    { new Guid("d0f2c3d0-93b9-4a5a-92a8-dd07e0b3e37e"), 28259.469327243850000m, "Andy_Gutmann53@hotmail.com", "Gustave", false, "Bradtke", "395.261.4430 x5676" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("13de463e-cf29-4d60-a6ba-f3cbe40f84ba"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d9b1097-8bea-4f39-a38f-8057992ed723"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("33371ffa-14fd-47c8-a3cd-f5f7477d3af5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5229cec4-c992-483d-9e9a-bc6fc41eae2c"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7a409eb9-d45e-45f9-bc9e-c367ad121e26"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a8978887-498b-4406-b8bb-b3928031086b"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b7b55cff-b622-44b9-ba6e-2b62b64fe0f7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("bdded6cb-f91e-4fc6-b893-45a42ec077aa"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d0d21820-7f21-48d4-9222-4e1d49313f0f"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d0f2c3d0-93b9-4a5a-92a8-dd07e0b3e37e"));

            migrationBuilder.DropColumn(
                name: "IsRenting",
                table: "Clients");

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
    }
}
