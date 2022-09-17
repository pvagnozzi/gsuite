using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GAction : GTemplateObject
{
    [JsonPropertyName("parameters")]
    public GParameter[]? Parameters { get; set; }
}

