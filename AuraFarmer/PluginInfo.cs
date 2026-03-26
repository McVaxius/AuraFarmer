namespace AuraFarmer;

internal static class PluginInfo
{
    public const string DisplayName = "Aura Farmer";
    public const string InternalName = "AuraFarmer";
    public const string Command = "/aurafarmer";
    public const string Visibility = "Public";
    public const string Summary = "Cross-client commendation and Astrope farming scaffold.";
    public const string SupportUrl = "https://ko-fi.com/mcvaxius";
    public static readonly string[] Concept = new[]
    {
        "Reuse localhost coordination patterns.",
        "Keep commendation and Astrope modes separate.",
        "Expose targets and queue policy early."
    };
    public static readonly string[] Services = new[]
    {
        "ConfigManager",
        "ILocalPeerTransport",
        "NamedPipePeerTransport",
        "PresenceService",
        "ReadinessService",
        "QueueAuthorityService",
        "CommendationModeService",
        "AstropeModeService"
    };
    public static readonly string[] Phases = new[]
    {
        "Shell and docs",
        "Presence and authority",
        "Commendation mode",
        "Astrope mode",
        "Polish"
    };
    public static readonly string[] Tests = new[]
    {
        "Load plugin and open UI",
        "Confirm account and character profile creation",
        "Save profile notes"
    };
}
