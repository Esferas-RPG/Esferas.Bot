using NetCord.Services.ApplicationCommands;

namespace Esferas.Bot.Modules
{
    public class ExampleModule : ApplicationCommandModule<ApplicationCommandContext>
    {
        [SlashCommand("pong", "Pong!")]
        public static string Pong() => "Ping!";
    }
}
