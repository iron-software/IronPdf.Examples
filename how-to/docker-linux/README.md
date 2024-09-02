# Integrating IronPDF into your Docker Environment

IronPDF now seamlessly integrates with Docker environments, including Azure Docker Containers across both Linux and Windows platforms.

Interested in setting up IronPDF in a standalone Docker container? Discover more by exploring our [IronPdfEngine Guide](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

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

## Why Opt for Docker on Azure?

Docker Containers on Azure provide superior scalability along with enhanced permissions compared to traditional WebApps enabling functionalities like SVG font rendering due to system access to GDI+ graphics.

## Getting Started with IronPDF on Linux and Docker

New to Docker and .NET? We recommend this in-depth article on [setting up Docker debugging and integrating with Visual Studio projects](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

Don't miss our [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/how-to/linux/).

### Optimal Linux Docker Distributions for IronPDF

For ease of configuration with IronPDF, consider the following 64-bit Linux OSs:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Debian 11
- Debian 10 _ [Currently the default Linux Distribution on Microsoft Azure]_
- CentOS 8
- Amazon AWS Linux 2 ([Read the IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/))

For Docker images, rely on Microsoft's [Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/). Note that some Linux distros might need manual configuration as detailed in our "[Linux Manual Setup](https://ironpdf.com/how-to/linux/#linux-manual-setup)" guide.

Here are some Dockerfile examples for Ubuntu and Debian:

## Key Installation Tips for IronPDF in Linux Docker

### Opt for Linux-Optimized NuGet Packages

Utilize the [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux) NuGet package for a leaner installation avoiding unnecessary asset downloads, especially for Docker environments. This package is optimized for Linux but also supports development on Windows or macOS.

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Alternatively, you might add [IronPdf.Native.Chrome.Linux](https://www.nuget.org/packages/IronPdf.Native.Chrome.Linux/) on top of the standard [IronPdf](https://www.nuget.org/packages/IronPdf/) package.

```shell
:InstallCmd Install-Package IronPdf.Native.Chrome.Linux
```

### Disable Automatic Dependency Installation

For enhanced performance with Linux & Docker, set `LinuxAndDockerDependenciesAutoConfig` to `false`. This change helps as the essential packages are usually pre-installed using **apt-get** in Docker files.

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

### Turn Off GPU Acceleration

Since Docker containers typically don't have GPU access, it's advisable to disable GPU acceleration by setting:

```sh
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
```

### Initialize Ahead of Time

Consider invoking `IronPdf.Installation.Initialize()` to pre-load IronPDF during Docker instance creation, minimizing the initial load time by bypassing the download of prerequisites:

```sh
IronPdf.Installation.Initialize();
```

## IronPDF Windows Docker Containers

Windows Docker Containers on Azure are gaining popularity due to enhanced performance and scalability, and better configuration freedoms.

IronPDF benefits from these enhanced permissions, improving text rendering in Docker containers due to better access to the graphics library and virtual graphics hardware.

The article '[Visual Studio Container Tools for Docker](https://docs.microsoft.com/en-us/visualstudio/containers/overview?view=vs-2019)' provides a thorough introduction.

Example of a Windows container Dockerfile for .NET Core 3.1 is provided below:

<script src="https://gist.github.com/ironsoftwarebuild/f485b4bf812815180854fc7f3c24f02c.js">
</script>

### Windows Server 2019 .NET 6.0

These pre-configured Windows containers contain all required dependencies for running IronPdf, ideal for deployment scenarios, not development environments:

```shell
FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2019 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["ConsoleApp/ConsoleApp.csproj", "ConsoleApp/"]
RUN dotnet restore "ConsoleApp.csproj"
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

Explore IronPDF’s [Docker repository](https://hub.docker.com/repositories/ironsoftwareofficial) for a range of pre-configured images.