using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GBox : GTemplateObject
{
    [JsonPropertyName("position")]
    public int Position { get; set; }
}

