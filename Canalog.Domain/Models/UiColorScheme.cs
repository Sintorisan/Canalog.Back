namespace Canalog.Domain.Models
{
    public class UiColorScheme
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string BackgroundColor { get; set; } = string.Empty;
        public string TextPrimary { get; set; } = string.Empty;
        public string TextSecondary { get; set; } = string.Empty;
        public string ClockHandSecondary { get; set; } = string.Empty;
        public string TickPrimary { get; set; } = string.Empty;
        public string TickSecondary { get; set; } = string.Empty;
        public string GlassHighlight { get; set; } = string.Empty;
        public string GlassShadow { get; set; } = string.Empty;
        public string CenterFill { get; set; } = string.Empty;
        public string CenterStroke { get; set; } = string.Empty;
        public string Accent { get; set; } = string.Empty;
    }
}
