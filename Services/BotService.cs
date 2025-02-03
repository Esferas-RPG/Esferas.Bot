using Microsoft.Extensions.Hosting;
using NetCord.Gateway;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;

namespace Esferas.Bot.Services
{
    public class BotService
    {
        public static IHost HostBuilder(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddDiscordGateway(options =>
                {
                    options.Intents = GatewayIntents.All;
                })
                .AddGatewayEventHandlers(typeof(Program).Assembly)
                .AddApplicationCommands();

            return builder.Build()
                .AddModules(typeof(Program).Assembly)
                .UseGatewayEventHandlers();
        }
    }
}
