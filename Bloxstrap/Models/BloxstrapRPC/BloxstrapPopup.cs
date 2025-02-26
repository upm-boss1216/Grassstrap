namespace Bloxstrap.Models.BloxstrapRPC;

class BloxstrapPopup
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }
}