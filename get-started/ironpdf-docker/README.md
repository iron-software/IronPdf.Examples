# Integrating IronPDF with Your Docker Setup

***Based on <https://ironpdf.com/get-started/ironpdf-docker/>***


IronPDF is now fully compatible with Docker frameworks, including Azure Docker Containers for both Linux and Windows platforms.

For those who prefer running IronPDF in a dedicated Docker container, find out more on this topic here: [IronPdfEngine Guide](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/docker--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/fluency/96/000000/azure-1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/linux--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/amazon-web-services--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/windows-logo--v1.png">
        </div>
    </div>
</div>

## Benefits of Using Docker on Azure

Docker Containers on Azure provide improved permissions over typical WebApps. This elevates their capability to render SVG fonts through enabled access to GDI+ graphics.

## Getting Started with IronPDF on Linux

If you're new to Docker and .NET, it is recommended to start with this instructive piece on [how to configure Docker for integration and debugging with Visual Studio projects](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

Explore our detailed guide on setting up IronPDF in Linux environments: [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/how-to/linux/).

### Preferred Linux Docker Distributions

For optimal configuration of IronPDF, consider the following modern 64-bit Linux distributions:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Debian 11 (the default Linux Distro on Microsoft Azure)
- Debian 10
- CentOS 8
- Amazon AWS Linux 2 (review the [IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/))

Use the [Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) by Microsoft for these Linux setups. Other distributions might require manual installations via `apt-get`. Refer to our [Linux Manual Setup Guide](https://ironpdf.com/how-to/linux/#linux-manual-setup).

Included are working Docker files for both Ubuntu and Debian in this guide:

## Essential Steps for IronPDF Linux Docker Installation

### Linux Optimized NuGet Packages

Opt for the [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux) NuGet package to decrease disk space usage and prevent automated downloads during Docker initialization. This package is optimized for Linux but is also suitable for development on Windows or macOS.

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Alternatively, install [IronPdf.Native.Chrome.Linux](https://www.nuget.org/packages/IronPdf.Native.Chrome.Linux/) alongside the standard [IronPdf](https://www.nuget.org/packages/IronPdf/) package.

```shell
:InstallCmd Install-Package IronPdf.Native.Chrome.Linux
```

### Disabling Automatic Dependency Installation

Many developers see enhanced performance on Linux & Docker when they disable automatic dependency configuration by setting `LinuxAndDockerDependenciesAutoConfig` to false, relying instead on the already installed packages by Docker file package managers.

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

### Turn Off GPU Acceleration

Disable GPU acceleration within your Linux Docker containers as they generally lack GPU access. This setting is mandatory if you had previously enabled it via `ChromeGpuModes.Enabled`.

```sh
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
```

### Initiate IronPDF Early

Initialize IronPDF explicitly using the `IronPdf.Installation.Initialize()` method to pre-load necessary components and improve the startup time of Docker instances.

```sh
IronPdf.Installation.Initialize();
```

## Deploying IronPDF on Various Linux Platforms

The setup instructions and Dockerfiles for Ubuntu and Debian versions are provided directly from the content. Each version-specific setup guide is intended to grant adequate permissions and manage required settings for optimal performance of IronPdf within the given environment.

## Windows Docker Containers for IronPDF

Windows Docker Containers are increasingly popular on Azure, providing superior performance, scalability, and developer-configurable settings.

IronPDF enhances text rendering inside both Windows and Linux Docker containers on Azure by leveraging more advanced access to the graphics library and virtualized graphics hardware.

For an introductory guide to using containers in Visual Studio, see '[Visual Studio Container Tools for Docker](https://docs.microsoft.com/en-us/visualstudio/containers/overview?view=vs-2019)'.

Below is a Dockerfile example for setting up .NET Core 3.1 on a Windows container:

```shell
FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["ConsoleApp/ConsoleApp.csproj", "ConsoleApp/"]
RUN dotnet restore "ConsoleApp/ConsoleApp.csproj"
COPY . .
WORKDIR "/src/ConsoleApp"
RUN dotnet build "ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM ironsoftwareofficial/windows:2019-net60
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp.dll"]
```

Explore additional pre-configured Docker images by IronPDF at their [Docker repository](https://hub.docker.com/repositories/ironsoftwareofficial).