using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingPropToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClockHandPrimary",
                table: "UiColorSchemes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-4aaa-8aaa-111111111111"),
                column: "ClockHandPrimary",
                value: "#1E3A1F");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("22222222-bbbb-4bbb-8bbb-222222222222"),
                column: "ClockHandPrimary",
                value: "#5A4D7A");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ccc-8ccc-333333333333"),
                column: "ClockHandPrimary",
                value: "#FF4BC2");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("44444444-dddd-4ddd-8ddd-444444444444"),
                column: "ClockHandPrimary",
                value: "#CFFDFE");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("55555555-eeee-4eee-8eee-555555555555"),
                column: "ClockHandPrimary",
                value: "#4E3A28");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("66666666-ffff-4fff-8fff-666666666666"),
                column: "ClockHandPrimary",
                value: "#FF6A4A");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("77777777-aaaa-4aaa-8aaa-777777777777"),
                column: "ClockHandPrimary",
                value: "#2F503C");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("88888888-aaaa-4aaa-8aaa-888888888111"),
                column: "ClockHandPrimary",
                value: "#57D5FF");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("99999999-bbbb-4bbb-8bbb-999999999111"),
                column: "ClockHandPrimary",
                value: "#ECE6FF");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("aaaa0000-cccc-4ccc-8ccc-a00000000011"),
                column: "ClockHandPrimary",
                value: "#4B2A24");

            migrationBuilder.UpdateData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("bbbb0000-cccc-4ccc-8ccc-b00000000011"),
                column: "ClockHandPrimary",
                value: "#CFFFE1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClockHandPrimary",
                table: "UiColorSchemes");
        }
    }
}
