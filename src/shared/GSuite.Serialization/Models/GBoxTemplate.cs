using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GBoxTemplate : GTemplateObject
{
    [JsonPropertyName("boxes")]
    public GBox[]? Boxes { get; set; }
}

