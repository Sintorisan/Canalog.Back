using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventColorSchemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Red = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Green = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yellow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purple = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventColorSchemes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UiColorSchemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextSecondary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClockHandSecondary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TickPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TickSecondary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlassHighlight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlassShadow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenterFill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenterStroke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UiColorSchemes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GoogleId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UiColorSchemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventColorSchemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Themes_EventColorSchemes_EventColorSchemeId",
                        column: x => x.EventColorSchemeId,
                        principalTable: "EventColorSchemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Themes_UiColorSchemes_UiColorSchemeId",
                        column: x => x.UiColorSchemeId,
                        principalTable: "UiColorSchemes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFormat = table.Column<int>(type: "int", nullable: false),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Options_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EventColorSchemes",
                columns: new[] { "Id", "Blue", "Green", "Purple", "Red", "Yellow" },
                values: new object[,]
                {
                    { new Guid("11111111-eeee-4eee-8eee-111111111111"), "#3E6E95", "#4C9A53", "#6A4E82", "#A24444", "#C7B66D" },
                    { new Guid("22222222-ffff-4fff-8fff-222222222222"), "#9EB7F3", "#A8E6C6", "#C39AED", "#E09AA7", "#F7E7A5" },
                    { new Guid("33333333-aaaa-4aaa-8aaa-333333333333"), "#00C8F0", "#2DE07B", "#B24CFF", "#FF3366", "#FFD739" },
                    { new Guid("44444444-bbbb-4bbb-8bbb-444444444444"), "#45A6FD", "#2FDE9E", "#B07BFF", "#FF4F6D", "#FADF6A" },
                    { new Guid("55555555-cccc-4ccc-8ccc-555555555555"), "#7FA7BF", "#9DBF7A", "#A68CAF", "#C7654E", "#D7C678" },
                    { new Guid("66666666-dddd-4ddd-8ddd-666666666666"), "#5779FF", "#2BFF78", "#D33BFF", "#FF2B2B", "#FFD02C" },
                    { new Guid("77777777-eeee-4eee-8eee-777777777777"), "#4E9CE6", "#5EC97A", "#A47CCD", "#C95E5E", "#E6D45A" },
                    { new Guid("88888888-eeee-4eee-8eee-888888888222"), "#3AB8FF", "#38E8A4", "#C07CFF", "#FF5A7A", "#FFC85A" },
                    { new Guid("99999999-ffff-4fff-8fff-999999999222"), "#6DA4FF", "#77E5C2", "#C07BFF", "#FF7AA3", "#FFE072" },
                    { new Guid("aaaa0000-dddd-4ddd-8ddd-a00000000022"), "#5A93C9", "#5EC46A", "#A64CC7", "#E44733", "#F7CF47" },
                    { new Guid("bbbb0000-dddd-4ddd-8ddd-b00000000022"), "#4E9CD6", "#4AD47F", "#A886D6", "#D96A68", "#F0DE67" }
                });

            migrationBuilder.InsertData(
                table: "UiColorSchemes",
                columns: new[] { "Id", "Accent", "BackgroundColor", "CenterFill", "CenterStroke", "ClockHandSecondary", "GlassHighlight", "GlassShadow", "TextPrimary", "TextSecondary", "TickPrimary", "TickSecondary" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-4aaa-8aaa-111111111111"), "#88B48D", "#C7D9C5", "#2E4A2F", "#1B331C", "#2F5A30", "rgba(255,255,255,0.35)", "rgba(20,40,20,0.35)", "#1E3A1F", "#4A6B4C", "#2C4C2D", "#7EA884" },
                    { new Guid("22222222-bbbb-4bbb-8bbb-222222222222"), "#F4B2C7", "#F3EAF7", "#7E6FB6", "#5C4A92", "#7B6CA8", "rgba(255,255,255,0.50)", "rgba(120,100,160,0.28)", "#5A4D7A", "#A28CC2", "#6A5E93", "#B8A7D6" },
                    { new Guid("33333333-cccc-4ccc-8ccc-333333333333"), "#FF4BC2", "#1A1A26", "#FFD766", "#CCAA44", "#FFD766", "rgba(255,255,255,0.25)", "rgba(0,0,0,0.45)", "#FFFFFF", "#D2D2D2", "#FFFFFF", "#A1A1A1" },
                    { new Guid("44444444-dddd-4ddd-8ddd-444444444444"), "#7FE5DB", "#0E1B1A", "#0D4F4F", "#0B3636", "#68C8C8", "rgba(255,255,255,0.20)", "rgba(0,0,0,0.55)", "#CFFDFE", "#8ED3D9", "#C8F4F4", "#6ABEBE" },
                    { new Guid("55555555-eeee-4eee-8eee-555555555555"), "#CBA76F", "#E3C9A8", "#8E6B48", "#5B4029", "#A07852", "rgba(255,255,255,0.22)", "rgba(60,40,20,0.35)", "#4E3A28", "#8E745D", "#4E3A28", "#A88C6E" },
                    { new Guid("66666666-ffff-4fff-8fff-666666666666"), "#FF6A4A", "#1A0000", "#FF1A1A", "#B30000", "#FF4545", "rgba(255,255,255,0.20)", "rgba(255,0,0,0.35)", "#FFDADA", "#EBA0A0", "#FFE0E0", "#FF9C9C" },
                    { new Guid("77777777-aaaa-4aaa-8aaa-777777777777"), "#53C49A", "#F3EDE3", "#3C6A50", "#244434", "#4FA781", "rgba(255,255,255,0.35)", "rgba(40,70,50,0.25)", "#2F503C", "#6A8F77", "#2F503C", "#90B8A0" },
                    { new Guid("88888888-aaaa-4aaa-8aaa-888888888111"), "#FF7DE3", "#0A1C25", "#FFB75E", "#CC8E3C", "#57D5FF", "rgba(255,255,255,0.25)", "rgba(0,0,0,0.55)", "#E6F7FF", "#9AC6D9", "#D6F3FF", "#7ECDE4" },
                    { new Guid("99999999-bbbb-4bbb-8bbb-999999999111"), "#CB8FFF", "#0D0A24", "#7C4BFF", "#4E2BBF", "#A883FF", "rgba(255,255,255,0.22)", "rgba(40,0,80,0.45)", "#ECE6FF", "#B8A9E6", "#EFE8FF", "#B9A4FF" },
                    { new Guid("aaaa0000-cccc-4ccc-8ccc-a00000000011"), "#E86F1A", "#F2D27A", "#C24F33", "#8C3A24", "#B03C2E", "rgba(255,255,255,0.32)", "rgba(100,50,20,0.35)", "#4B2A24", "#7F4A3E", "#4B2A24", "#D9A563" },
                    { new Guid("bbbb0000-cccc-4ccc-8ccc-b00000000011"), "#59EBA4", "#0A1F0E", "#1D5E32", "#123D21", "#4EC47E", "rgba(255,255,255,0.20)", "rgba(0,40,10,0.40)", "#CFFFE1", "#86D9A8", "#CFFFE1", "#89D2A2" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "Background", "EventColorSchemeId", "Name", "UiColorSchemeId" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-4111-8111-111111111111"), "assets/images/leafs.png", new Guid("11111111-eeee-4eee-8eee-111111111111"), "Leaf Forest", new Guid("11111111-aaaa-4aaa-8aaa-111111111111") },
                    { new Guid("22222222-2222-4222-8222-222222222222"), "assets/images/clouds.png", new Guid("22222222-ffff-4fff-8fff-222222222222"), "Pastel Clouds", new Guid("22222222-bbbb-4bbb-8bbb-222222222222") },
                    { new Guid("33333333-3333-4333-8333-333333333333"), "assets/images/color-burst.png", new Guid("33333333-aaaa-4aaa-8aaa-333333333333"), "Color Burst", new Guid("33333333-cccc-4ccc-8ccc-333333333333") },
                    { new Guid("44444444-4444-4444-8444-444444444444"), "assets/images/deep-sea.png", new Guid("44444444-bbbb-4bbb-8bbb-444444444444"), "Deep Sea", new Guid("44444444-dddd-4ddd-8ddd-444444444444") },
                    { new Guid("55555555-5555-4555-8555-555555555555"), "assets/images/desert.png", new Guid("55555555-cccc-4ccc-8ccc-555555555555"), "Desert Earth", new Guid("55555555-eeee-4eee-8eee-555555555555") },
                    { new Guid("66666666-6666-4666-8666-666666666666"), "assets/images/flame.png", new Guid("66666666-dddd-4ddd-8ddd-666666666666"), "Molten Flame", new Guid("66666666-ffff-4fff-8fff-666666666666") },
                    { new Guid("77777777-7777-4777-8777-777777777777"), "assets/images/flowerpots.png", new Guid("77777777-eeee-4eee-8eee-777777777777"), "Indoor Jungle", new Guid("77777777-aaaa-4aaa-8aaa-777777777777") },
                    { new Guid("88888888-8888-4888-8888-188888888888"), "assets/images/micro.png", new Guid("88888888-eeee-4eee-8eee-888888888222"), "Micro Cosmos", new Guid("88888888-aaaa-4aaa-8aaa-888888888111") },
                    { new Guid("99999999-9999-4999-9999-199999999999"), "assets/images/silk.png", new Guid("99999999-ffff-4fff-8fff-999999999222"), "Silk Waves", new Guid("99999999-bbbb-4bbb-8bbb-999999999111") },
                    { new Guid("aaaa0000-aaaa-4aaa-8aaa-a00000000000"), "assets/images/swirl-art.png", new Guid("aaaa0000-dddd-4ddd-8ddd-a00000000022"), "Warm Swirl", new Guid("aaaa0000-cccc-4ccc-8ccc-a00000000011") },
                    { new Guid("bbbb0000-bbbb-4bbb-8bbb-b00000000000"), "assets/images/leaf.png", new Guid("bbbb0000-dddd-4ddd-8ddd-b00000000022"), "Deep Leaf", new Guid("bbbb0000-cccc-4ccc-8ccc-b00000000011") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ThemeId",
                table: "Options",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_UserId",
                table: "Options",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Themes_EventColorSchemeId",
                table: "Themes",
                column: "EventColorSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_UiColorSchemeId",
                table: "Themes",
                column: "UiColorSchemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EventColorSchemes");

            migrationBuilder.DropTable(
                name: "UiColorSchemes");
        }
    }
}
