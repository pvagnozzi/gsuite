namespace GSuite.Serialization;

public abstract class GSerializer : ISerializer
{
    public abstract TValue? Load<TValue>(Stream stream) where TValue : class;

    public abstract void Save<TValue>(Stream stream, TValue value) where TValue : class;

    public abstract Task<TValue?> LoadAsync<TValue>(Stream stream) where TValue : class;

    public abstract Task SaveAsync<TValue>(Stream stream, TValue value) where TValue : class;
}

