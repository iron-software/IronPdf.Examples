# Employing IronPDF in Linux Environments

***Based on <https://ironpdf.com/get-started/linux/>***


IronPDF offers broad support for Linux across various .NET platforms including **.NET 9, 8, 7, 6, 5** as well as **.NET Core**. It is also compatible with numerous environments such as Docker, Azure, AWS, macOS, and naturally, Windows.

### Endorsed Containerization and Hosting Environments
<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />

### Supported Linux Distributions
<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

## Optimization Tips for Using IronPDF on Linux

We advise using .NET Core 3.1 and any LTS (Long Term Support) versions specified by Microsoft [LTS by Microsoft](https://dotnet.microsoft.com/platform/support/policy), as they provide consistent support and have been thoroughly tested on Linux.

IronPDF is designed to function seamlessly on Linux right after installation, due to extensive preliminary testing and configuration by our dedicated engineering team.

Linux is a critical platform due to its prevalence in cloud services such as Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker. At Iron Software, our frequent use of these tools and our understanding of their importance for Enterprise and SAAS customers underscore our commitment to robust Linux support.

## Hardware Recommendations

To convert HTML to PDF, IronPDF employs the Chromium rendering engine, known for its fidelity to Chrome's printing capabilities. The recommended specifications are geared towards optimizing Chromium's performance.

- **Minimum Requirement:** 1 CPU core and 1.75 GB of RAM
- **Recommended Specification:** 2 CPU cores and at least 8 GB of RAM

### Fully Supported Linux Versions

For effortless installation and configuration, we particularly recommend the latest **64-bit** versions of the following Linux distributions:

- Ubuntu (22, 20, 18, 16)
- Debian 11 (the default Linux distribution for Microsoft Azure)
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2 - see the detailed [AWS Lambda Setup Guide for IronPdf](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/)

For Linux distributions not explicitly listed, refer to "Other Linux Distros" later in this guide for installation advice.

The use of Microsoft's [Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) is recommended for the best experience. In cases where other distributions are used, some manual configuration might be required.

## Simplified Setup on Linux

Activating the `LinuxAndDockerDependenciesAutoConfig` setting to `true` simplifies the dependency setup process for IronPDF operations on Linux.

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## Optimized NuGet Packages for Linux

Deploying IronPDF on Linux is streamlined with specific NuGet packages available, detailed in our [advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These packages facilitate development across different operating systems, including Windows and macOS.

For direct software integration, the Linux-specific DLL package is available for [download](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Configuring Docker with Linux

For extensive assistance on setting up IronPDF with Docker, refer to our [detailed documentation for Docker on Linux](https://ironpdf.com/how-to/docker-linux/).

## Special Note on Ubuntu Compatibility

Ubuntu holds a special place in our testing infrastructure due to its predominant use in Azure, aligning with official support from Microsoft and availability of Docker images.

### Specifically, Ubuntu 20:

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 20 is fully supported with no required configuration adjustments.

- Supports Chrome and WebKit-based HTML to PDF conversion
- Comprehensively supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8**
- Undergoes rigorous unit testing with over 997 tests before any release

**Official Microsoft Docker Images for Ubuntu 20:**

- [64-bit Ubuntu 20.04 Docker image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Ubuntu 20.04 Docker image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup for Ubuntu 20:**

For setups requiring manual configuration, or in scenarios where administrative privileges are not available, deactivate the automatic dependency configuration:

Set `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;`

```sh
apt update
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1
apt install -y libgdiplus
apt install -y libva-dev

chmod 755 IronCefSubprocess
# (IronCefSubprocess is typically located at `bin/runtimes/linux-x64/`)

***Based on <https://ironpdf.com/get-started/linux/>***

``` 

In the above command, `libgdiplus` and `libva-dev` were included as additional dependencies, which may be necessary for enhanced graphics and video support within your applications.

## Compatibility & Setup Guide

IronPDF is compatible with Linux environments for **.NET 9, 8, 7, 6, 5**, and **.NET Core** applications. It also extends its support to Docker, Azure, AWS solutions, as well as macOS and Windows platforms.

### Supported Platforms for Containerization and Hosting

IronPDF offers robust support for a variety of containerization and hosting environments, ensuring smooth deployment across different settings including cloud platforms and operating systems. Here's a visual overview of the supported technologies:

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />

### Supported Linux Distributions

IronPDF is compatible with several major Linux distributions. The images below provide a quick reference to the supported versions:

![Ubuntu Logo](https://img.icons8.com/color/96/000000/ubuntu--v1.png)
![Debian Logo](https://img.icons8.com/color/96/000000/debian--v1.png)
![CentOS Logo](https://img.icons8.com/color/96/000000/centos--v1.png)

<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

## Guidance on Utilizing IronPDF with Linux

For optimal performance with IronPDF on Linux platforms, we suggest utilizing .NET Core 3.1 or other runtime versions that are designated as LTS (Long-Term Support) by Microsoft, given their assured extended support and robust testing on Linux systems. Explore more about LTS runtimes at [Microsoft's LTS support policy](https://dotnet.microsoft.com/platform/support/policy).

IronPDF is engineered to work efficiently right out of the installation, requiring no additional code alterations for Linux usage. This seamless functionality is achieved through extensive testing and configuration by our dedicated engineering team.

The integration of IronPDF in Linux environments plays a crucial role due to the widespread adoption of Linux in various cloud services, including Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker. At Iron Software, we extensively utilize these cloud platforms, enhancing our expertise and support for our Enterprise and SaaS clients who also depend on these technologies.

## Hardware Requirements

IronPDF is built on the Chromium engine to convert HTML to PDF. This process mirrors the high-quality output similar to Chrome's print-to-PDF functionality. The specified hardware requirements ensure the efficient operation of the Chromium engine, which is the primary consumer of resources in this setup.

- **Minimum Requirement**: 1 CPU core and 1.75 GB of RAM
- **Recommended Configuration**: At least 2 CPU cores and 8 GB of RAM

### Supported Linux Distributions for IronPDF

IronPDF fully endorses and provides zero-configuration support for the following 64-bit Linux distributions:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11 (Currently the default Linux distribution for Microsoft Azure)
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2. 

For detailed setup with AWS Lambda, refer to the [IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

For guidance on utilizing IronPDF with Linux distributions that do not have official support, please refer to the **Other Linux Distros** section further in this document.

We advise using [Microsoft’s Docker Official Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) for optimized performance. Some Linux distros may lack full support and could need manual setup through apt-get commands. Consult the section titled ["Common Dependency Patterns for Linux"](#anchor-other-linux-distros) at the end of this document for more information.

## Automating Linux Setup 

By enabling the `LinuxAndDockerDependenciesAutoConfig` to `true`, IronPDF can automatically handle the installation of necessary dependencies for operation on Linux platforms. Be mindful that the initial HTML-to-PDF conversion might require additional time to complete.

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## Optimized NuGet Packages for Linux

IronPDF provides specially tailored NuGet packages for Linux systems, ensuring optimized performance and compatibility. These packages are detailed in our comprehensive [IronPDF Advanced NuGet Installation Guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

Whether you’re developing on Windows, macOS, or directly on Linux, these Linux-optimized packages can be seamlessly integrated into your development environment.

You can easily download the tailored DLL specifically for Linux using the following [direct link](https://ironpdf.com/packages/IronPdf.Linux.zip). 

Below is the command to install the Linux-specific package via NuGet:

```shell
Install-Package IronPdf.Linux
``` 

By using these optimized packages, you tap into the full potential of IronPDF on Linux, ensuring high performance and efficiency in your application deployment.

Here's the paraphrased section:

```shell
dotnet add package IronPdf.Linux
```

IronPDF offers specific NuGet packages tailored for Linux deployments, which you can find detailed in our [IronPDF Advanced NuGet Installation Guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These packages not only facilitate Linux deployment but also allow you to develop applications on Windows or macOS systems seamlessly.

For direct access to the necessary files, feel free to [download the Linux DLL](https://ironpdf.com/packages/IronPdf.Linux.zip) directly.

## Configuring Docker for IronPDF on Linux

For detailed guidance on configuring Docker to work with IronPDF, please refer to our [comprehensive tutorial](https://ironpdf.com/how-to/docker-linux/). This guide will assist you in creating a Docker image optimized for IronPDF operations.

## Compatibility with Ubuntu

Ubuntu ranks as the most rigorously tested Linux distribution within our suite, largely due to its extensive use within our Azure-based infrastructure for ongoing tests and deployments. It is also backed by official Microsoft .NET support and comes with certified Docker images.

### Ubuntu 20 Compatibility

![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

Ubuntu 20 is fully supported out-of-the-box by IronPDF, making installation seamless and straightforward.

#### Benefits and Support:
- Utilizes **Chrome** and **WebKit** as HTML to PDF rendering engines.
- Directly supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Numerous other .NET Core runtimes are also compatible with Ubuntu 20, though not officially supported.
- Prior to each release, more than 997 rigorous unit tests are conducted to ensure robust performance.

#### Official Microsoft Docker Images:
- Download from these resources to get Ubuntu 20 Docker images pre-configured for .NET runtimes:
  - [Ubuntu 20.04 64-Bit .NET Runtime 3.1 ('3.1-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
  - [Ubuntu 20.04 64-Bit .NET Runtime 5.0 ('5.0-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

#### Configurations for Manual Set-Up:
For users needing manual setup, or operating without _sudo_ privileges:

1. Disable automatic dependency configuration:
   ```cs
   IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
   ```
2. Use the following commands to install necessary dependencies:
   ```sh
   apt update
   apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1
   ```
3. Ensure `IronCefSubprocess` is executable:
   ```sh
   chmod 755 IronCefSubprocess
   # Locate it typically at bin/runtimes/linux-x64/
   ```

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

# Seamless Ubuntu 20 Integration with IronPDF

***Based on <https://ironpdf.com/get-started/linux/>***


Ubuntu 20 is fully compatible with IronPDF and requires no configuration to get started.

### Key Features Supported

- Complete support for HTML to PDF conversions using both **Chrome** and **WebKit** engines.
- Full compatibility with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtime environments.
- Extended support for several other .NET Core runtimes available on Ubuntu 20.
- Rigorous validation through more than 997 unit tests conducted on this platform prior to each software release.

### Official Microsoft Docker Images Available

For those utilizing Docker, official .NET runtime images are accessible:

- [.NET Runtime 3.1 for Ubuntu 20.04 (64-bit) '3.1-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 for Ubuntu 20.04 (64-bit) '5.0-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Setup Instructions for Ubuntu 20

For setups where manual installation is necessary, or where applications are unable to run with _sudo_ administrative privileges, follow the instructions below:

Disable automatic dependency configuration in IronPDF by adjusting the installation settings:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```
```

```sh
apt update
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1
apt install -y libgdiplus
apt install -y libva-dev

# Ensure IronCefSubprocess is executable (typically found at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
```

Below is the paraphrased section you requested with the relative URL paths resolved to `ironpdf.com`:

-----

- The **IronCefSubprocess** binary file is located within the `bin` directory of your application. It might be necessary to provide a complete path to this file, especially if it resides in the `runtimes` subfolder of the `bin` directory.

- Administrator rights may be required, potentially necessitating the use of `sudo` commands.

### Compatibility with Ubuntu 18

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully compatible and supported by IronPDF, and requires no initial configuration to get started.

- Provides support for HTML to PDF conversions using **Chrome** and **WebKit** rendering engines.
- Fully supports **.NET Core 3.1 LTS** and **.NET 5 runtimes** officially.
- Although other .NET Core runtimes are not officially supported, they generally work well on Ubuntu 18.
- Our rigorous smoke tests ensure reliability with each software release.

**Official Docker Images from Microsoft:**

- [64-bit Ubuntu 18.04 Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- Note: While there is no specific official docker image for .NET 5 on Ubuntu 18, the compatibility is notably high.

**Manual Setup for Ubuntu 18:**
For those opting for a manual setup or in environments where admin privileges are restricted.

Disable automatic dependency configuration by setting the following property:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then, manually install the necessary libraries using shell commands:
```sh
apt update
apt install -y libc6
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence-dev

chmod 755 IronCefSubprocess
# Normally located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully compatible with IronPDF straight out of the box, requiring no additional configuration to get started.

- We offer support for HTML to PDF conversions using both **Chrome** and **WebKit** rendering engines.
- Officially, **.NET Core 3.1 LTS** and **.NET 5 runtimes** are supported.
- Additionally, we provide informal support for a wider range of .NET Core runtimes on Ubuntu 18 and occasionally even on Ubuntu 16.
- Before each release, our team conducts extensive smoke tests on this platform to ensure reliability and performance.

### Official Microsoft Docker Images for Ubuntu 18

- [64-bit Ubuntu 18.04 Docker Image for the .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- While there is no official Docker image for .NET 5 on Ubuntu 18, the compatibility level remains very high.

### Manual Setup for Ubuntu 18

For setups where manual installation is necessary, or when your application cannot be run with _sudo_ administrative privileges:

First, disable automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here is the paraphrased section:

```sh
# Update package listings

***Based on <https://ironpdf.com/get-started/linux/>***

apt update

# Install necessary libraries for IronPDF

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Make the IronCefSubprocess executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Compatibility with Ubuntu 16

Ubuntu 16 provides partial support for IronPDF, although it hasn’t undergone rigorous testing on this version. This makes it less predictable in terms of out-of-the-box compatibility.

The Microsoft-supported .NET Core 3.1 LTS and .NET 5 runtimes are available for Ubuntu 16, which many developers report as functioning well with IronPDF, albeit possibly requiring some manual configuration due to incomplete automatic dependency resolution.

For rendering with **Chrome** and **WebKit**, configuration is mostly manual. Please be aware that while there is significant user feedback indicating satisfactory performance, official Microsoft Docker images for Ubuntu 16 are not provided, marking a decreased level of support for automated setups.

#### Custom Installation on Ubuntu 16
If automated installation is not viable due to restrictions like non-admin access, you can configure your system manually. For smoother manual setup, follow the settings below:

```sh
apt update
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence-dev

chmod 755 IronCefSubprocess
# (IronCefSubprocess should be located in the bin/runtimes/linux-x64/ directory of your project)

***Based on <https://ironpdf.com/get-started/linux/>***

```
By administering these installations and settings, you can establish a functional environment for IronPDF on Ubuntu 16, enabling your applications to utilize its capabilities. However, it’s essential to check compatibility updates often and consider upgrading to more fully supported versions when feasible.

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

**Ubuntu 16 Compatibility Notes for IronPDF**

IronPDF offers only limited or unofficial compatibility with Ubuntu 16, as comprehensive testing on this platform has not been performed.

The .NET framework is fully supported on Ubuntu 16 by Microsoft, and several IronPDF users have successfully utilized it within this environment. Note that developers might need to manually install necessary `apt-get` dependencies.

- Rendering using **Chrome** and **WebKit** configurations may require manual adjustments.
- The **.NET Core 3.1 LTS** and **.NET 5** runtimes are confirmed to work on Ubuntu 16, under Microsoft's official support.
- Regrettably, no official Microsoft Docker images are available yet for this version of Ubuntu.

### Manual Installation on Ubuntu 16

For those preferring or requiring manual setup, particularly in instances where superuser ('sudo') privileges are not available:

Disable automatic dependency configuration by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here is the paraphrased section of the article with resolved URL paths:

```sh
apt update
# Install necessary libraries

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence-dev

# Ensure the IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Typically found in the bin/runtimes/linux-x64/ directory of the application

***Based on <https://ironpdf.com/get-started/linux/>***

```

This rewrite retains the technical commands and clarifies the purpose of each step while ensuring that the operational commands are kept precise and concise.

## Compatibility with Debian Systems

Debian ranks as the second most extensively tested Linux distribution within our systems. It receives robust support from Microsoft.NET and is fully compatible with Official Docker Images.

### Debian 11 Compatibility

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 11 comes fully equipped to run IronPDF right out of the box.

- All **Chrome** and **WebKit** powered HTML to PDF conversion engines are supported.
- Fully supported are the **.NET Core 3.1, 5, 6 (LTS), 7 and 8** versions.
- Performance and compatibility are guaranteed through rigorous execution of over 997 unit tests on this system.

**Microsoft’s Official Docker Images:**

- [Debian 11 Docker Image for .NET Runtime 3.1 – 64 bit](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Debian 11 Docker Image for .NET Runtime 5.0 – 64 bit](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Installation on Debian 11:**
For scenarios where applications cannot be run with administrative rights, and manual installation is desirable or necessary, disable automatic dependencies configuration:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```
Execute the following installation commands:

```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxkbcommon-x11-0 libxrender1 libfontconfig1 libxshmfence1

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess can be found typically at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

**Debian 11 and IronPDF Compatibility**

Debian 11 serves as the preferred Linux distribution by Microsoft for integrating Docker in .NET projects within Visual Studio.

We deliver support for Debian 11 seamlessly, requiring **no additional configuration**.

- Incorporates support for both **Chrome** and **WebKit** HTML to PDF conversion engines.
- Provides certified support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- Extends non-certified support to other versions of .NET Core on Debian 11.
- Undertakes rigorous validation with more than 997 unit tests on this environment per update cycle.

**Acknowledged Microsoft Docker Images:**

- [64-bit Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Guidance for Manual Installation on Debian 11**

Should you need to perform a manual setup, or if your application operates without _sudo_ administrative rights:

Configure the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to false with the following command:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Commencing update and installation of Linux packages

***Based on <https://ironpdf.com/get-started/linux/>***

apt update

# Installing essential libraries and tools for IronPDF compatibility:

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libxkbcommon-x11-0
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1

# Ensuring that IronCefSubprocess has the required execution permissions:

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# IronCefSubprocess typically located at bin/runtimes/linux-x64/ in your application's directory structure

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Debian 10 Compatibility

![Debian 10](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker](https://img.icons8.com/color/48/000000/docker.png)
![Azure](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 10 is fully compatible with IronPDF straight from installation and requires no additional setup to work effectively. 

- Supports HTML to PDF rendering engines based on Chrome and WebKit.
- Official support is extended to **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- While not officially stated, Debian 10 works well with several other .NET Core runtimes.
- More than 997 unit tests are executed on this platform prior to each software release, ensuring reliability and stability.

**Official Docker Images for Debian 10:**

- [Debian 10's 64-bit Docker image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Debian 10's 64-bit Docker image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup on Debian 10:**
For setups where administrative rights are restricted:

```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

Disabling automatic dependency installation is possible using the following configuration:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

This manual installation sequence ensures all required libraries are in place for Debian 10 environments where the automated setups are not feasible.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 10 is fully supported by IronPDF and requires no initial setup adjustments for functionality.

- The HTML to PDF conversion capabilities are powered by both Chrome and WebKit rendering engines.
- Out-of-the-box support is extended to **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- While not officially supported, many other **.NET Core** runtimes do operate on Debian 10.
- Prior to each release, our team conducts more than 997 unit tests on this architecture to ensure robust functionality.

### Official Microsoft Docker Images for Debian 10:

- [64-bit Debian 10 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 10 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Setup for Debian 10

For instances where manual installation is preferable or necessary due to lack of administrative privileges, follow these steps:

Turn off automatic dependency management by setting the property `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
apt update
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm-common
apt install -y libgbm1
apt install -y libasound2
apt install -y libappindicator3-1
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1

# Ensure that the IronCefSubprocess binary is executable:

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Typically found in the bin/runtimes/linux-x64/ directory of your application

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Debian 9 and Earlier Versions

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 and older versions have not undergone official testing and won't seamlessly integrate with IronPDF. However, since .NET is officially supported by Microsoft on Debian 9, IronPDF can function on this system with proper configuration (See "<a href="#anchor-other-linux-distros">Common Dependency Patterns for Linux</a>" at the end of this document).

As of now, there are no formal Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 on Debian 9. It is recommended to upgrade to Debian 10 for a smoother experience with IronPDF.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 hasn't undergone official testing with IronPdf and thus might not function seamlessly upon installation. Nevertheless, since Microsoft officially supports .NET on Debian 9, proper setup could ensure compatibility with IronPdf. For guidance on setting up, refer to the section ["Common Dependency Patterns for Linux"](https://www.ironpdf.com/#anchor-other-linux-distros) at the end of this document.

It is also important to note that there are no Microsoft official Docker images available for .NET Core 3.1 or .NET 5.0 specific to Debian 9. Transitioning to Debian 10 is strongly advised for better support and functionality.

## Compatibility with CentOS

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

We actively support and endorse CentOS for use with IronPDF, providing a seamless experience with no initial configuration required.

### Support for CentOS 8

CentOS 8 is fully supported by IronPDF with automatic handling.

- We provide support for HTML to PDF rendering using **Chrome** and **WebKit** engines.
- Officially, we support **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes on CentOS.
- Although not officially stated, IronPDF tends to perform well on a variety of other .NET Core runtimes as well.
- Every new release of IronPDF undergoes a rigorous set of smoke tests on this platform to guarantee stability and performance.

Unfortunately, there are no official Microsoft Docker images available for CentOS 8 either for .NET Core 3.1 or .NET 5.0.

### Manual Installation on CentOS 8
For those needing to manually configure IronPDF on CentOS 8 or do not possess admin privileges to execute installations, follow these instructions:

Turn off automatic dependency management:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Run the following commands to install the necessary dependencies:
```sh
dnf -y update
dnf -y install glibc-devel
dnf -y install nss
dnf -y install at-spi2-atk
dnf -y install libXcomposite
dnf -y install libXrandr
dnf -y install mesa-libgbm
dnf -y install alsa-lib
dnf -y install pango
dnf -y install cups-libs
dnf -y install libXdamage
dnf -y install libxshmfence

chmod 755 IronCefSubprocess
# (IronCefSubprocess is usually located within bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Below

Support for CentOS 7 and previous versions is not standard.

- .NET is officially supported by Microsoft for CentOS 7, which should theoretically enable functional compatibility with IronPDF, provided proper setup.
- We recommend reading the section on common dependency configurations for unforeseen configurations.

Unfortunately, no official Docker images exist for .NET Core 3.1 or .NET 5.0 on CentOS 7 through Microsoft.

Detailed guidance for manual configurations is similar to that provided above for CentOS 8, tailored to the specific needs of CentOS 7.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

### CentOS Compatibility

![CentOS Logo](https://img.icons8.com/color/48/000000/centos.png) ![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png) ![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png) ![Test Icon](https://img.icons8.com/fluency/48/000000/test.png)

Iron Software is committed to providing exceptional support for CentOS.

#### CentOS 8 Support

CentOS 8 is fully supported by IronPDF without any required configuration:

- We offer support for **Chrome** and **WebKit-based HTML to PDF rendering engines**.
- We officially support **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- We also provide support for many other .NET Core runtimes on CentOS, although some of these are unofficial.
- Before each release, we conduct detailed smoke tests on this platform.

Please note, there are no available official Docker images by Microsoft for .NET Core 3.1 or .NET 5.0 on CentOS 8.

**Manual CentOS 8 Setup**
For setups where automatic installation is not preferable or if your application cannot run with _sudo_ admin privileges:

```sh
dnf -y update
dnf -y install glibc-devel
dnf -y install nss
dnf -y install at-spi2-atk
dnf -y install libXcomposite
dnf -y install libXrandr
dnf -y install mesa-libgbm
dnf -y install alsa-lib
dnf -y install pango
dnf -y install cups-libs
dnf -y install libXdamage
dnf -y install libxshmfence

chmod 755 IronCefSubprocess
# (Usually located at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

Disable automatic configuration if required:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

### CentOS 8 Integration

CentOS 8 is fully compatible with IronPDF right from the start, requiring no additional configurations.

- Supports **Chrome** and **WebKit** for converting HTML to PDFs.
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** versions.
- Provides unofficial support for additional .NET Core runtimes on CentOS.
- Every new release is preceded by thorough smoke testing on this OS.

Unfortunately, Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 on CentOS 8.

#### Manual Configuration for CentOS 8

For manual installation or scenarios where your application doesn't have _sudo_ privileges:

Disable automatic dependency management by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here's your paraphrased section, with all relative URLs resolved to `ironpdf.com`:

```sh
# Begin package update

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y update

# Install necessary development libraries and packages

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y install glibc-devel  # Standard C Library development files
dnf -y install nss          # Network Security Services
dnf -y install at-spi2-atk  # Assistive Technology Service Provider Interface
dnf -y install libXcomposite  # X Composite extension library
dnf -y install libXrandr    # X Resize, Rotate and Reflection extension library
dnf -y install mesa-libgbm  # Mesa graphics library for handling buffers
dnf -y install alsa-lib     # Advanced Linux Sound Architecture library
dnf -y install pango        # Library for text layout and rendering
dnf -y install cups-libs    # Common UNIX Printing System libraries
dnf -y install libXdamage   # X Damage extension library
dnf -y install libxshmfence # X shared memory 'fence' synchronization primitive

# Set the IronCefSubprocess binary to be executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# (IronCefSubprocess is usually located in the bin/runtimes/linux-x64/ directory)

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Earlier Versions

CentOS 7 and its predecessors are not pre-configured to work with IronPdf. 

Although IronPdf hasn't undergone formal testing on CentOS 7, Microsoft officially supports .NET for this version, which suggests that IronPdf could potentially function correctly if configured appropriately. For guidance on proper setup, please refer to the section on [Common Dependency Patterns for Linux](#anchor-other-linux-distros).

Currently, Microsoft does not offer official Docker images for CentOS 7 for either .NET Core 3.1 or .NET 5.0.

## Compatibility with Amazon AWS Linux 2

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

IronPDF is well-integrated and functional under Amazon AWS Linux 2, which is foundational for EC2 and Lambda services offered by Amazon's cloud.

There are currently no official Microsoft Docker images available for Amazon AWS Linux 2 for either .NET Core 3.1 or .NET Core 5.0. However, we methodically verify and test IronPDF on Amazon AWS Linux 2 throughout our development process.

### Setting Up IronPDF Manually on Amazon AWS Linux 2

For those requiring manual installation, or where administrative privileges are not feasible, follow these instructions after setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;`:

```sh
yum update -y
yum install -y pango.x86_64
yum install -y libXcomposite.x86_64
yum install -y libXcursor.x86_64
yum install -y libXdamage.x86_64
yum install -y libXext.x86_64
yum install -y libXi.x86_64
yum install -y libXtst.x86_64
yum install -y cups-libs.x86_64
yum install -y libXScrnSaver.x86_64
yum install -y libXrandr.x86_64
yum install -y GConf2.x86_64
yum install -y alsa-lib.x86_64
yum install -y atk.x86_64
yum install -y gtk3.x86_64
yum install -y ipa-gothic-fonts
yum install -y xorg-x11-fonts-100dpi
yum install -y xorg-x11-fonts-75dpi
yum install -y xorg-x11-utils
yum install -y xorg-x11-fonts-cyrillic
yum install -y xorg-x11-fonts-Type1
yum install -y xorg-x11-fonts-misc
yum install -y glibc-devel.x86_64
yum install -y at-spi2-atk.x86_64
yum install -y mesa-libgbm.x86_64
yum install -y libxkbcommon

chmod 755 IronCefSubprocess
# (IronCefSubprocess is often located in bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

For more guidance on configuring IronPdf for Amazon's cloud services such as EC2 and Lambda, please ensure to read our thorough guide, [IronPDF for AWS Lambda](https://ironsoftware.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) which includes pertinent details related to setup and logging on this cloud platform.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

IronPDF is actively supported on Amazon AWS Linux 2, which is a key component of Amazon's cloud infrastructure, including services like EC2 and Lambda.

- Official Microsoft Docker images specifically for .NET Core 3.1 or .NET 5.0 are not available for Amazon AWS Linux 2.
- Our development team conducts hands-on tests to ensure that IronPDF works seamlessly with Amazon AWS Linux 2.

For detailed instructions and a Docker file that supports IronPDF on AWS Lambda, we recommend consulting our [IronPDF AWS Lambda guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

**Manual Installation on Amazon Linux 2**

Should you need to manually install IronPDF or if your application does not have administrator privileges, begin by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false;`.

```sh
# Update available packages and their versions

***Based on <https://ironpdf.com/get-started/linux/>***

yum update -y

# Install necessary libraries and dependencies for running IronPDF

***Based on <https://ironpdf.com/get-started/linux/>***

yum install -y pango.x86_64
yum install -y libXcomposite.x86_64
yum install -y libXcursor.x86_64
yum install -y libXdamage.x86_64
yum install -y libXext.x86_64
yum install -y libXi.x86_64
yum install -y libXtst.x86_64
yum install -y cups-libs.x86_64
yum install -y libXScrnSaver.x86_64
yum install -y libXrandr.x86_64
yum install -y GConf2.x86_64
yum install -y alsa-lib.x86_64
yum install -y atk.x86_64
yum install -y gtk3.x86_64
yum install -y ipa-gothic-fonts
yum install -y xorg-x11-fonts-100dpi
yum install -y xorg-x11-fonts-75dpi
yum install -y xorg-x11-utils
yum install -y xorg-x11-fonts-cyrillic
yum install -y xorg-x11-fonts-Type1
yum install -y xorg-x11-fonts-misc
yum install -y glibc-devel.x86_64
yum install -y at-spi2-atk.x86_64
yum install -y mesa-libgbm.x86_64
yum install -y libxkbcommon

# Ensure IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ folder.

***Based on <https://ironpdf.com/get-started/linux/>***

```

Refer to our comprehensive guide on [IronPDF for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) which covers detailed steps for installation and operational logging on the Amazon cloud platform.

## Fedora Linux Support in IronPDF

IronPDF fully supports Fedora Linux.

Fedora Linux 33 is seamlessly compatible with IronPDF and requires no additional configuration steps.

- Provides support for HTML to PDF conversion using both **Chrome** and **WebKit** rendering engines.
- Compatibility is assured with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Rigorous smoke tests are conducted on this platform before each new release to ensure robustness and reliability.

### Configuring IronPDF Manually on Fedora Linux

For scenarios where you prefer manual installation, or if your application restrictions prevent the use of _sudo_ or administrator privileges, follow these steps. This guidance is also applicable for both older and newer versions of Fedora not specifically mentioned.

To disable automatic dependency configuration:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Executing the above command ensures that IronPDF will not attempt to automatically resolve dependencies during deployment, giving you control over the setup process.

```sh
# Install necessary libraries using the dnf package manager with the 'install -y' option which automatically answers 'yes' to all prompts

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y install glibc-devel
dnf -y install nss
dnf -y install at-spi2-atk
dnf -y install libXcomposite
dnf -y install libXrandr
dnf -y install mesa-libgbm
dnf -y install alsa-lib
dnf -y install pango
dnf -y install cups-libs
dnf -y install libXdamage
dnf -y install libxshmfence

# Change permissions on the IronCefSubprocess binary to make it executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the 'bin/runtimes/linux-x64/' directory within your application's structure.

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Alpine Linux Compatibility

IronPDF is currently incompatible with Alpine Linux. Despite our fondness for Alpine and our hopes for its ongoing development, as of 2023, its reliance on older "musl" C libraries hinders full support from Chromium developers, preventing the integration of IronPDF with this operating system.

### Utilizing IronPdfEngine with Alpine Docker in .NET 6

IronPdf offers a comprehensive container image loaded with all features of IronPdf. This setup enables applications on Alpine Linux to leverage IronPdf capabilities by connecting to the IronPdfEngine container.

#### Step 1: Pull and Initiate the IronPdf Engine Docker Image

Run the following commands in your terminal to acquire and start the IronPdf Engine Docker image:

```shell
docker pull ironsoftwareofficial/ironpdfengine
docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

```shell
docker pull ironsoftwareofficial/ironpdfengine
```

Here's the paraphrased section with the relative URL paths properly resolved:

```shell
# Run the IronPdf Engine Docker image in detached mode

***Based on <https://ironpdf.com/get-started/linux/>***

docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

```
Step 2: Configure the Console Application

Begin by creating a fresh console application that targets .NET 6.

Proceed to add the IronPdf.Slim NuGet package via the NuGet Package Manager.
```

## Compatibility with Additional Linux Distributions

For Linux distributions that are not officially supported, you can manually install IronPDF by leveraging package managers such as **apt-get**, **hfs**, and **yum**. This flexibility allows developers to employ IronPDF across a broader array of Linux environments.

During the initial setup of IronPDF, it's common for the software to highlight any missing system dependencies through exceptions. This helps ensure all necessary prerequisites are met.

- The **IronCefSubprocess** binary, which is included within your project's `bin` directory, often requires specific placement in the `runtimes` subfolder. Ensure this file is accessible and executable.
  
- Installation and configuration might require `sudo` privileges depending on the system settings and directory permissions.

If your Linux OS is not listed and you're uncertain about how to proceed, it's recommended to explore the dependencies required by the **Chromium** browser for that specific OS. This can provide guidance on the needed system libraries.

For requests regarding official support for additional Linux distributions, please reach out to [support@ironsoftware.com](mailto:support@ironsoftware.com).

### Common Dependency Patterns for Linux

It's advisable to familiarize yourself with the dependency packages listed above for other supported Linux operating systems. This insight can assist in configuring IronPDF on other Linux distributions not officially supported.

```sh
apt update
apt install -y libc6-dev
apt install -y libgtk2.0-0
apt install -y libnss3
apt install -y libatk-bridge2.0-0
apt install -y libx11-xcb1
apt install -y libxcb-dri3-0
apt install -y libdrm2
apt install -y libgbm1
apt install -y libasound2
apt install -y libindicator3-7
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1

chmod 755 IronCefSubprocess
# IronCefSubprocess typically resides in the bin/runtimes/linux-x64/ directory within your application

***Based on <https://ironpdf.com/get-started/linux/>***

```

## IronCefSubprocess

**IronCefSubprocess** is a binary located in your application's `bin` directory. It must be executable to be used by the .NET application.

Example usage (please note the path might differ):

```sh
chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

```sh
chmod 755 bin/runtimes/linux-x64/IronCefSubprocess
```

Here's the paraphrased section of the article:

-----
## Single-file Application Publishing on Linux with .NET

For deploying your project as a single-file application on a Linux environment, follow this procedure:
```sh
dotnet publish -r linux-x64 /property:PublishProfile=FolderProfile /bl
```

Here's the paraphrased section of the article:

```sh
dotnet publish --runtime linux-x64 --property:PublishSingleFile=true --self-contained true
```

## Handling Temporary File Paths

For certain scenarios, developers might need to designate a directory that permits the creation of temporary files.

A widely accepted and secure location for this directory on Linux systems is `/tmp/`. However, it's crucial that this directory is accessible and offers read and write permissions for the user.

Here's a paraphrased version of the provided code section:

```cs
// Define temporary directory path for IronPDF operations
string pathForTempFiles =  @"/tmp/";

// Configure log location for IronPDF
IronPdf.Logging.Logger.LogFilePath = pathForTempFiles;

// Set up environmental variables for temporary directory usage
Environment.SetEnvironmentVariable("TEMP", pathForTempFiles, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", pathForTempFiles, EnvironmentVariableTarget.Process);

// Assign temporary folder paths in IronPDF configuration
IronPdf.Installation.TempFolderPath = pathForTempFiles;
IronPdf.Installation.CustomDeploymentDirectory = pathForTempFiles;
```

