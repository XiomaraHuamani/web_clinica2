FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app

EXPOSE 80

EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

COPY ["web_clinica.csproj", "."]

RUN dotnet restore "web_clinica.csproj"

COPY . .

RUN dotnet build "web_clinica.csproj" -c Release -o /app/build

FROM build AS publish

RUN dotnet publish "web_clinica.csproj" -c Release -o /app/publish

FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "web_clinica.dll"]