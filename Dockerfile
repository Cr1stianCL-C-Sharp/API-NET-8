# Use the official ASP.NET runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["API/API.csproj", "API/"]
RUN dotnet restore "API/API.csproj"

# Copy the remaining source code
COPY . .

WORKDIR "/src/API"
RUN dotnet build "API.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Set the entry point for the app
ENTRYPOINT ["dotnet", "API.dll"]
