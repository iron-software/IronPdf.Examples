# Integrating IronPDF within Docker Environments

***Based on <https://ironpdf.com/how-to/docker-linux/>***


IronPDF has expanded its support to fully integrate with Docker, covering both Azure Docker Containers and native support across Linux and Windows platforms. 

Interested in setting up IronPDF inside its own Docker container? Explore further with our comprehensive [IronPDF Engine tutorials](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

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

Docker containers on Azure provide superior scalability for enterprises, along with enhanced permissions compared to standard WebApps. This higher level of permission enables the successful rendering of SVG fonts given the enabled system access to GDI+ graphics.

## Getting Started with IronPDF on Linux

For those new to Docker with .NET, it’s advantageous to read through the detailed guide on [debugging and setting up Docker with Visual Studio](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

Additionally, don't miss our detailed guide on setting up IronPDF in a Linux environment: [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/how-to/linux/).

### Recommended Linux Distributions for Docker

For an effortless setup of IronPDF, we suggest the following Linux distributions:

- Ubuntu 22, 20, 18
- Debian 11, 10 (the default Linux Distro on Microsoft Azure)
- CentOS 8
- Amazon AWS Linux 2 ([IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/))

We advocate for the use of [Official Docker Images for .NET by Microsoft](https://hub.docker.com/_/microsoft-dotnet-runtime/). Additional Linux flavors might require manual setups via apt-get. Refer to the ["Linux Manual Setup"](https://ironpdf.com/how-to/linux/#linux-manual-setup) section.

## Essential Steps for IronPDF Linux Docker Installation

### Opt for Linux Specific NuGet Packages

Choose the [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux) NuGet package for Linux-optimized operation that conserves disk space. This package avoids unnecessary downloads during Docker initialization. It remains compatible for development on Windows or macOS.

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Alternatively, add the [IronPdf.Native.Chrome.Linux](https://www.nuget.org/packages/IronPdf.Native.Chrome.Linux/) package to enhance the primary [IronPdf](https://www.nuget.org/packages/IronPdf/) NuGet package.

```shell
:InstallCmd Install-Package IronPdf.Native.Chrome.Linux
```

### Manual Configuration Over Automatic Dependency Management

Setting `LinuxAndDockerDependenciesAutoConfig` to false often yields better performance since dependencies typically pre-exist in your Linux Docker images and are managed through **apt-get**.

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

### Disabling GPU Acceleration

By default, Linux Docker containers don’t have GPU access, making it prudent to disable GPU acceleration. If you've enabled `ChromeGpuModes.Enabled`, it's recommended to disable it in Docker deployments:

```sh
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
```

### Initiate IronPDF Early

Using the `IronPdf.Installation.Initialize()` method preemptively initializes IronPDF to avert delays during the first operational use within a Docker instance:

```sh
IronPdf.Installation.Initialize();
```

## Ubuntu Linux DockerFiles 

Diversity in DockerFiles for Ubuntu can be seen here:

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/docker--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png">
        </div>
    </div>
</div>

### Changes for Various Ubuntu and .NET Versions

For all Ubuntu versions with different .NET framework integrations, it is suggested to adjust the user role from 'app' to 'root', to ensure the library has necessary permissions, particularly to modify settings for IronCefSubprocess.

## IronPDF within Windows Docker Containers

Windows Docker Containers are increasingly utilized on Azure for their robust scalability and comprehensive developer permissions, which significantly improve text rendering capabilities due to enhanced access to graphics libraries.

A thorough introduction to container tools in Visual Studio for Docker is available in this [Visual Studio container guide](https://docs.microsoft.com/en-us/visualstudio/containers/overview?view=vs-2019).

### Example Dockerfile for .NET Core 3.1 on Windows Server 2019

Windows containers are specifically crafted not just for running but also building .NET applications efficiently:

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

Further explore pre-configured IronPdf containers at [IronSoftware's Docker Hub repository](https://hub.docker.com/repositories/ironsoftwareofficial).