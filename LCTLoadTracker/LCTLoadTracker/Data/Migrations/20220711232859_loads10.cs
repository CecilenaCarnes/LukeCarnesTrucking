using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LCTLoadTracker.Data.Migrations
{
    public partial class loads10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    LoadID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Driver = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoadCount = table.Column<int>(type: "int", nullable: true),
                    BOL = table.Column<int>(type: "int", nullable: true),
                    TerminalLoaded = table.Column<int>(type: "int", nullable: true),
                    CustomerUnloaded = table.Column<int>(type: "int", nullable: true),
                    Product1 = table.Column<int>(type: "int", nullable: false),
                    Gallons1 = table.Column<int>(type: "int", nullable: true),
                    Product2 = table.Column<int>(type: "int", nullable: true),
                    Gallons2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product3 = table.Column<int>(type: "int", nullable: true),
                    Gallons3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product4 = table.Column<int>(type: "int", nullable: true),
                    Gallons4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product5 = table.Column<int>(type: "int", nullable: true),
                    Gallons5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Split = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pump = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.LoadID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loads");

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
    }
}
