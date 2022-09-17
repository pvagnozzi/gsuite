using System.Diagnostics.Contracts;

namespace GSuite.GCode;

public class GCodeWriter : IDisposable, IAsyncDisposable
{
    private readonly StreamWriter _streamWriter;

    public GCodeWriter(StreamWriter streamWriter)
    {
        Contract.Requires(streamWriter is not null);
        _streamWriter = streamWriter!;
    }

    public GCodeWriter(Stream stream)
        : this(new StreamWriter(stream))
    {
    }

    public async Task<GCodeWriter> WriteLine(string value)
    {
        await _streamWriter.WriteAsync(value);
        return this;
    }

    public void Dispose()
    {
        _streamWriter.Dispose();
        GC.SuppressFinalize(this);
    }

    public async ValueTask DisposeAsync()
    {
        await _streamWriter.DisposeAsync();
        GC.SuppressFinalize(this);
    }
}

