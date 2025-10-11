# используем SDK .NET 8 для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# копируем только проект TODOlist
COPY ./Blazor/TODOlist/TODOlist.csproj ./Blazor/TODOlist/
RUN dotnet restore ./Blazor/TODOlist/TODOlist.csproj

# копируем всё остальное решение
COPY . .

# публикуем только проект TODOlist
RUN dotnet publish ./Blazor/TODOlist/TODOlist.csproj -c Release -o /app/publish

# Runtime контейнер
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render подставит $PORT автоматически
ENV ASPNETCORE_URLS=http://+:${PORT}
EXPOSE 8080

ENTRYPOINT ["dotnet", "TODOlist.dll"]