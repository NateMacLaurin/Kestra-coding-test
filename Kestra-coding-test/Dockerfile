FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSe 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Kestra-coding-test.csproj", "./"]
RUN dotnet restore "./Kestra-coding-test.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Kestra-coding-test.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Kestra-coding-test.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Kestra-coding-test.dll"]