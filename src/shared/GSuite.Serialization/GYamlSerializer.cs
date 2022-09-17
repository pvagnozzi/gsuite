using GSuite.Core;
using YamlDotNet.Serialization;

namespace GSuite.Serialization;

public sealed class GYamlSerializer : GSerializer
{
    private static string Serialize<TValue>(TValue value) where TValue : class =>
        new Serializer().Serialize(value);

    private static TValue? Deserialize<TValue>(string text) where TValue : class =>
        !string.IsNullOrEmpty(text) ? new Deserializer().Deserialize<TValue>(text) : null;

    public override TValue? Load<TValue>(Stream stream) where TValue : class =>
        Deserialize<TValue>(stream.ReadAsString());

    public override void Save<TValue>(Stream stream, TValue value) where TValue : class =>
        stream.Write(Serialize(value));

    public override async Task<TValue?> LoadAsync<TValue>(Stream stream) where TValue : class =>
        Deserialize<TValue>(await stream.ReadAsStringAsync());

    public override Task SaveAsync<TValue>(Stream stream, TValue value) where TValue : class => 
        stream.WriteAsync(Serialize(value));
}

