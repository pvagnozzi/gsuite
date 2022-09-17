using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GParameter : GTemplateObject
{
    [JsonPropertyName("type")]
    public GParameterType? Type { get; set; }
}

