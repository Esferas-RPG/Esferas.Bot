using System.Threading.Tasks;
using Esferas.Bot.Services;
using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Esferas.Bot.Modules.Management
{
    public class DeleteMessageModule : ApplicationCommandModule<ApplicationCommandContext>
    {
        [SlashCommand("apagar_messagens", "Apagar mensagens do canal",
            DefaultGuildUserPermissions = Permissions.ManageMessages,
            Contexts = [InteractionContextType.Guild])]
        public async Task DeleteMessages(int quantidade)
            => await new DeleteMessagesService(Context).DeleteMessagesAsync(quantidade);

    }
}
