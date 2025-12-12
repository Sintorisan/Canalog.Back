using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-4111-8111-111111111111"),
                column: "Background",
                value: "src/assets/images/leafs.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-4222-8222-222222222222"),
                column: "Background",
                value: "src/assets/images/clouds.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-4333-8333-333333333333"),
                column: "Background",
                value: "src/assets/images/color-burst.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-8444-444444444444"),
                column: "Background",
                value: "src/assets/images/deep-sea.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-4555-8555-555555555555"),
                column: "Background",
                value: "src/assets/images/desert.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-4666-8666-666666666666"),
                column: "Background",
                value: "src/assets/images/flame.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-4777-8777-777777777777"),
                column: "Background",
                value: "src/assets/images/flowerpots.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-4888-8888-188888888888"),
                column: "Background",
                value: "src/assets/images/micro.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-4999-9999-199999999999"),
                column: "Background",
                value: "src/assets/images/silk.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("aaaa0000-aaaa-4aaa-8aaa-a00000000000"),
                column: "Background",
                value: "src/assets/images/swirl-art.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("bbbb0000-bbbb-4bbb-8bbb-b00000000000"),
                column: "Background",
                value: "src/assets/images/leaf.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-4111-8111-111111111111"),
                column: "Background",
                value: "assets/images/leafs.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-4222-8222-222222222222"),
                column: "Background",
                value: "assets/images/clouds.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-4333-8333-333333333333"),
                column: "Background",
                value: "assets/images/color-burst.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-8444-444444444444"),
                column: "Background",
                value: "assets/images/deep-sea.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-4555-8555-555555555555"),
                column: "Background",
                value: "assets/images/desert.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-4666-8666-666666666666"),
                column: "Background",
                value: "assets/images/flame.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-4777-8777-777777777777"),
                column: "Background",
                value: "assets/images/flowerpots.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-4888-8888-188888888888"),
                column: "Background",
                value: "assets/images/micro.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-4999-9999-199999999999"),
                column: "Background",
                value: "assets/images/silk.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("aaaa0000-aaaa-4aaa-8aaa-a00000000000"),
                column: "Background",
                value: "assets/images/swirl-art.png");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("bbbb0000-bbbb-4bbb-8bbb-b00000000000"),
                column: "Background",
                value: "assets/images/leaf.png");
        }
    }
}
