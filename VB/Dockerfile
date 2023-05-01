FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["VB/VB.vbproj", "VB/"]
RUN dotnet restore "VB/VB.vbproj"
COPY . .
WORKDIR "/src/VB"
RUN dotnet build "VB.vbproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VB.vbproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VB.dll"]
