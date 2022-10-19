using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class seedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4058fab6-953c-4dd6-aed6-dcd9599b1db8", "c3f397d3-789d-4057-b991-4bb5b240c381", "User", "USER" },
                    { "67173906-410a-48c9-a2f5-ad4603263575", "5f93bf11-267f-4093-bc52-8d238e6ff865", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "723357eb-76d2-4572-b47c-3209857cad0f", 0, "d7fc7e63-06a3-4883-a060-44e31380b82b", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEGRKMpNoikY0YxJYsxw6Exg0bUxN+JJ2sgfedfyE64OQxdmUKDujfGtp6de/vpS9oA==", null, false, "0e0c3fa4-f2e8-4af8-b825-1c7badfc1092", false, "user@gmail.com" },
                    { "d626bf8f-0510-47bc-9e52-7618c08a08d9", 0, "5e13801e-0bb7-456c-bb45-1d9886e65775", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO7Il8QSBPoH/mO8wpaziIIvoH1jBFdONA5+RJL5u48mAviBXHws4gwM/YZNKi2+OQ==", null, false, "3eccaaea-7646-4d2a-8299-5195f0b60f44", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Christopher", "Nolan" },
                    { 2, "Peter", "Jackson" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Fantasy" },
                    { 3, "Detective" },
                    { 4, "Criminal" },
                    { 5, "Adventure" },
                    { 6, "Comedy" },
                    { 7, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Duration", "PosterPath", "PublisherCountryId", "Rating", "ReleaseYear", "Title" },
                values: new object[] { 1, "Some random text", 130, "https://static.posters.cz/image/750/%D0%9F%D0%BB%D0%B0%D0%BA%D0%B0%D1%82%D0%B8/interstellar-ice-walk-i23290.jpg", null, 9.27f, 2014, "Interstellar" });

            migrationBuilder.InsertData(
                table: "PublisherCountries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "France" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4058fab6-953c-4dd6-aed6-dcd9599b1db8", "723357eb-76d2-4572-b47c-3209857cad0f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4058fab6-953c-4dd6-aed6-dcd9599b1db8", "d626bf8f-0510-47bc-9e52-7618c08a08d9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67173906-410a-48c9-a2f5-ad4603263575", "d626bf8f-0510-47bc-9e52-7618c08a08d9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4058fab6-953c-4dd6-aed6-dcd9599b1db8", "723357eb-76d2-4572-b47c-3209857cad0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4058fab6-953c-4dd6-aed6-dcd9599b1db8", "d626bf8f-0510-47bc-9e52-7618c08a08d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67173906-410a-48c9-a2f5-ad4603263575", "d626bf8f-0510-47bc-9e52-7618c08a08d9" });

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublisherCountries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublisherCountries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4058fab6-953c-4dd6-aed6-dcd9599b1db8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67173906-410a-48c9-a2f5-ad4603263575");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723357eb-76d2-4572-b47c-3209857cad0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d626bf8f-0510-47bc-9e52-7618c08a08d9");
        }
    }
}
