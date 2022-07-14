using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCTLoadTracker.Data.Migrations
{
    public partial class Loads1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("26bbf3b3-4998-4ebe-992f-f55522a52096"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("44c57507-5fae-4ceb-b366-6bcd052bfbd5"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("871a1786-835d-4a79-8e39-c4b9746085fb"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Person", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("be2c5230-0d8f-4f69-89f4-664afc504756"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "Person", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("871a1786-835d-4a79-8e39-c4b9746085fb"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("be2c5230-0d8f-4f69-89f4-664afc504756"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("26bbf3b3-4998-4ebe-992f-f55522a52096"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "Person", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("44c57507-5fae-4ceb-b366-6bcd052bfbd5"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Person", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });
        }
    }
}
