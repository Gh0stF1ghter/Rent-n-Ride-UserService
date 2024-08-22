using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Clients");

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
    }
}
