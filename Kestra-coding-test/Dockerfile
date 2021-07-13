FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Kestra-coding-test/Kestra-coding-test.csproj", "Kestra-coding-test/"]
RUN dotnet restore "Kestra-coding-test/Kestra-coding-test.csproj"
COPY . .
WORKDIR "/src/Kestra-coding-test"
RUN dotnet build "Kestra-coding-test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kestra-coding-test.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kestra-coding-test.dll"]