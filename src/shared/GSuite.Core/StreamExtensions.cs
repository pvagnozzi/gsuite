namespace GSuite.Core;

public static class GStreamExtensions
{
    public static string ReadAsString(this Stream stream)
    {
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }

    public static void Write(this Stream stream, string value)
    {
        using var writer = new StreamWriter(stream);
        writer.Write(value);
    }

    public static Task<string> ReadAsStringAsync(this Stream stream)
    {
        using var reader = new StreamReader(stream);
        return reader.ReadToEndAsync();
    }

    public static Task WriteAsync(this Stream stream, string value)
    {
        using var writer = new StreamWriter(stream);
        return writer.WriteAsync(value);
    }

}

