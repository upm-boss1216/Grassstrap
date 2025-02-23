namespace Bloxstrap.Models.BloxstrapRPC;

public class WindowTransparency
{
    [JsonPropertyName("transparency")]
    public float? Transparency { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }
}
