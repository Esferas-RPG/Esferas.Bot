using System.Threading.Tasks;
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
        {
            try
            {
                var messages = new List<RestMessage>();
                await foreach (var message in Context.Channel.GetMessagesAsync())
                {
                    messages.Add(message);
                    if (messages.Count >= quantidade)
                        break;
                }

                var messagesIds = messages.Select(m => m.Id).ToList();

                await (Context.Channel as TextChannel).DeleteMessagesAsync(messagesIds);
                await Context.Interaction.SendResponseAsync(InteractionCallback.DeferredMessage(MessageFlags.Ephemeral));
                await Context.Interaction.SendFollowupMessageAsync($"✅ {quantidade} mensagens foram apagadas com sucesso!");
            }
            catch (System.Exception ex)
            {
                await Context.Interaction.SendResponseAsync(InteractionCallback.DeferredMessage(MessageFlags.Ephemeral));
                await Context.Interaction.SendFollowupMessageAsync($"❌ Ocorreu um erro ao apagar as mensagens: {ex.Message}");
            }
        }
    }
}
