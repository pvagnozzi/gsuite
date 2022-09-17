using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GValue
{
    [JsonIgnore]
    public object? Value { get; set; }

    [JsonPropertyName("type")]
    public GType Type { get; set; }

    [JsonPropertyName("value")]
    public string? RawValue { get; set; }
}

