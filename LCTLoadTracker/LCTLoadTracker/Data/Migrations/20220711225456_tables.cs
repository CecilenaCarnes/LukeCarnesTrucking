using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCTLoadTracker.Data.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("70122b5d-9bc0-4cbf-9a4c-84b22bd84b41"));

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("e7dab758-4fd0-411f-9735-2e8786350987"));

            migrationBuilder.AddColumn<int>(
                name: "BOL",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerUnloaded",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Persons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Driver",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gallons1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gallons2",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gallons3",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gallons4",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gallons5",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoadCount",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LoadID",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product2",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product3",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product4",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product5",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pump",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Split",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TerminalLoaded",
                table: "Persons",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BOL",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CustomerUnloaded",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Driver",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gallons1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gallons2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gallons3",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gallons4",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Gallons5",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LoadCount",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LoadID",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Product1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Product2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Product3",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Product4",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Product5",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Pump",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Split",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TerminalLoaded",
                table: "Persons");

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("70122b5d-9bc0-4cbf-9a4c-84b22bd84b41"), "Beattyville", "KY", "214 Baker Bar Subdvs", 41311, new DateTime(1983, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "859.408.3753", "Bulldog389pete1983@yahoo.com", "Matt", null, "Green", "452-45-7845" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressCity", "AddressState", "AddressStreet", "AddressZip", "BirthDate", "CellPhone", "Email", "FirstName", "HomePhone", "LastName", "SSN" },
                values: new object[] { new Guid("e7dab758-4fd0-411f-9735-2e8786350987"), "London", "KY", "1236 Hawk Creek Rd", 40741, new DateTime(1963, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "606.514.7884", "jdavidson1110@gmail.com", "John", null, "Davidson", "785-78-4521" });
        }
    }
}
