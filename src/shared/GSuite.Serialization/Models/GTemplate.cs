using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GTemplate : GTemplateObject
{
    [JsonPropertyName("boxes")]
    public GBox[]? Boxes { get; set; }

    [JsonPropertyName("actions")]
    public GActionInvocation[]? Actions { get; set; }
}

