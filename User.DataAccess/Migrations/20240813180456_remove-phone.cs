using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class removephone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("08d682d1-6830-4778-8016-5437f2695940"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("2ec6f13d-a927-4352-afa2-99f89e1d2a16"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7d45c731-c386-47a6-8454-e67f0dac0b81"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("88b51920-147e-48cb-b543-0aaacb75f8cf"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("93dfa6d7-68c2-470b-a6a1-ff13c693fc48"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("9977e109-5c39-4348-ae87-b8081d2a0426"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("99b105d5-83dd-4041-9eaf-2fd4f26cf5fd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a3c22e2d-7844-4c16-befa-df86a05383a4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ac81d09b-cb46-4a6f-b0c8-91f47598dc2e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("dfade82b-fc92-4535-89dc-8a78129282af"));

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Clients");

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "IsRenting", "LastName", "UserId" },
                values: new object[,]
                {
                    { new Guid("027a7423-c35c-4b86-a258-34b4b8b79ddc"), 47650.956730164150000m, "Flo.Spencer63@gmail.com", "Davion", false, "Maggio", "" },
                    { new Guid("1900c2a9-16f7-43dd-9b7f-0703ef9c1474"), 37961.059584877700000m, "Jude.Homenick@yahoo.com", "Arely", false, "O'Keefe", "" },
                    { new Guid("60918948-6bd0-4322-92f0-b6aded7bdcf7"), 18289.699407872200000m, "Clare44@yahoo.com", "Eino", false, "Glover", "" },
                    { new Guid("93f75a0b-070b-498a-b3d9-b3426cba8137"), 22712.507427203650000m, "Furman.Gerlach@yahoo.com", "Michelle", false, "Hoppe", "" },
                    { new Guid("a7654ee3-9283-481c-8814-175108db2b3e"), 32158.45624852850000m, "Damaris52@yahoo.com", "Coty", false, "Herzog", "" },
                    { new Guid("ad66c6cc-b719-4850-ae64-6814e96a6538"), 14974.118470660700000m, "Neha85@gmail.com", "Roman", true, "Zboncak", "" },
                    { new Guid("b7526463-635c-425b-bde2-f7ee5afc21f5"), 22350.894261302700000m, "Roxanne_Lynch@hotmail.com", "Chester", false, "Williamson", "" },
                    { new Guid("b7cdae4f-ec8f-48bc-86cd-28f13d32c4e7"), 5944.011214830550000m, "Jamal57@yahoo.com", "Alexandra", true, "Quigley", "" },
                    { new Guid("c9c4ad86-ac62-4977-9fd0-605242bcc8d4"), 30153.580322385200000m, "Annamae.Aufderhar@hotmail.com", "Jack", false, "Moore", "" },
                    { new Guid("fd84854b-06ac-4c0d-b539-6ee31bc66670"), 11584.799740120450000m, "Priscilla85@hotmail.com", "Gretchen", false, "Bartell", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("027a7423-c35c-4b86-a258-34b4b8b79ddc"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1900c2a9-16f7-43dd-9b7f-0703ef9c1474"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("60918948-6bd0-4322-92f0-b6aded7bdcf7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("93f75a0b-070b-498a-b3d9-b3426cba8137"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("a7654ee3-9283-481c-8814-175108db2b3e"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("ad66c6cc-b719-4850-ae64-6814e96a6538"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b7526463-635c-425b-bde2-f7ee5afc21f5"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b7cdae4f-ec8f-48bc-86cd-28f13d32c4e7"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("c9c4ad86-ac62-4977-9fd0-605242bcc8d4"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("fd84854b-06ac-4c0d-b539-6ee31bc66670"));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "IsRenting", "LastName", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("08d682d1-6830-4778-8016-5437f2695940"), 22804.874005464450000m, "Walton80@gmail.com", "Kara", true, "O'Hara", "1-611-349-9882", "" },
                    { new Guid("2ec6f13d-a927-4352-afa2-99f89e1d2a16"), 20275.550105808600000m, "Carmine.Rolfson74@yahoo.com", "Taylor", false, "Schultz", "1-237-400-5140", "" },
                    { new Guid("7d45c731-c386-47a6-8454-e67f0dac0b81"), 6629.546991346250000m, "Tommie.Aufderhar96@hotmail.com", "Francesco", false, "Gusikowski", "(909) 540-4305", "" },
                    { new Guid("88b51920-147e-48cb-b543-0aaacb75f8cf"), 33192.808964804150000m, "Cathrine48@gmail.com", "Jaylon", true, "Borer", "953-535-0227", "" },
                    { new Guid("93dfa6d7-68c2-470b-a6a1-ff13c693fc48"), 3485.0359759269700000m, "Rhoda39@gmail.com", "Mia", true, "Goldner", "1-283-265-5188", "" },
                    { new Guid("9977e109-5c39-4348-ae87-b8081d2a0426"), 11197.127085003900000m, "Cassie2@gmail.com", "Sydnee", false, "Wunsch", "360.342.4553 x6861", "" },
                    { new Guid("99b105d5-83dd-4041-9eaf-2fd4f26cf5fd"), 21247.689355845650000m, "Raoul77@hotmail.com", "Evert", true, "Deckow", "1-476-886-3977 x49049", "" },
                    { new Guid("a3c22e2d-7844-4c16-befa-df86a05383a4"), 14012.199313377800000m, "Magdalena48@hotmail.com", "Woodrow", false, "Tromp", "1-848-679-6147 x6411", "" },
                    { new Guid("ac81d09b-cb46-4a6f-b0c8-91f47598dc2e"), 33231.534321881950000m, "Tomasa.Bergnaum@yahoo.com", "Vivienne", false, "Predovic", "635.958.5182", "" },
                    { new Guid("dfade82b-fc92-4535-89dc-8a78129282af"), 21680.723279120400000m, "Berenice.Crona@hotmail.com", "Nyah", true, "O'Conner", "(891) 902-3482 x689", "" }
                });
        }
    }
}
