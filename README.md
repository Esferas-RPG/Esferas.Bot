# Esferas Discord Bot

Este é um bot do Discord desenvolvido com [NetCord](https://netcord.dev/), uma biblioteca moderna para interagir com a API do Discord de forma eficiente e flexível.

## Recursos

-   Comandos de slash (/) totalmente configuráveis.
-   Respostas dinâmicas e interativas.
-   Suporte a eventos do Discord.
-   Estrutura modular para facilitar a expansão.

## Requisitos

-   .NET 8+ (se rodar localmente sem Docker)
-   Um bot registrado no [Discord Developer Portal](https://discord.com/developers/applications)
-   Token do bot
-   Docker (se rodar via container)

## Instalação

### **Executando Localmente**

1. Clone este repositório:

    ```sh
    git clone https://github.com/Esferas-RPG/Esferas.Bot.git
    cd Esferas.Bot
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

4. Inicie o bot:

    ```sh
    dotnet run
    ```

---

## **Executando com Docker**

### **1️⃣ Construindo a imagem**

Certifique-se de ter o [Docker instalado](https://docs.docker.com/get-docker/) e, em seguida, execute:

```sh
docker build -t esferas-bot .
```

### **2️⃣ Rodando o container**

Para rodar o bot do Discord:

```sh
docker run esferas-bot
```

### **3️⃣ Usando Docker Compose (Recomendado)**

Se preferir, use o `docker-compose` para facilitar a execução:

1. **Inicie o bot com o Compose**:

    ```sh
    docker-compose up -d
    ```

2. **Parar o bot**:

    ```sh
    docker-compose down
    ```

3. **Ver logs do bot**:

    ```sh
    docker-compose logs -f
    ```

---

## **Exemplo de Comando**

Aqui está um exemplo de um comando de ping usando NetCord e C#:

```csharp
using NetCord.Services.ApplicationCommands;

public class ExampleModule : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("ping", "Pong!")]
    public static string Pong() => "Pong!";
}
```

## **Contribuição**

1. Faça um fork do repositório.
2. Crie uma branch para sua funcionalidade (`git checkout -b minha-feature`).
3. Commit suas mudanças (`git commit -m 'Adiciona minha feature'`).
4. Faça um push para a branch (`git push origin minha-feature`).
5. Abra um Pull Request.

## **Licença**

Este projeto está licenciado sob a [MIT License](LICENSE).
