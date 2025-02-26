namespace Bloxstrap.Models.BloxstrapRPC;

class BloxstrapNotification
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}