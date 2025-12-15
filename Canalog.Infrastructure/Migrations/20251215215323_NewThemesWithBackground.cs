using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewThemesWithBackground : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("cccc0000-1111-4111-8111-000000000001"),
                column: "Background",
                value: "src/assets/images/light-mode.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("dddd0000-2222-4222-8222-000000000002"),
                column: "Background",
                value: "src/assets/images/dark-mode.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("cccc0000-1111-4111-8111-000000000001"),
                column: "Background",
                value: "");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("dddd0000-2222-4222-8222-000000000002"),
                column: "Background",
                value: "");
        }
    }
}
