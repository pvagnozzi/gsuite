namespace GSuite.Streamer;

public interface IStreamChannel : IDisposable
{
    bool IsConnected();

    void Connect();

    void Disconnect();

    void Send(byte[] data, int offset = 0, int length = 0);
}
