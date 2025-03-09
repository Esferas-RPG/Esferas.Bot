using NetCord.Services.ApplicationCommands;

namespace Esferas.Bot.Modules
{
    [SlashCommand("ficha", "Controle de ficha")]
    public class SheetModule : ApplicationCommandModule<ApplicationCommandContext>
    {
        [SubSlashCommand("pedir", "Pedir ficha")]
        public string Pedir() => $"Comando de pedir ficha";

        [SubSlashCommand("aprovar", "Aprovar ficha")]
        public string Aprovar() => $"Comando de aprovar ficha";

        [SubSlashCommand("mover", "Mover ficha")]
        public string Mover() => $"Comando de mover ficha";

        [SubSlashCommand("deletar", "Deletar ficha")]
        public string Deletar() => $"Comando de deletar ficha";
    }
}
