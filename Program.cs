using Esferas.Bot.Services;
using Microsoft.Extensions.Hosting;

namespace Esferas.Bot
{
    public class Program
    {
        public static async Task Main(string[] args)
            => await BotService.HostBuilder(args).RunAsync();
    }
}
