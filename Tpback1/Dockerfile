# Etapa de construcción
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copiar y restaurar archivos de proyecto
COPY Tpback1/*.csproj ./Tpback1/
COPY Tpback1/*.config ./Tpback1/
RUN dotnet restore Tpback1/Tpback1.csproj

# Copiar el resto del código y compilar
COPY Tpback1/. ./Tpback1/
WORKDIR /app/Tpback1
RUN dotnet publish -c Release -o out

# Etapa de producción
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS production
WORKDIR /app
COPY --from=build /app/Tpback1/out ./

# Establecer variables de entorno si es necesario
# ENV VariableName=Value

# Exponer el puerto de la aplicación
EXPOSE 7018

# Ejecutar la aplicación
ENTRYPOINT ["dotnet", "Tpback1.dll"]

