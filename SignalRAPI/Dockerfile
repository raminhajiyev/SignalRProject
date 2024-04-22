#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SignalRAPI/SignalRAPI.csproj", "SignalRAPI/"]
COPY ["SignalR.BusinessLayer/SignalR.BusinessLayer.csproj", "SignalR.BusinessLayer/"]
COPY ["SignalR.DataAccessLayer/SignalR.DataAccessLayer.csproj", "SignalR.DataAccessLayer/"]
COPY ["SignalR.EntityLayer/SignalR.EntityLayer.csproj", "SignalR.EntityLayer/"]
COPY ["SignalR.DTOLayer/SignalR.DTOLayer.csproj", "SignalR.DTOLayer/"]
RUN dotnet restore "./SignalRAPI/SignalRAPI.csproj"
COPY . .
WORKDIR "/src/SignalRAPI"
RUN dotnet build "./SignalRAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SignalRAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SignalRAPI.dll"]