using System.ServiceModel.Channels;

namespace App;

public interface ISoapLogger
{
    void LogMessage<T>(string correlationId, T message) where T : Message;
}

public class SoapLogger : ISoapLogger
{
    public void LogMessage<T>(string correlationId, T message) where T : Message
    {
        if (message == null) return;
        var date = DateTimeOffset.Now.ToString("s");
        Console.WriteLine($"[{date}] [{correlationId}] {Environment.NewLine}{message}");
    }
}