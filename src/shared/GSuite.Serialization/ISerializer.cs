namespace GSuite.Serialization;

public interface ISerializer
{
    TValue? Load<TValue>(Stream stream) where TValue : class;
    void Save<TValue>(Stream stream, TValue value) where TValue : class;
    Task<TValue?> LoadAsync<TValue>(Stream stream) where TValue : class;
    Task SaveAsync<TValue>(Stream stream, TValue value) where TValue : class;
}

