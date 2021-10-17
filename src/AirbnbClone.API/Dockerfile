FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/AirbnbClone.API/AirbnbClone.API.csproj", "AirbnbClone.API/"]
RUN dotnet restore "src/AirbnbClone.API/AirbnbClone.API.csproj"
COPY . .
WORKDIR "/src/AirbnbClone.API"
RUN dotnet build "AirbnbClone.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AirbnbClone.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AirbnbClone.API.dll"]
