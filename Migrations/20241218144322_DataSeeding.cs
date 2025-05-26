using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amr Mousa" },
                    { 2, new DateTime(2001, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anas Emad" },
                    { 3, new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohab Ayman" }
                });

            migrationBuilder.InsertData(
                table: "Borrower",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mohamed Saleh" },
                    { 2, "Ahmed Salem" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Genre", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Art", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don Quixote" },
                    { 2, 1, "Science Fiction", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Treasure Island" },
                    { 3, 1, "Historical", new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Eyre" },
                    { 4, 2, "Art", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moby Dick" },
                    { 5, 2, "Science Fiction", new DateTime(2022, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gulliver's Travels" },
                    { 6, 2, "Historical", new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Christmas Carol" },
                    { 7, 3, "Art", new DateTime(2020, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "White Fang" },
                    { 8, 3, "Historical", new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Christmas Carol" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Borrower",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrower",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
