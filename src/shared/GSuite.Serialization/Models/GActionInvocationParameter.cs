using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GActionInvocationParameter : GValue
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

