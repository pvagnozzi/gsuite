using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GActionInvocation : GTemplateObject
{
    [JsonPropertyName("action")]
    public string? ActionName { get; set; }

    [JsonPropertyName("parameters")]
    public GActionInvocationParameter[]? Parameters { get; set; }
}

