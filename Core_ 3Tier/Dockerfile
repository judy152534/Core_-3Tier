#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Core_ 3Tier/Core_ 3Tier.csproj", "Core_ 3Tier/"]
RUN dotnet restore "Core_ 3Tier/Core_ 3Tier.csproj"
COPY . .
WORKDIR "/src/Core_ 3Tier"
RUN dotnet build "Core_ 3Tier.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Core_ 3Tier.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core_ 3Tier.dll"]