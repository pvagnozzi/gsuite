using System.Diagnostics.Contracts;
using System.Text.Json;

namespace GSuite.Serialization;

public sealed class GJsonSerializer : GSerializer
{
    private static readonly JsonSerializerOptions Options = new();

    public override TValue? Load<TValue>(Stream stream) where TValue : class
    {
        Contract.Requires(stream is not null);
        return JsonSerializer.Deserialize<TValue>(stream!, Options);
    }

    public override void Save<TValue>(Stream stream, TValue value) where TValue : class
    {
        Contract.Requires(stream is not null);
        JsonSerializer.Serialize<TValue>(stream!, value, Options);
    }

    public override async Task<TValue?> LoadAsync<TValue>(Stream stream) where TValue : class
    {
        Contract.Requires(stream is not null);
        return await JsonSerializer.DeserializeAsync<TValue>(stream!, Options).ConfigureAwait(false);
    }

    public override Task SaveAsync<TValue>(Stream stream, TValue value) where TValue : class
    {
        Contract.Requires(stream is not null);
        return JsonSerializer.SerializeAsync<TValue>(stream!, value, Options);
    }
}

