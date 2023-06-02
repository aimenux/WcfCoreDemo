using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace App;

public class SoapLoggingClientMessageInspector : IClientMessageInspector
{
    private readonly ISoapLogger _logger;

    public SoapLoggingClientMessageInspector(ISoapLogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public object BeforeSendRequest(ref Message request, IClientChannel channel)
    {
        var correlationId = Guid.NewGuid().ToString();
        _logger.LogMessage(correlationId, request);
        return correlationId;
    }

    public void AfterReceiveReply(ref Message reply, object correlationState)
    {
        var correlationId = correlationState.ToString();
        _logger.LogMessage(correlationId, reply);
    }
}