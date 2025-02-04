# Etapa 1: Construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar arquivos de projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar todo o código e compilar
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

# Copiar os arquivos compilados da etapa anterior
COPY --from=build /app/publish .

# Copiar o appsettings.json para permitir configuração via Docker volumes
COPY appsettings.json /app/appsettings.json

# Definir ponto de entrada
ENTRYPOINT ["dotnet", "Esferas.Bot.dll"]
