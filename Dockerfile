# Start with the .NET 6 SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set the working directory
WORKDIR /app

ENV MONGO_URI=${MONGO_URI}

# Copy the project file and restore dependencies
COPY ./webAPI/webAPI.csproj .
RUN dotnet restore

# Copy the rest of the application files and build the application
COPY . .
RUN dotnet publish -c Release -o out

# Create the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Production

# Expose port 5000
EXPOSE 5000

# Start the application
ENTRYPOINT ["dotnet", "webAPI.dll"]