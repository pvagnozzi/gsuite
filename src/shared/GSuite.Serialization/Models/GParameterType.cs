using System.Text.Json.Serialization;

namespace GSuite.Serialization.Models;

public record GParameterType : GTemplateObject
{
    [JsonPropertyName("mandatory")] public bool Mandatory { get; set; } = false;

    [JsonPropertyName("type")] public GType Type { get; set; } = GType.Text;

    [JsonPropertyName("default")] 
    public GValue? DefaultValue { get; set; }

    [JsonPropertyName("min")]
    public GValue? Min { get; set; }

    [JsonPropertyName("max")]
    public GValue? Max { get; set; }

    [JsonPropertyName("values")]
    public GValue[]? Values { get; set; }
}

