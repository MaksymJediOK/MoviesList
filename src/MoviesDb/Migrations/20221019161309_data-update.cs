using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesCore.Migrations
{
    public partial class dataupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31575944-82e6-4254-98c6-bd2423140a7c", "7c4b731e-fc67-4d73-95a7-a428307be68a", "Admin", "ADMIN" },
                    { "daa54c14-57e2-4391-8ae7-d039eaf5f571", "f91d20e4-0248-40bb-9c24-1c12ee98f60b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "465643e7-1659-41fa-8c96-0a8f9722915d", 0, "29a69411-a2d7-481f-ac78-4f8dd9b1d8ee", "user@gmail.com", true, null, null, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEAzdZeu/sxLDug3cq056RQEejCaBZD2vAygJI24PxCdwQi7k9y8sZSzV9IRw8nuvdA==", null, false, "0fffe3d0-d8c7-4202-9881-c0635d38e954", false, "user@gmail.com" },
                    { "ec16222f-cfb7-4f78-ba85-3b526b546374", 0, "ba6bfa64-a308-4182-86d5-b00e2bff4afa", "admin@gmail.com", true, null, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIv6Nxmgdzhs05aRXgouX3PW7V4wld+EJwTxIFJI2e7h7dHhlt/XsLZ6N1WIbzR6dQ==", null, false, "df5e290a-6e5b-4b8c-a807-ec9f6e9837ba", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "daa54c14-57e2-4391-8ae7-d039eaf5f571", "465643e7-1659-41fa-8c96-0a8f9722915d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "31575944-82e6-4254-98c6-bd2423140a7c", "ec16222f-cfb7-4f78-ba85-3b526b546374" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "daa54c14-57e2-4391-8ae7-d039eaf5f571", "ec16222f-cfb7-4f78-ba85-3b526b546374" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "daa54c14-57e2-4391-8ae7-d039eaf5f571", "465643e7-1659-41fa-8c96-0a8f9722915d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "31575944-82e6-4254-98c6-bd2423140a7c", "ec16222f-cfb7-4f78-ba85-3b526b546374" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "daa54c14-57e2-4391-8ae7-d039eaf5f571", "ec16222f-cfb7-4f78-ba85-3b526b546374" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31575944-82e6-4254-98c6-bd2423140a7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daa54c14-57e2-4391-8ae7-d039eaf5f571");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465643e7-1659-41fa-8c96-0a8f9722915d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec16222f-cfb7-4f78-ba85-3b526b546374");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Actors");

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
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 4, "Criminal" },
                    { 5, "Adventure" },
                    { 6, "Comedy" },
                    { 7, "Drama" }
                });

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
    }
}
