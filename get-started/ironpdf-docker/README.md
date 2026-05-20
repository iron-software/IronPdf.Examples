# Integrating IronPDF within Docker Containers

***Based on <https://ironpdf.com/get-started/ironpdf-docker/>***


IronPDF now fully supports integration with Docker across diverse environments, including Azure Docker Containers tailored for both Linux and Windows platforms.

Interested in deploying IronPDF in a standalone Docker container? Explore further in the [IronPDFEngine tutorials guide](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/docker--v1.png" alt="Docker Logo">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/fluency/96/000000/azure-1.png" alt="Azure Logo">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/linux--v1.png" alt="Linux Logo">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/amazon-web-services--v1.png" alt="AWS Logo">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/windows-logo--v1.png" alt="Windows Logo">
        </div>
    </div>
</div>

### Benefits of Using Docker on Azure

Docker Containers deployed on Azure provide superior scalability and offer enhanced permissions compared to traditional WebApps. These capabilities allow for effective rendering of SVG fonts due to accessible GDI+ graphics.

### Getting Started with IronPDF on Linux Docker

New to Docker and .NET? We recommend this useful guide on [configuring Docker for debugging and project integration with Visual Studio](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

For specifics on setting up IronPDF with Linux, be sure to consult our [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/get-started/linux/).

### Suggested Linux Docker Distros

Here are recommended 64-bit Linux operating systems ideal for configuring IronPDF with minimal effort:

- Ubuntu versions 22, 20, and 18
- Debian versions 11 and 10
- CentOS 8
- Amazon AWS Linux 2 ([IronPDF AWS Lambda Setup Guide](https://ironpdf.com/get-started/aws/))

Using [Microsoft's Official Docker Images for .NET](https://hub.docker.com/_/microsoft-dotnet-runtime/) is advisable. Explore our [Linux Manual Setup Guide](https://ironpdf.com/get-started/linux/#other-linux-distros) for guidance on other distros.

## Installing IronPDF on Linux Docker

### Opt for Linux-Optimized NuGet Packages

It's advisable to use the [IronPdf.Linux](https://www.nuget.org/packages/IronPdf.Linux) NuGet package over the standard [IronPdf](https://www.nuget.org/packages/IronPdf/) for enhanced efficiency within Linux environments. This package optimizes storage and ensures no unnecessary downloads during your Docker instance's boot:

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Alternatively, adding [IronPdf.Native.Chrome.Linux](https://www.nuget.org/packages/IronPdf.Native.Chrome.Linux/) alongside the regular package is also effective:

```shell
:InstallCmd Install-Package IronPdf.Native.Chrome.Linux
```

### Configuration Best Practices

To optimize Linux Docker settings, it's recommended to disable automatic Linux and Docker dependency configurations, as most prerequisites are already managed:

```csharp
// Disabling automatic dependency management:
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Additionally, turning off GPU acceleration in Docker environments prevents unnecessary complications since containers typically don't access a GPU:

```csharp
// Turn off GPU acceleration in Docker:
IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
```

## Effortless IronPDF Execution on Ubuntu

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/docker--v1.png" alt="Docker Logo">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" alt="Ubuntu Logo">
        </div>
    </div>
</div>

### Windows and Ubuntu Docker Configurations

Explore how to deploy IronPDF efficiently with Windows and Ubuntu using our various Docker configurations. Specific guidance and scripts are provided for major Linux distributions within Docker, covering multiple Ubuntu and Debian setups across several .NET versions.

For Docker configurations on Alpine Linux, we note its current limitations with our software due to outdated libraries.

Connect with the [IronPDF Engine Docker Image](https://hub.docker.com/repositories/ironsoftwareofficial) for extensive Docker solutions that effectively leverage IronPDF capabilities within your cloud-based Windows or Linux environments.