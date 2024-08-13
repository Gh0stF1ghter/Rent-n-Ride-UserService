using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class phonenumempty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("08d70c69-3be4-42c4-8482-939f9fa2f3a8"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("22d734e5-49ad-42f3-8e1b-a1bb48129287"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("26760811-59e9-43f0-84de-88c09056d513"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("3981286b-7188-4db1-a6ea-1347741e64dd"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("4162a2f3-e146-4aca-85c7-4d5273d0542a"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("5a3c3d28-a914-4c25-a6ab-50398a0a1d83"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("6e96d0f9-67ea-4728-984c-768e31e19f5d"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("7caa52e8-6b32-4598-9ac1-297e57122d43"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("b265198d-30e4-4b5f-a3e8-448b466d1cec"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d3bf5f6c-2ada-4a32-9c0b-3231bf53380d"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Balance", "Email", "FirstName", "IsRenting", "LastName", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("08d70c69-3be4-42c4-8482-939f9fa2f3a8"), 33570.767887354350000m, "Winston.Rosenbaum60@gmail.com", "Tristian", false, "Collier", "(856) 766-5911", "" },
                    { new Guid("22d734e5-49ad-42f3-8e1b-a1bb48129287"), 29756.162646547800000m, "Garland.Reichert11@hotmail.com", "Maudie", true, "Sauer", "523.465.0924 x2137", "" },
                    { new Guid("26760811-59e9-43f0-84de-88c09056d513"), 32281.117240160450000m, "Floyd_Mayert@gmail.com", "Eloise", false, "Rogahn", "782.583.1849", "" },
                    { new Guid("3981286b-7188-4db1-a6ea-1347741e64dd"), 27289.851974742900000m, "Alivia86@gmail.com", "Makenna", true, "Turner", "(288) 878-6790 x3797", "" },
                    { new Guid("4162a2f3-e146-4aca-85c7-4d5273d0542a"), 31658.576939257200000m, "Winnifred_Stanton78@gmail.com", "Kaitlin", false, "Lehner", "748.843.6456 x9281", "" },
                    { new Guid("5a3c3d28-a914-4c25-a6ab-50398a0a1d83"), 2343.5537826561750000m, "Derek.Metz@yahoo.com", "Hattie", false, "Ruecker", "(791) 938-8926 x41487", "" },
                    { new Guid("6e96d0f9-67ea-4728-984c-768e31e19f5d"), 44215.477645722400000m, "Polly_Will48@gmail.com", "Santa", false, "Langworth", "(899) 205-2441", "" },
                    { new Guid("7caa52e8-6b32-4598-9ac1-297e57122d43"), 26345.15083946900000m, "Delbert25@yahoo.com", "Jovany", false, "Howe", "1-957-800-0426 x777", "" },
                    { new Guid("b265198d-30e4-4b5f-a3e8-448b466d1cec"), 22410.983847761850000m, "Joshuah88@yahoo.com", "Marcel", true, "Feeney", "271.211.7721 x254", "" },
                    { new Guid("d3bf5f6c-2ada-4a32-9c0b-3231bf53380d"), 12195.554944194200000m, "Alayna_Doyle@gmail.com", "Nelle", false, "Gottlieb", "1-683-584-9709 x60865", "" }
                });
        }
    }
}
