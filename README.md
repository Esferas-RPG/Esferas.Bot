# Esferas Discord Bot

Este é um bot do Discord desenvolvido com [NetCord](https://netcord.dev/), uma biblioteca moderna para interagir com a API do Discord de forma eficiente e flexível.

## Recursos

-   Comandos de slash (/) totalmente configuráveis.
-   Respostas dinâmicas e interativas.
-   Suporte a eventos do Discord.
-   Estrutura modular para facilitar a expansão.

## Requisitos

-   .NET 7+
-   Um bot registrado no [Discord Developer Portal](https://discord.com/developers/applications)
-   Token do bot

## Instalação

1. Clone este repositório:

    ```sh
    git clone https://github.com/seu-usuario/seu-repositorio.git
    cd seu-repositorio
    ```

2. Instale as dependências:

    ```sh
    dotnet restore
    ```

3. Crie um arquivo `appsettings.json` e defina o token do bot:
    ```json
    {
    	"Discord": {
    		"Token": "seu-token-aqui"
    	}
    }
    ```

## Uso

Para iniciar o bot, execute:

```sh
dotnet run
```

## Exemplo de Comando

Aqui está um exemplo de um comando de ping usando NetCord e C#:

```csharp
using NetCord.Services.ApplicationCommands;

public class ExampleModule : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("ping", "Pong!")]
    public static string Pong() => "Pong!";
}
```

## Contribuição

1. Faça um fork do repositório.
2. Crie uma branch para sua funcionalidade (`git checkout -b minha-feature`).
3. Commit suas mudanças (`git commit -m 'Adiciona minha feature'`).
4. Faça um push para a branch (`git push origin minha-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
