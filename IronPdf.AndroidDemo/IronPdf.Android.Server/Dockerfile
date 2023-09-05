#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
RUN apt update \
    && apt install -y sudo libxkbcommon-x11-0 libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxrender1 libfontconfig1 libxshmfence1 libgdiplus libva-dev
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["IronPdf.Android.Server/IronPdf.Android.Server.csproj", "IronPdf.Android.Server/"]
RUN dotnet restore "IronPdf.Android.Server/IronPdf.Android.Server.csproj"
COPY . .
WORKDIR "/src/IronPdf.Android.Server"
RUN dotnet build "IronPdf.Android.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IronPdf.Android.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN chmod +rwx .
ENTRYPOINT ["dotnet", "IronPdf.Android.Server.dll"]