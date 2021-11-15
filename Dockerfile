FROM mcr.microsoft.com/dotnet/nightly/aspnet:6.0 AS appserver
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS publish
WORKDIR /src
COPY SmartBlazor/SmartBlazor.csproj .
RUN dotnet restore "SmartBlazor.csproj"
COPY SmartBlazor/. .
RUN dotnet build "SmartBlazor.csproj" -c Release -o /app/build
RUN dotnet publish "SmartBlazor.csproj" -c Release -o /app/publish

FROM appserver AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartBlazor.dll"]
