using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GTemplateObject
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

