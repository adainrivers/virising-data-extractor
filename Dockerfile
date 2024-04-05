#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#USER app
#RUN apt install libicu
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
#COPY ["VRising.Website/VRising.Website.csproj", "VRising.Website.Api/"]
#COPY ["VRising.Configuration/VRising.Configuration.csproj", "VRising.Configuration.Core/"]
#COPY ["VRising.Localization/Palworld.Models.csproj", "Palworld.Models/"]
#COPY ["Database/Database.csproj", "Database/"]
COPY . .
WORKDIR /src/VRising.Website
RUN dotnet publish "VRising.Website.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "VRising.Website.dll"]