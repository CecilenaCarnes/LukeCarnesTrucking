using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCTLoadTracker.Data.Migrations
{
    public partial class loads4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("290e8e29-6748-4df4-ab62-408f642fcd9e"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Person", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("5ad3f641-9a98-4236-8a56-ce61172b4748"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "Person", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("290e8e29-6748-4df4-ab62-408f642fcd9e"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("5ad3f641-9a98-4236-8a56-ce61172b4748"));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("871a1786-835d-4a79-8e39-c4b9746085fb"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Person", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Discriminator", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("be2c5230-0d8f-4f69-89f4-664afc504756"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "Person", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });
        }
    }
}
