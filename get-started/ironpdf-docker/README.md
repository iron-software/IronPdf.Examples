# Integrating IronPDF into Your Docker Setup

***Based on <https://ironpdf.com/get-started/ironpdf-docker/>***


IronPDF now completely supports Docker environments, including both Linux and Windows containers, specifically tailored for Azure Docker Containers.

Interested in setting up IronPDF within a separate Docker container? Discover more at the [IronPdfEngine Guide](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

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

## The Advantages of Docker on Azure

Docker Containers on Azure provide superior scalability for enterprises and offer broader permissions compared to traditional WebApps. This enhanced access allows for the rendering of SVG fonts thanks to the enabled GDI+ graphics system access.

## Getting Started with IronPDF and Linux in Docker

If you're new to Docker and .NET, we recommend checking out Microsoft's guide on [setting up Docker debugging and integration with Visual Studio projects](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

It's also beneficial to review our [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/how-to/linux/).

### Recommended Linux Distributions for Docker

For a seamless IronPDF configuration, consider the following 64-bit Linux OS options:

- Ubuntu 22, 20, 18
- Debian 11, 10 (The default Linux Distro in Microsoft Azure)
- CentOS 8
- Amazon AWS Linux 2 ([IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/))

For Docker images, we suggest using [Microsoft's Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/). While other Linux distributions are supported, they may need manual configurations.

Sample Docker files for Ubuntu and Debian are provided in this document.

## Essential Installation Instructions for IronPDF on Linux Docker

### Optimal NuGet Packages for Linux

Select the [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux) NuGet package over the standard [IronPdf](https://www.nuget.org/packages/IronPdf/) package to optimize for Linux, save disk space, and minimize start-up downloads.

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Alternatively, consider adding [IronPdf.Native.Chrome.Linux](https://www.nuget.org/packages/IronPdf.Native.Chrome.Linux/) alongside the regular package.

```shell
:InstallCmd Install-Package IronPdf.Native.Chrome.Linux
```

### Manual Dependency Control

Configuring the `LinuxAndDockerDependenciesAutoConfig` to false has shown to produce better outcomes since the necessary packages are generally pre-installed in Docker environments.

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

### Disabling GPU Acceleration

Due to the typical unavailability of a GPU in Docker environments for Linux, we advise keeping the GPU acceleration disabled.

```sh
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
```

### Pre-Intializing IronPDF

You might consider pre-initializing IronPDF to prevent delays during the first usage within your Docker instance.

```sh
IronPdf.Installation.Initialize();
```