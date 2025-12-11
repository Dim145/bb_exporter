FROM mcr.microsoft.com/dotnet/runtime:10.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["bb_exporter/bb_exporter.csproj", "bb_exporter/"]
RUN dotnet restore "bb_exporter/bb_exporter.csproj"
COPY . .
WORKDIR "/src/bb_exporter"
RUN dotnet build "./bb_exporter.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./bb_exporter.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=true

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chmod +x ./bb_exporter

CMD ["/app/bb_exporter"]
