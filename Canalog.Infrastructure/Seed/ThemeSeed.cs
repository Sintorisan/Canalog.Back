using Canalog.Domain;
using Canalog.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Canalog.Infrastructure.Seed;

public static class ThemeSeed
{
    public static void SeedThemes(this ModelBuilder modelBuilder)
    {
        // ================================
        // FIXED GUIDS
        // ================================
        var leafId = Guid.Parse("11111111-1111-4111-8111-111111111111");
        var cloudId = Guid.Parse("22222222-2222-4222-8222-222222222222");
        var burstId = Guid.Parse("33333333-3333-4333-8333-333333333333");
        var seaId = Guid.Parse("44444444-4444-4444-8444-444444444444");
        var desertId = Guid.Parse("55555555-5555-4555-8555-555555555555");
        var flameId = Guid.Parse("66666666-6666-4666-8666-666666666666");
        var jungleId = Guid.Parse("77777777-7777-4777-8777-777777777777");
        var microId = Guid.Parse("88888888-8888-4888-8888-188888888888");
        var silkId = Guid.Parse("99999999-9999-4999-9999-199999999999");
        var swirlId = Guid.Parse("AAAA0000-AAAA-4AAA-8AAA-A00000000000");
        var deepLeafId = Guid.Parse("BBBB0000-BBBB-4BBB-8BBB-B00000000000");

        var uiLeafId = Guid.Parse("11111111-AAAA-4AAA-8AAA-111111111111");
        var uiCloudId = Guid.Parse("22222222-BBBB-4BBB-8BBB-222222222222");
        var uiBurstId = Guid.Parse("33333333-CCCC-4CCC-8CCC-333333333333");
        var uiSeaId = Guid.Parse("44444444-DDDD-4DDD-8DDD-444444444444");
        var uiDesertId = Guid.Parse("55555555-EEEE-4EEE-8EEE-555555555555");
        var uiFlameId = Guid.Parse("66666666-FFFF-4FFF-8FFF-666666666666");
        var uiJungleId = Guid.Parse("77777777-AAAA-4AAA-8AAA-777777777777");
        var uiMicroId = Guid.Parse("88888888-AAAA-4AAA-8AAA-888888888111");
        var uiSilkId = Guid.Parse("99999999-BBBB-4BBB-8BBB-999999999111");
        var uiSwirlId = Guid.Parse("AAAA0000-CCCC-4CCC-8CCC-A00000000011");
        var uiDeepLeafId = Guid.Parse("BBBB0000-CCCC-4CCC-8CCC-B00000000011");

        var evtLeafId = Guid.Parse("11111111-EEEE-4EEE-8EEE-111111111111");
        var evtCloudId = Guid.Parse("22222222-FFFF-4FFF-8FFF-222222222222");
        var evtBurstId = Guid.Parse("33333333-AAAA-4AAA-8AAA-333333333333");
        var evtSeaId = Guid.Parse("44444444-BBBB-4BBB-8BBB-444444444444");
        var evtDesertId = Guid.Parse("55555555-CCCC-4CCC-8CCC-555555555555");
        var evtFlameId = Guid.Parse("66666666-DDDD-4DDD-8DDD-666666666666");
        var evtJungleId = Guid.Parse("77777777-EEEE-4EEE-8EEE-777777777777");
        var evtMicroId = Guid.Parse("88888888-EEEE-4EEE-8EEE-888888888222");
        var evtSilkId = Guid.Parse("99999999-FFFF-4FFF-8FFF-999999999222");
        var evtSwirlId = Guid.Parse("AAAA0000-DDDD-4DDD-8DDD-A00000000022");
        var evtDeepLeafId = Guid.Parse("BBBB0000-DDDD-4DDD-8DDD-B00000000022");


        // ================================
        // UI COLOR SCHEMES
        // ================================
        modelBuilder.Entity<UiColorScheme>().HasData(
            new UiColorScheme { Id = uiLeafId, BackgroundColor = "#C7D9C5", TextPrimary = "#1E3A1F", TextSecondary = "#4A6B4C", ClockHandSecondary = "#2F5A30", TickPrimary = "#2C4C2D", TickSecondary = "#7EA884", GlassHighlight = "rgba(255,255,255,0.35)", GlassShadow = "rgba(20,40,20,0.35)", CenterFill = "#2E4A2F", CenterStroke = "#1B331C", Accent = "#88B48D" },
            new UiColorScheme
            {
                Id = uiCloudId,
                BackgroundColor = "#F3EAF7",
                TextPrimary = "#5A4D7A",
                TextSecondary = "#A28CC2",
                ClockHandSecondary = "#7B6CA8",
                TickPrimary = "#6A5E93",
                TickSecondary = "#B8A7D6",
                GlassHighlight = "rgba(255,255,255,0.50)",
                GlassShadow = "rgba(120,100,160,0.28)",
                CenterFill = "#7E6FB6",
                CenterStroke = "#5C4A92",
                Accent = "#F4B2C7"
            },
            new UiColorScheme
            {
                Id = uiBurstId,
                BackgroundColor = "#1A1A26",
                TextPrimary = "#FFFFFF",
                TextSecondary = "#D2D2D2",
                ClockHandSecondary = "#FFD766",
                TickPrimary = "#FFFFFF",
                TickSecondary = "#A1A1A1",
                GlassHighlight = "rgba(255,255,255,0.25)",
                GlassShadow = "rgba(0,0,0,0.45)",
                CenterFill = "#FFD766",
                CenterStroke = "#CCAA44",
                Accent = "#FF4BC2"
            },
            new UiColorScheme
            {
                Id = uiSeaId,
                BackgroundColor = "#0E1B1A",
                TextPrimary = "#CFFDFE",
                TextSecondary = "#8ED3D9",
                ClockHandSecondary = "#68C8C8",
                TickPrimary = "#C8F4F4",
                TickSecondary = "#6ABEBE",
                GlassHighlight = "rgba(255,255,255,0.20)",
                GlassShadow = "rgba(0,0,0,0.55)",
                CenterFill = "#0D4F4F",
                CenterStroke = "#0B3636",
                Accent = "#7FE5DB"
            },
            new UiColorScheme
            {
                Id = uiDesertId,
                BackgroundColor = "#E3C9A8",
                TextPrimary = "#4E3A28",
                TextSecondary = "#8E745D",
                ClockHandSecondary = "#A07852",
                TickPrimary = "#4E3A28",
                TickSecondary = "#A88C6E",
                GlassHighlight = "rgba(255,255,255,0.22)",
                GlassShadow = "rgba(60,40,20,0.35)",
                CenterFill = "#8E6B48",
                CenterStroke = "#5B4029",
                Accent = "#CBA76F"
            },
            new UiColorScheme
            {
                Id = uiFlameId,
                BackgroundColor = "#1A0000",
                TextPrimary = "#FFDADA",
                TextSecondary = "#EBA0A0",
                ClockHandSecondary = "#FF4545",
                TickPrimary = "#FFE0E0",
                TickSecondary = "#FF9C9C",
                GlassHighlight = "rgba(255,255,255,0.20)",
                GlassShadow = "rgba(255,0,0,0.35)",
                CenterFill = "#FF1A1A",
                CenterStroke = "#B30000",
                Accent = "#FF6A4A"
            },
            new UiColorScheme
            {
                Id = uiJungleId,
                BackgroundColor = "#F3EDE3",
                TextPrimary = "#2F503C",
                TextSecondary = "#6A8F77",
                ClockHandSecondary = "#4FA781",
                TickPrimary = "#2F503C",
                TickSecondary = "#90B8A0",
                GlassHighlight = "rgba(255,255,255,0.35)",
                GlassShadow = "rgba(40,70,50,0.25)",
                CenterFill = "#3C6A50",
                CenterStroke = "#244434",
                Accent = "#53C49A"
            },
            new UiColorScheme
            {
                Id = uiMicroId,
                BackgroundColor = "#0A1C25",
                TextPrimary = "#E6F7FF",
                TextSecondary = "#9AC6D9",
                ClockHandSecondary = "#57D5FF",
                TickPrimary = "#D6F3FF",
                TickSecondary = "#7ECDE4",
                GlassHighlight = "rgba(255,255,255,0.25)",
                GlassShadow = "rgba(0,0,0,0.55)",
                CenterFill = "#FFB75E",
                CenterStroke = "#CC8E3C",
                Accent = "#FF7DE3"
            },
            new UiColorScheme
            {
                Id = uiSilkId,
                BackgroundColor = "#0D0A24",
                TextPrimary = "#ECE6FF",
                TextSecondary = "#B8A9E6",
                ClockHandSecondary = "#A883FF",
                TickPrimary = "#EFE8FF",
                TickSecondary = "#B9A4FF",
                GlassHighlight = "rgba(255,255,255,0.22)",
                GlassShadow = "rgba(40,0,80,0.45)",
                CenterFill = "#7C4BFF",
                CenterStroke = "#4E2BBF",
                Accent = "#CB8FFF"
            },
            new UiColorScheme
            {
                Id = uiSwirlId,
                BackgroundColor = "#F2D27A",
                TextPrimary = "#4B2A24",
                TextSecondary = "#7F4A3E",
                ClockHandSecondary = "#B03C2E",
                TickPrimary = "#4B2A24",
                TickSecondary = "#D9A563",
                GlassHighlight = "rgba(255,255,255,0.32)",
                GlassShadow = "rgba(100,50,20,0.35)",
                CenterFill = "#C24F33",
                CenterStroke = "#8C3A24",
                Accent = "#E86F1A"
            },
            new UiColorScheme
            {
                Id = uiDeepLeafId,
                BackgroundColor = "#0A1F0E",
                TextPrimary = "#CFFFE1",
                TextSecondary = "#86D9A8",
                ClockHandSecondary = "#4EC47E",
                TickPrimary = "#CFFFE1",
                TickSecondary = "#89D2A2",
                GlassHighlight = "rgba(255,255,255,0.20)",
                GlassShadow = "rgba(0,40,10,0.40)",
                CenterFill = "#1D5E32",
                CenterStroke = "#123D21",
                Accent = "#59EBA4"
            }
        );

        // ================================
        // EVENT COLOR SCHEMES
        // ================================
        modelBuilder.Entity<EventColorScheme>().HasData(
            new EventColorScheme { Id = evtLeafId, Red = "#A24444", Blue = "#3E6E95", Green = "#4C9A53", Yellow = "#C7B66D", Purple = "#6A4E82" },
            new EventColorScheme { Id = evtCloudId, Red = "#E09AA7", Blue = "#9EB7F3", Green = "#A8E6C6", Yellow = "#F7E7A5", Purple = "#C39AED" },
            new EventColorScheme { Id = evtBurstId, Red = "#FF3366", Blue = "#00C8F0", Green = "#2DE07B", Yellow = "#FFD739", Purple = "#B24CFF" },
            new EventColorScheme { Id = evtSeaId, Red = "#FF4F6D", Blue = "#45A6FD", Green = "#2FDE9E", Yellow = "#FADF6A", Purple = "#B07BFF" },
            new EventColorScheme { Id = evtDesertId, Red = "#C7654E", Blue = "#7FA7BF", Green = "#9DBF7A", Yellow = "#D7C678", Purple = "#A68CAF" },
            new EventColorScheme { Id = evtFlameId, Red = "#FF2B2B", Blue = "#5779FF", Green = "#2BFF78", Yellow = "#FFD02C", Purple = "#D33BFF" },
            new EventColorScheme { Id = evtJungleId, Red = "#C95E5E", Blue = "#4E9CE6", Green = "#5EC97A", Yellow = "#E6D45A", Purple = "#A47CCD" },
            new EventColorScheme { Id = evtMicroId, Red = "#FF5A7A", Blue = "#3AB8FF", Green = "#38E8A4", Yellow = "#FFC85A", Purple = "#C07CFF" },
            new EventColorScheme { Id = evtSilkId, Red = "#FF7AA3", Blue = "#6DA4FF", Green = "#77E5C2", Yellow = "#FFE072", Purple = "#C07BFF" },
            new EventColorScheme { Id = evtSwirlId, Red = "#E44733", Blue = "#5A93C9", Green = "#5EC46A", Yellow = "#F7CF47", Purple = "#A64CC7" },
            new EventColorScheme { Id = evtDeepLeafId, Red = "#D96A68", Blue = "#4E9CD6", Green = "#4AD47F", Yellow = "#F0DE67", Purple = "#A886D6" }
        );

        // ================================
        // THEMES
        // ================================
        modelBuilder.Entity<Theme>().HasData(
            new Theme { Id = leafId, Name = "Leaf Forest", Background = "src/assets/images/leafs.png", UiColorSchemeId = uiLeafId, EventColorSchemeId = evtLeafId },
            new Theme { Id = cloudId, Name = "Pastel Clouds", Background = "src/assets/images/clouds.png", UiColorSchemeId = uiCloudId, EventColorSchemeId = evtCloudId },
            new Theme { Id = burstId, Name = "Color Burst", Background = "src/assets/images/color-burst.png", UiColorSchemeId = uiBurstId, EventColorSchemeId = evtBurstId },
            new Theme { Id = seaId, Name = "Deep Sea", Background = "src/assets/images/deep-sea.png", UiColorSchemeId = uiSeaId, EventColorSchemeId = evtSeaId },
            new Theme { Id = desertId, Name = "Desert Earth", Background = "src/assets/images/desert.png", UiColorSchemeId = uiDesertId, EventColorSchemeId = evtDesertId },
            new Theme { Id = flameId, Name = "Molten Flame", Background = "src/assets/images/flame.png", UiColorSchemeId = uiFlameId, EventColorSchemeId = evtFlameId },
            new Theme { Id = jungleId, Name = "Indoor Jungle", Background = "src/assets/images/flowerpots.png", UiColorSchemeId = uiJungleId, EventColorSchemeId = evtJungleId },
            new Theme { Id = microId, Name = "Micro Cosmos", Background = "src/assets/images/micro.png", UiColorSchemeId = uiMicroId, EventColorSchemeId = evtMicroId },
            new Theme { Id = silkId, Name = "Silk Waves", Background = "src/assets/images/silk.png", UiColorSchemeId = uiSilkId, EventColorSchemeId = evtSilkId },
            new Theme { Id = swirlId, Name = "Warm Swirl", Background = "src/assets/images/swirl-art.png", UiColorSchemeId = uiSwirlId, EventColorSchemeId = evtSwirlId },
            new Theme { Id = deepLeafId, Name = "Deep Leaf", Background = "src/assets/images/leaf.png", UiColorSchemeId = uiDeepLeafId, EventColorSchemeId = evtDeepLeafId }
        );
    }
}
