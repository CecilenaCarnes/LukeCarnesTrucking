using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCTLoadTracker.Data.Migrations
{
    public partial class personsdataonly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("4a2bc86f-a17c-44ce-9493-03d3765f6700"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("9d844f8b-3d82-434c-8f89-3680ad85f623"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("4a2bc86f-a17c-44ce-9493-03d3765f6700"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("9d844f8b-3d82-434c-8f89-3680ad85f623"));
        }
    }
}
