using NetCord;
using NetCord.Rest;
using NetCord.Services.ApplicationCommands;

namespace Esferas.Bot.Services
{
    public class DeleteMessagesService
    {
        private ApplicationCommandContext context;
        public DeleteMessagesService(ApplicationCommandContext context)
        {
            this.context = context;
        }
        public async Task DeleteMessagesAsync(int quantidade)
        {
            try
            {
                var messages = new List<RestMessage>();
                await foreach (var message in this.context.Channel.GetMessagesAsync())
                {
                    messages.Add(message);
                    if (messages.Count >= quantidade)
                        break;
                }

                var messagesIds = messages.Select(m => m.Id).ToList();

                await (this.context.Channel as TextChannel).DeleteMessagesAsync(messagesIds);
                await this.context.Interaction.SendResponseAsync(InteractionCallback.DeferredMessage(MessageFlags.Ephemeral));
                await this.context.Interaction.SendFollowupMessageAsync($"✅ {quantidade} mensagens foram apagadas com sucesso!");
            }
            catch (System.Exception ex)
            {
                await this.context.Interaction.SendResponseAsync(InteractionCallback.DeferredMessage(MessageFlags.Ephemeral));
                await this.context.Interaction.SendFollowupMessageAsync($"❌ Ocorreu um erro ao apagar as mensagens: {ex.Message}");
            }
        }
    }
}
