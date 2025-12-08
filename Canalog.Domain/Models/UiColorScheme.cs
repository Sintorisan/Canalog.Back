namespace Canalog.Domain.Models
{
    public class UiColorScheme
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string BackgroundColor { get; set; } = string.Empty;
        public string TextPrimary { get; set; } = string.Empty;
        public string ClockHandColor { get; set; } = string.Empty;
        public string CenterFill { get; set; } = string.Empty;
        public string CenterStroke { get; set; } = string.Empty;
        public string Accent { get; set; } = string.Empty;
    }
}
