#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/DevIO.Api/DevIO.Api.csproj", "src/DevIO.Api/"]
COPY ["src/DevIO.Bussines/DevIO.Bussines.csproj", "src/DevIO.Bussines/"]
COPY ["src/DevIO.Data/DevIO.Data.csproj", "src/DevIO.Data/"]
RUN dotnet restore "src/DevIO.Api/DevIO.Api.csproj"
COPY . .
WORKDIR "/src/src/DevIO.Api"
RUN dotnet build "DevIO.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevIO.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevIO.Api.dll"]