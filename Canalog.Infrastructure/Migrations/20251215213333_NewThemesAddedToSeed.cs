using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewThemesAddedToSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventColorSchemes",
                columns: new[] { "Id", "Blue", "Green", "Purple", "Red", "Yellow" },
                values: new object[,]
                {
                    { new Guid("cccc0000-eeee-4eee-8eee-000000000111"), "#3B82F6", "#22C55E", "#8B5CF6", "#EF4444", "#EAB308" },
                    { new Guid("dddd0000-ffff-4fff-8fff-000000000222"), "#60A5FA", "#4ADE80", "#A78BFA", "#F87171", "#FACC15" }
                });

            migrationBuilder.InsertData(
                table: "UiColorSchemes",
                columns: new[] { "Id", "Accent", "BackgroundColor", "CenterFill", "CenterStroke", "ClockHandPrimary", "ClockHandSecondary", "GlassHighlight", "GlassShadow", "TextPrimary", "TextSecondary", "TickPrimary", "TickSecondary" },
                values: new object[,]
                {
                    { new Guid("cccc0000-aaaa-4aaa-8aaa-000000000011"), "#3B82F6", "#FFFFFF", "#FFFFFF", "#1A1A1A", "#1A1A1A", "#5F6368", "rgba(255,255,255,0.85)", "rgba(0,0,0,0.12)", "#1A1A1A", "#5F6368", "#1A1A1A", "#C7C7C7" },
                    { new Guid("dddd0000-bbbb-4bbb-8bbb-000000000022"), "#22D3EE", "#0F1115", "#0F1115", "#EDEDED", "#EDEDED", "#9AA0A6", "rgba(255,255,255,0.10)", "rgba(0,0,0,0.65)", "#EDEDED", "#9AA0A6", "#EDEDED", "#3A3F45" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "Background", "EventColorSchemeId", "Name", "UiColorSchemeId" },
                values: new object[,]
                {
                    { new Guid("cccc0000-1111-4111-8111-000000000001"), "", new Guid("cccc0000-eeee-4eee-8eee-000000000111"), "Light Mode", new Guid("cccc0000-aaaa-4aaa-8aaa-000000000011") },
                    { new Guid("dddd0000-2222-4222-8222-000000000002"), "", new Guid("dddd0000-ffff-4fff-8fff-000000000222"), "Dark Mode", new Guid("dddd0000-bbbb-4bbb-8bbb-000000000022") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("cccc0000-1111-4111-8111-000000000001"));

            migrationBuilder.DeleteData(
                table: "Themes",
                keyColumn: "Id",
                keyValue: new Guid("dddd0000-2222-4222-8222-000000000002"));

            migrationBuilder.DeleteData(
                table: "EventColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("cccc0000-eeee-4eee-8eee-000000000111"));

            migrationBuilder.DeleteData(
                table: "EventColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("dddd0000-ffff-4fff-8fff-000000000222"));

            migrationBuilder.DeleteData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("cccc0000-aaaa-4aaa-8aaa-000000000011"));

            migrationBuilder.DeleteData(
                table: "UiColorSchemes",
                keyColumn: "Id",
                keyValue: new Guid("dddd0000-bbbb-4bbb-8bbb-000000000022"));
        }
    }
}
