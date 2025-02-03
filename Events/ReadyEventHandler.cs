using Microsoft.Extensions.Logging;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Rest;

namespace Esferas.Bot.Events
{
    [GatewayEvent(nameof(GatewayClient.Ready))]
    public class ReadyEventHandler(ILogger<ReadyEventHandler> logger) : IGatewayEventHandler<ReadyEventArgs>
    {
        public ValueTask HandleAsync(ReadyEventArgs args)
        {
            logger.LogInformation("Bot iniciado");
            return default;
        }
    }
}
