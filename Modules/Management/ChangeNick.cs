using NetCord;
using NetCord.Services.ApplicationCommands;

namespace Esferas.Bot.Modules
{
    [SlashCommand("mudar", "Comando para mudar")]
    public class ChangeNick : ApplicationCommandModule<ApplicationCommandContext>
    {
        [SubSlashCommand("nickname", "Mudar nickname")]
        public string NickName(User? user = null)
        {
            user ??= Context.User;
            return user.Username;
        }
    }
}
