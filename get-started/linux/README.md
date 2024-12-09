# Working with IronPDF on Linux

***Based on <https://ironpdf.com/get-started/linux/>***


## Setup and Compatibility Guide

IronPDF fully supports Linux environments across **.NET Core** and **.NET versions 5, 6, 7, 8, and 9**, as well as on platforms like Docker, Azure, AWS, macOS, and of course, Windows.

### Supported Hosting and Containerization Platforms
![Linux Icon](https://img.icons8.com/color/96/000000/linux--v1.png)
![Docker Icon](https://img.icons8.com/color/96/000000/docker.png)
![Azure Icon](https://img.icons8.com/fluency/96/000000/azure-1.png)
![AWS Icon](https://img.icons8.com/color/96/000000/amazon-web-services.png)

### Supported Linux Distributions
![Ubuntu Icon](https://img.icons8.com/color/96/000000/ubuntu--v1.png)
![Debian Icon](https://img.icons8.com/color/96/000000/debian--v1.png)
![CentOS Icon](https://img.icons8.com/color/96/000000/centos--v1.png)

## Optimal IronPDF Configuration on Linux

For the best experience with IronPDF on Linux, it’s advised to use .NET Core 3.1 or other [Microsoft LTS versions](https://dotnet.microsoft.com/platform/support/policy), which offer extensive support and testing on Linux platforms.

IronPDF typically operates right out of the box on Linux, thanks to extensive testing and optimization by our engineering team.

Linux is a critical platform due to its prevalence in numerous cloud services such as Azure Web Apps and AWS EC2. At Iron Software, we're consistently utilizing and enhancing our tools in these cloud environments, acknowledging the needs of our Enterprise and SAAS clients.

## Hardware Requirements

IronPDF leverages the Chromium engine to convert HTML to PDF, providing a print-quality that mirrors Google Chrome’s capabilities. The primary resources requirement is for running Chromium:

- **Minimum**: 1 CPU core & 1.75 GB RAM
- **Recommended**: 2+ CPU cores & 8+ GB RAM

### Recommended Linux Distros

For a hassle-free set-up, IronPDF supports the latest **64-bit versions** of Linux OS including:

- Ubuntu: 22, 20, 18, 16
- Debian: 11 (the default on Microsoft Azure), 10
- CentOS: 8
- Fedora Linux: 33
- Amazon AWS Linux 2

Read the comprehensive [AWS Lambda Setup Guide for IronPdf](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

While these distributions are fully supported, setups on unsupported versions can be completed by following the “Other Linux Distros” section below.

Using [Microsoft's Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) is highly recommended. For other distros, configurations might need to involve manual setup using `apt-get`.

## Automatic Configuration for Linux

By default, IronPDF can automatically manage dependencies for you:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## Optimized NuGet Packages for Linux

```shell
:InstallCmd Install-Package IronPdf.Linux
```

Linux-optimized NuGet packages are documented in our [advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

Alternatively, [download the Linux-specific DLL directly](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Setup Tips for Docker on Linux

For detailed instructions on setting up Docker configurations using IronPDF, refer to our [documentation for Docker and Linux](https://ironpdf.com/how-to/docker-linux/).

## Ubuntu - Highly Compatible and Tested

Ubuntu is frequently used for our routine testing and continuous deployment, particularly because of its significant role within Microsoft’s Azure services and native .NET support.

### Ubuntu 20 Proficiency

![Microsoft Icon](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Icon](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Chrome Icon](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Icon](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Icon](https://img.icons8.com/color/48/000000/docker.png)
![Azure Icon](https://img.icons8.com/fluency/48/000000/azure-1.png)

Ubuntu 20 is perfectly set up right from the start.

- Backed by official Microsoft .NET Docker images for a direct and seamless experience.
- Supports multiple .NET runtimes including official LTS versions.

**Official Microsoft Docker Images:**

- [.NET Runtime 3.1 on Ubuntu 20.04 ('3.1-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 on Ubuntu 20.04 ('5.0-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Ubuntu 20 Setup:**
For manual setups or environments without admin rights:

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
# (IronCefSubprocess is typically located within the bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Compatibility and Configuration Guide

IronPDF is fully compatible with Linux and supports **.NET 9, 8, 7, 6, 5** as well as **.NET Core**. It integrates seamlessly in environments including Docker, Azure, AWS, and also runs well on macOS and Windows systems.

### Supported Platforms for Containerization and Hosting

IronPDF is compatible with various platforms for containerization and hosting, ensuring wide-ranging support across conventional systems such as Docker, cloud services like Azure and AWS, and different operating systems including macOS, Linux, and Windows.

![Linux Logo](https://img.icons8.com/color/96/000000/linux--v1.png)
![Docker Logo](https://img.icons8.com/color/96/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/96/000000/azure-1.png)
![AWS Logo](https://img.icons8.com/color/96/000000/amazon-web-services.png)

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />

### Supported Linux Distributions

We fully support and recommend these specific **64-bit** Linux distributions for an effortless and configuration-free setup with IronPDF:

- Ubuntu (Versions 22, 20, 18, and 16)
- Debian (Versions 11 and 10)
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2

For additional details on setting up IronPDF in environments that are not officially supported, please refer to the section on "Other Linux Distros" later in this document.

We also suggest utilizing Microsoft's [Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime) for these supported distributions. Installation on other Linux versions might require manual adjustments using `apt-get`. See the [Common Dependency Patterns for Linux](#anchor-other-linux-distros) at the end of this document for more information.

<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

## Best Practices for Using IronPDF on Linux

For optimal performance and stability, we suggest employing .NET Core 3.1 or any other [LTS versions provided by Microsoft](https://dotnet.microsoft.com/platform/support/policy), as they offer sustained support and are thoroughly vetted on Linux platforms.

IronPDF is designed to function smoothly on Linux right out of the box, requiring no modifications to your code. This seamless integration is the result of extensive testing and configuration by our dedicated team of engineers.

The integration of IronPDF with Linux is crucial, particularly given the widespread use of Linux-based cloud services such as Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker. At Iron Software, we frequently utilize these cloud solutions and recognize their importance to our clients in enterprise and SaaS sectors.

## Hardware Requirements

IronPDF leverages the Chromium engine to convert HTML content into PDFs, ensuring an output identical to Chrome's print functionality. This process is resource-intensive and primarily governed by the capabilities of the Chromium engine.

- **Minimum Configuration**: 1 CPU Core & 1.75 GB of RAM
- **Optimal Configuration**: 2 CPU Cores & 8 GB of RAM or more

### Supported Linux Distributions for IronPDF

IronPDF officially endorses and backs a seamless, "zero configuration" deployment on the latest 64-bit versions of the following Linux distributions:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11 _[Currently the default Linux distribution for Microsoft Azure]_
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2. For a detailed setup guide, please consult the [IronPDF AWS Lambda Setup Guide](https://ironsoftware.com/csharp/ocr/docs/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

For advice on setting up IronPDF on Linux versions that are not officially supported, kindly refer to the "Other Linux Distros" section later in this document.

We strongly recommend making use of Microsoft's [Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) for IronPDF deployments. While some other Linux distributions can be used, they may necessitate manual configuration through `apt-get`. More details on common dependency configurations for such cases can be found [here](#anchor-other-linux-distros).

## Automated Configuration on Linux

When enabled by setting `LinuxAndDockerDependenciesAutoConfig` to `true`, IronPDF will automatically handle the installation of necessary dependencies to function on Linux systems. The initial operation to convert HTML to PDF might experience a slight delay.

In the provided C# code snippet, IronPdf's configuration is set to automatically manage dependencies required for its operation on Linux and Docker environments:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## Optimized NuGet Packages for Linux

For deployments that are customized for Linux, IronPDF offers specialized NuGet packages. Details and instructions for using these packages can be found in our comprehensive [IronPDF NuGet Installation Guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These packages are curated to enhance your development experience on Linux, whether you're coding on a Windows or macOS workstation.

For those who prefer direct downloads, the DLL specifically tailored for Linux can be obtained [here](https://ironpdf.com/packages/IronPdf.Linux.zip).

### Installing Linux-Specific Packages

To install the Linux-specific package, run the following command:

```shell
:InstallCmd Install-Package IronPdf.Linux
```

This snippet will add the Linux-optimized IronPDF to your project, streamlining your deployments on Linux environments.

```shell
:InstallCmd Install-Package IronPdf.Linux
```

NuGet packages tailored for Linux are available to optimize IronPDF deployments. These are detailed in our [IronPDF advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

This optimized package allows for development on both Windows or macOS environments as well.

For another option, consider downloading the Linux-specific DLL directly from [this link](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Docker and Linux Configuration

For comprehensive guidance on configuring IronPDF within a Docker environment on Linux, please refer to our [detailed documentation](https://ironpdf.com/how-to/docker-linux/). This resource is invaluable for those looking to implement IronPDF in a Docker image.

Here is the paraphrased section:

## Compatibility with Ubuntu

Ubuntu ranks as our most extensively tested Linux distribution, primarily due to its significant usage within Azure infrastructure for our ongoing testing and deployment processes. Furthermore, Ubuntu enjoys robust support for Microsoft .NET and official Docker images.

### Configuring Ubuntu 20 for IronPDF

Ubuntu 20 is fully equipped for immediate use with IronPDF due to its comprehensive compatibility with the platform, predominantly because it frequently undergoes validation in Azure’s extensive test and deployment frameworks. The system supports both .NET and Docker environments, facilitating seamless operations.

#### Refined Compatibility Setup

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

For Ubuntu 20, IronPDF operates seamlessly and requires no additional configuration to start:

- Fully supports Chrome and WebKit-based PDF rendering engines directly.
- Natively compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** environments.
- Extensive testing includes over 997 unit tests per release, ensuring high reliability.

**Dedicated Microsoft Docker Images for Enhanced Performance**

Ubuntu 20 enjoys robust support with official Docker images supplied by Microsoft:

- [.NET Runtime 3.1 on Ubuntu 20.04 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 on Ubuntu 20.04 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

#### Manual Installation Guide for Ubuntu 20

For scenarios where administrative privileges are limited and automatic setup is not an option, IronPDF can still be manually configured:

Switch off automatic dependency configuration:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Execute the following commands to manually install necessary libraries:
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
# (IronCefSubprocess is typically located in bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

These steps ensure that even in constrained environments, IronPDF remains a reliable and robust solution for generating PDFs within Ubuntu 20 applications.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 20 is seamlessly compatible with IronPDF and does not require any configuration steps.

- IronPDF supports HTML to PDF conversion using both Chrome and WebKit rendering engines on Ubuntu 20.
- All stable .NET Core runtimes, including versions 3.1, 5, 6 (LTS), 7, and 8 are officially supported, and compatibility with additional .NET Core runtimes is also maintained.
- We systematically conduct over 997 unit tests on this platform with each software release to guarantee reliability and performance.

### Official Microsoft Docker Images for Ubuntu 20

- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Installation for Ubuntu 20

For scenarios where automatic installation is not feasible or if your application does not run with administrative privileges, you can disable the automatic dependency configuration:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here's the paraphrased content with references to Iron Software's IronPDF:

```sh
# Refresh the package lists for upgrades of packages that need upgrading as well as new package installations.

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
# Initiate the installation of libraries and dependencies necessary for running IronPDF on Linux.

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1 libgdiplus libva-dev

# Adjust permissions to ensure the IronCefSubprocess binary is executable.

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Typically found in the 'bin/runtimes/linux-x64/' directory of your application's installation folder.

***Based on <https://ironpdf.com/get-started/linux/>***

```

```sh
# IronCefSubprocess is a compiled binary located within your application's 'bin' directory. You might need to specify its exact location, potentially within the 'runtimes' subfolder under 'bin'.

***Based on <https://ironpdf.com/get-started/linux/>***


# Administrative privileges with 'sudo' may be required.

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Compatibility with Ubuntu 18

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully compatible with IronPDF right out of the box, providing a seamless "zero configuration" experience.

- Render HTML to PDF using either **Chrome** or **WebKit** engines.
- Full support for **.NET Core 3.1 LTS** and **.NET 5 runtimes**.
- Unofficial support extends to additional .NET Core runtimes for both Ubuntu 18 and Ubuntu 16.
- Every release undergoes extensive testing, including a rigorous set of smoke tests on this platform.

**Official Microsoft Docker Images:**

- [Ubuntu 18.04 64-bit Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- High compatibility with non-official Docker images for .NET 5 on Ubuntu 18.

**Setup Ubuntu 18 Manually:**
For setups that require manual intervention, or where the app does not have administrative rights:

Disable automatic dependency configuration:

```c#
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Execute the following commands to install necessary libraries:

```sh
apt update
apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0
apt install -y libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2
apt install -y libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1
apt install -y libxshmfence-dev

chmod 755 IronCefSubprocess
# (IronCefSubprocess is typically located in bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

Permission may be required (`sudo`) to execute these commands effectively.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully supported by IronPDF right out of the box, and it requires no additional configurations. Key features include:

- Integration with **Chrome** and **WebKit** for HTML to PDF conversions.
- Official compatibility with **.NET Core 3.1 LTS** and **.NET 5 runtimes**.
- Unofficial support extends to other .NET Core runtimes for both Ubuntu 18 and Ubuntu 16.
- Prior to each software release, extensive smoke tests are conducted on this platform to ensure reliability and performance.

### Official Docker Images for .NET on Ubuntu 18

- [.NET Runtime 3.1 on Ubuntu 18.04 (64-bit)](https://hub.docker.com/_/microsoft-dotnet-runtime/) is available as '3.1-bionic'.
- Although there is no specific Docker image for .NET 5 on Ubuntu 18, its compatibility is robust and tested.

### Manual Installation on Ubuntu 18

For scenarios where manual installation is necessary, or when your application cannot be run with administrative privileges, start by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`. This adjustment will prevent automatic dependency configuration, enabling more control over the installation and setup process.

```sh
# Update package lists

***Based on <https://ironpdf.com/get-started/linux/>***

apt update

# Install necessary packages for Ubuntu 18 compatibility with IronPDF

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Update the permissions to ensure the IronCefSubprocess is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is usually located within bin/runtimes/linux-x64 directory of your application

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Compatibility with Ubuntu 16

Ubuntu 16 receives limited and unofficial support from IronPDF, reflecting that it has not undergone extensive testing with our software.

Microsoft officially supports .NET for Ubuntu 16, which has demonstrated compatibility with IronPDF based on user experiences. However, developers may need to handle dependency installations manually.

- Both **Chrome** and **WebKit** engines can be utilized for HTML to PDF conversions with specific configurations.
- **.NET Core 3.1 LTS** and **.NET 5 runtimes** are supported by Microsoft for Ubuntu 16.
- There are no official Microsoft Docker images provided for Ubuntu 16.

#### Manual Configuration for Ubuntu 16

For instances where auto-installation isn’t feasible or if you don't have administrative privileges:

Disable automatic dependency management:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Execute the following commands to install the required libraries:
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
# (IronCefSubprocess is usually located at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

-----
Support for Ubuntu 16 in conjunction with IronPDF is limited and not extensively tested.

Ubuntu 16 is compatible with .NET and receives official support from Microsoft, with many developers successfully integrating it with IronPDF. However, installation of certain dependencies via `apt-get` may be required manually.

Both Chrome and WebKit are capable of functioning with manual configuration on this OS. Additionally, the .NET Core 3.1 LTS and .NET 5 runtimes are supported by Microsoft for Ubuntu 16. It's important to note that there are no official Microsoft Docker images available for Ubuntu 16 at this time.

### Setting Up Ubuntu 16 Manually

For those installations where administrative privileges (`sudo`) are not available or preferred, manual installation can be carried out.

Initially, ensure to disable the automatic configuration setting for installing Linux and Docker dependencies by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`. This allows for controlled, manual setup as needed.

```sh
# Update package lists from the repository

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
# Install necessary libraries for IronPDF functionality

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6-dev  # C Library, development files
apt install -y libgtk2.0-0  # GTK+, graphical user interface library
apt install -y libnss3  # Network Security Services
apt install -y libatk-bridge2.0-0  # Accessibility Toolkit bridge
apt install -y libx11-xcb1  # X11 client-side library
apt install -y libxcb-dri3-0  # XCB DRI3 extension
apt install -y libdrm-common  # Direct Rendering Manager, shared libraries
apt install -y libgbm1  # Generic Buffer Management
apt install -y libasound2  # ALSA library
apt install -y libappindicator3-1  # Application indicators
apt install -y libxrender1  # X Rendering Extension client library
apt install -y libfontconfig1  # Font configuration
apt install -y libxshmfence-dev  # X Sync-Fence library, development files

# Set execution permission for IronCefSubprocess within binaries folder

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# (Typically located in the bin/runtimes/linux-x64 directory)

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Compatibility with Debian

Debian ranks as the second most extensively tested Linux OS for our applications within Iron Software’s suite. This operating system enjoys robust support from Microsoft.NET as well as certified Docker images.

### Debian 11 Compatibility

![Debian 11](https://img.icons8.com/color/48/000000/debian.png) ![Microsoft](https://img.icons8.com/color/48/000000/microsoft.png) ![Chrome](https://img.icons8.com/color/48/000000/chrome--v1.png) ![Safari](https://img.icons8.com/color/48/000000/safari--v1.png) ![Docker](https://img.icons8.com/color/48/000000/docker.png) ![Azure](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 11 is fully supported by IronPDF right out of the box, making it exceptionally easy to integrate with no additional configuration needed.

- Supported rendering engines include both Chrome and WebKit for HTML to PDF conversions.
- We provide full support for .NET Core runtimes including 3.1, 5, 6 (LTS), 7, and 8.
- Though primarily the above runtimes are supported, other .NET Core versions may work based on our compatibility testing.
- Our release cycle includes over 997 unit tests targeted specifically at Debian 11 to ensure reliability.

**Available Official Microsoft Docker Images:**

- [.NET Runtime 3.1 on 64-bit Debian 11](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 on 64-bit Debian 11](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting up Debian 11 Manually**

If your app doesn't have admin privileges or you prefer manual installation:

Set `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false;`

```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxkbcommon-x11-0 libxrender1 libfontconfig1 libxshmfence1

chmod 755 IronCefSubprocess
# Path to IronCefSubprocess normally found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

_Debian 11 serves as Microsoft's default choice for Linux distribution when Docker support is integrated to a .NET project via Visual Studio._

IronPDF is fully operational on Debian 11 right from the get-go, not requiring any configuration adjustments.

- Facilitates HTML to PDF conversion using **Chrome** and **WebKit** engines
- Provides comprehensive support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes
- Extends support to several additional .NET Core runtimes on Debian 11 although not officially
- Executes more than 997 unit tests on this environment with every update rollout

**Relevant Microsoft Docker Images:**

- [64-bit Docker image for .NET Runtime 3.1 on Debian 11](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Docker image for .NET Runtime 5.0 on Debian 11](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Guidance for Manual Installation on Debian 11**

For instances where manual installation is needed or when your application lacks _sudo_ admin privileges:

Simply disable the automatic configuration setting by assigning `false` to `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig`.

Here's the paraphrased section:

```sh
# Update the package listings

***Based on <https://ironpdf.com/get-started/linux/>***

apt update

# Install essential libraries required for IronPDF to function

***Based on <https://ironpdf.com/get-started/linux/>***

apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1
apt install -y libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxkbcommon-x11-0
apt install -y libxrender1 libfontconfig1 libxshmfence1

# Modify the permissions of the IronCefSubprocess binary to make it executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is usually located in the bin/runtimes/linux-x64/ directory of your project.

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Debian 10 Compatibility

![Debian 10 Logo](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 10 is completely compatible with IronPDF right out of the box, without any need for additional setup.

- Compatible with **Chrome** and **WebKit** based HTML to PDF rendering engines.
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7 and 8** runtimes.
- While not officially supported, many other .NET Core runtimes function well on Debian 10.
- Prior to release, we conduct over 997 unit tests to ensure reliability on this distribution.

**Microsoft’s Official Docker Images:**

- [Debian 10 Docker image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Debian 10 Docker image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting Up Debian 10 Manually:**
For situations where your application cannot operate with administrator privileges, disable automatic configuration:

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
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

chmod 755 IronCefSubprocess
# (IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory)

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

---
Debian 10 is immediately compatible with IronPDF, requiring no additional configuration.

- Enables HTML to PDF conversions using **Chrome** and **WebKit** rendering engines.
- Provides full support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Offers compatibility, although not officially supported, with additional .NET Core runtimes on Debian 10.
- Executes more than 997 unit tests on this environment with each software release.

**Certified Microsoft Docker Images for Debian 10:**
- [64-bit Debian 10 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 10 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Guidance for Manual Installation on Debian 10**  
For setups where manual installation is necessary or if the application cannot operate with _sudo_ administrative rights:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```
---

Here's the paraphrased section with the URL resolved:

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

# Ensure IronCefSubprocess is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Location typically in the bin/runtimes/linux-x64 directory

***Based on <https://ironpdf.com/get-started/linux/>***

``` 

Please let me know if there's any other specific section or part you would like to paraphrase or if additional modifications are needed!

### Support for Debian 9 and Earlier Versions

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 and its predecessors are not fully tested and do not offer out-of-the-box functionality for IronPDF. Nevertheless, .NET users on Debian 9 can achieve compatibility with IronPDF through appropriate configurations. It’s important to note that as of now, official Docker images for .NET Core 3.1 or .NET 5.0 are not available for Debian 9 from Microsoft. Developers are encouraged to upgrade to Debian 10 for enhanced support and simpler setup procedures.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 has not undergone official testing with IronPdf and may not function seamlessly immediately after installation. Nonetheless, given Microsoft's official support for .NET on Debian 9, IronPdf could still be effectively utilized with appropriate configuration adjustments.

For more details on setting up IronPdf on Debian 9, refer to the section ["Common Dependency Patterns for Linux"](https://ironsoftware.com/#anchor-other-linux-distros) towards the end of this article.

Additionally, there are no sanctioned Docker images from Microsoft specifically for .NET Core 3.1 or .NET 5.0 tailored to Debian 9. As a result, upgrading to Debian 10 is strongly advised for a smoother experience and better support.

## Compatibility with CentOS

![CentOS Logo](https://img.icons8.com/color/48/000000/centos.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Test Logo](https://img.icons8.com/fluency/48/000000/test.png)

CentOS is fully supported and recommended by IronPDF for integrating PDF functionalities.

### CentOS 8 Guidelines

CentOS 8 is completely supported right out of the box with no need for additional configuration.

- Supports PDF rendering via **Chrome** and **WebKit** engines
- Supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8**
- Provides partial support for other .NET Core versions on CentOS
- Rigorous smoke tests are performed for each update

There are no official Docker images by Microsoft for .NET versions 3.1 or 5.0 on CentOS 8.

**Manual Configuration for CentOS 8**

For setups without root privileges or for specific adjustments, disable automatic dependency handling:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Proceed to manually install the necessary libraries:

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

# Make the IronCefSubprocess executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# (IronCefSubprocess is normally located in the bin/runtimes/linux-x64/ directory)

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Prior

CentOS 7 and prior versions are not tested and hence are not guaranteed to work seamlessly with IronPDF. However, since .NET is officially supported on CentOS 7 by Microsoft, it might be compatible with manual setup. Consider consulting the section on **Common Dependency Patterns for Linux** further down for guidance on setups for unsupported CentOS versions.

Microsoft does not offer official Docker images for .NET Core 3.1 or .NET 5.0 in CentOS 7 versions.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

### CentOS Compatibility Overview

Iron Software has a strong affinity for CentOS and actively supports it. This commitment ensures that CentOS is fully compatible with IronPDF, providing a seamless experience right from installation with _zero configuration_ required.

#### Enhanced Support for CentOS 8

CentOS 8 comes with comprehensive support for IronPDF. Users can expect excellent compatibility with **Chrome** and **WebKit** based HTML to PDF rendering engines. Supported .NET Core runtimes on CentOS 8 include **3.1, 5, 6 (LTS), 7, and 8**. Additionally, our team conducts extensive smoke tests on CentOS 8 to guarantee robust performance before each software release.

Despite the solid compatibility, it should be noted that no official Docker images for .NET Core 3.1 or .NET 5.0 are available for CentOS 8 from Microsoft.

##### Manual Setup for CentOS 8

For manual installations or in cases where the application cannot be run with _sudo_ privileges, the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` setting should be disabled:

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Following this setting change, the necessary dependencies can be installed using the command below:

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

chmod 755 IronCefSubprocess  # Typically located in the bin/runtimes/linux-x64 directory
```

#### Limited Support for CentOS 7 and Below

CentOS 7 and earlier versions are not implicitly compatible with IronPDF and have not undergone the same extent of testing. If .NET is operational on CentOS 7, IronPDF may be functional if configured properly. Please refer to the "Common Dependency Patterns for Linux" section for guidance on setup. Additionally, Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 on CentOS 7.

### CentOS 8 Compatibility

IronPDF is fully compatible with CentOS 8 right out of the box, requiring no additional configurations.

- Enables **Chrome** and **WebKit** for HTML to PDF conversions
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes
- Provides unofficial support for various other .NET Core runtimes on CentOS
- Undergoes extensive smoke testing before each release

Unfortunately, Microsoft does not provide official Docker images for either .NET Core 3.1 or .NET Core 5.0 on CentOS 8.

**Setting up CentOS 8 Manually**

For manual installations or in cases where your application does not have _sudo_ administrative rights:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update system packages

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y update

# Install necessary libraries

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

# Make the IronCefSubprocess executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Earlier Versions

CentOS 7 lacks official testing and compatibility with IronPdf isn't guaranteed right out of the box.

Nonetheless, given that Microsoft officially supports .NET on CentOS 7, there's a considerable probability that IronPdf might function properly if configured appropriately (refer to "[Common Dependency Patterns for Linux](#anchor-other-linux-distros)" further down for guidance).

Regrettably, Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 tailored to CentOS 7.

## Compatibility with Amazon AWS Linux 2

![Amazon Web Services Icon](https://img.icons8.com/color/48/000000/amazon-web-services.png)
![Chrome Icon](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Icon](https://img.icons8.com/color/48/000000/safari--v1.png)
![Testing Icon](https://img.icons8.com/fluency/48/000000/test.png)

IronPDF is functional on Amazon AWS Linux 2, laying the foundation for Amazon's extensive cloud offerings like EC2 and Lambda.

- There are currently no Microsoft-provided Docker images for either .NET Core 3.1 or .NET 5.0 specific to Amazon AWS Linux 2.
- Our development process includes manual testing phases to ensure IronPDF behaves reliably on Amazon AWS Linux 2.

For a facilitated IronPDF installation on AWS Linux 2, our [IronPDF AWS Lambda guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) offers detailed Docker file instructions.

**Manual Installation on Amazon AWS Linux 2**

For scenarios where automatic installation isn't suitable or administrative rights are restricted, you can configure IronPDF manually by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to false.

Execute these commands to ensure all dependencies are met:

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

chmod 755 IronCefSubprocess  # Make IronCefSubprocess executable
```

Be sure to make the `IronCefSubprocess` file executable, typically found in the `bin/runtimes/linux-x64/` directory of your application.

For more detailed guidance on setting up IronPDF on Amazon's cloud platform, kindly refer to our [official documentation on IronPDF for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) which includes essential setup and logging information.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

IronPDF offers stable support for Amazon AWS Linux 2, which is integral to Amazon's cloud services like EC2 and Lambda. However, because Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 on Amazon AWS Linux 2, our compatibility tests continue to be conducted manually during the development of IronPDF.

For more detailed information, consider exploring our [IronPDF AWS Lambda guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), which included a functional Docker file tailored for deploying IronPdf on AWS Lambda.

### Instructions for Manual Installation on Amazon Linux 2

Should you need to proceed with a manual installation of IronPDF on Amazon AWS Linux 2 or if your application does not have _sudo_ administrative privileges, begin by setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here's the paraphrased section of the article, with updated paths for images and links resolved to ironpdf.com:

```sh
# Update system packages

***Based on <https://ironpdf.com/get-started/linux/>***

yum update -y

# Install necessary libraries and components

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

# Ensure the IronPDF subprocess is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# (Typically located in bin/runtimes/linux-x64 within your application directory)

***Based on <https://ironpdf.com/get-started/linux/>***

```

Please consult our detailed guide on [IronPdf support for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), which covers both installation and logging procedures tailored for the Amazon cloud environment.

## Compatibility with Fedora Linux

Fedora Linux enjoys full compatibility with IronPDF.

IronPDF flawlessly supports Fedora Linux 33 right out of the box, requiring no additional configuration to get started.

- Supports HTML to PDF rendering using both **Chrome** and **WebKit** engines.
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- Before each release, extensive smoke tests are performed on this platform to ensure reliability.

**Setting Up Fedora Linux Manually**

In situations where you need to install manually or if your application can't operate under _sudo_ admin privileges—particularly applicable for different builds of Fedora Linux—you can follow the steps below.

You should first disable automatic dependency resolution:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update system and install necessary libraries for IronPDF operation on CentOS or Fedora.

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Update permissions for the IronCefSubprocess to ensure it is executable.

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 /path/to/your/project/bin/runtimes/linux-x64/IronCefSubprocess
# Note: Replace '/path/to/your/project/' with your actual project path.

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Compatibility with Alpine Linux

Unfortunately, Alpine Linux does not currently support IronPDF. Despite our appreciation for Alpine and our desire for its continued development, the operating system's reliance on outdated "musl" C libraries prevents full support from Chromium developers as of 2023.

### Deploying IronPdf with Alpine Docker in .NET 6

IronPdf offers a comprehensive container image that embeds all its capabilities. This approach allows projects leveraging Alpine to harness the full suite of functionalities from IronPdf by connecting to the IronPdfEngine container.

#### Step 1: Download and Launch IronPdf Engine Docker Image

To download and initiate the IronPdf Engine Docker image, execute these commands in your terminal:

```shell
docker pull ironsoftwareofficial/ironpdfengine
docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

Here's the paraphrased section of the article:

```shell
# Fetch the Docker image for IronPDF Engine from Iron Software's official repository

***Based on <https://ironpdf.com/get-started/linux/>***

docker pull ironsoftwareofficial/ironpdfengine
```

Here's the paraphrased content:

```shell
# Run IronPdf Engine Docker image in detached mode

***Based on <https://ironpdf.com/get-started/linux/>***

docker run -d --publish 33350:33350 ironsoftwareofficial/ironpdfengine
```

Here is the paraphrased section of the article:

---
Step 2: Configuring the Console App

Start by creating a fresh console application that targets .NET 6.

Next, utilize the NuGet Package Manager to incorporate the IronPdf.Slim NuGet package into your project.
---

## Installation on Various Linux Distributions

IronPDF prerequisites can be installed manually using package management commands such as **apt-get**, **hfs**, and **yum**. This approach is particularly useful when you want to implement IronPDF on Linux distributions that aren't officially supported.

Typically, the first installation attempt may trigger exceptions from IronPDF, alerting you to any missing system dependencies that need to be resolved.

- The **IronCefSubprocess** file referenced below is a binary located within your project's `bin` directory, potentially under the `runtimes` subfolder. It is crucial to determine and specify the correct path.
- Execution might require `sudo` privileges for appropriate access and modifications.

Should you face uncertainty on how to handle installations on Linux distributions not explicitly listed, it's advisable to review the dependencies needed by the **Chromium** browser for that specific OS.

For requests on adding official support for additional Linux distributions, please submit your suggestions to [support@ironsoftware.com](mailto:support@ironsoftware.com).

### Typical Dependency Requirements Across Linux Platforms

It's beneficial to familiarize yourself with common dependency needs as outlined for various other Linux environments discussed earlier in the documentation.

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

# Set IronCefSubprocess permissions to executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is usually located in the bin/runtimes/linux-x64/ directory.

***Based on <https://ironpdf.com/get-started/linux/>***

```

## IronCefSubprocess

**IronCefSubprocess** is a crucial binary file located in your application's `bin` directory. It must be granted executable permissions to function correctly within the .NET environment.

For example, the path to this file might differ, but generally, it can be found and modified as follows:

```sh
chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

```sh
# Grant execution permissions to the IronCefSubprocess binary.

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

Here's the paraphrased content for the specified section:

---

## Single-File Deployment in Linux with .NET

To deploy your .NET project as a single executable file in Linux, follow these steps:

Here's the paraphrased section of the article, with the relative URL path resolved:

```sh
# Command to publish .NET project for Linux x64 environment

***Based on <https://ironpdf.com/get-started/linux/>***

dotnet publish -r linux-x64 --property:PublishProfile=FolderProfile /bl
```

## Configuration of Temporary File Paths

For certain operations, developers may need to designate a directory that allows for the creation of temporary files.

Typically, `/tmp/` is used on Linux as a reliable and secure location for these files, ensuring that the directory allows both read and write access.

```cs
// Configuration for temporary path used by IronPDF
string tempDirectoryPath = @"/tmp/";

// Setting up IronPDF logging to use the specified temporary path
IronPdf.Logging.Logger.LogFilePath = tempDirectoryPath;

// Configuring the system environment variables for temporary storage
Environment.SetEnvironmentVariable("TEMP", tempDirectoryPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", tempDirectoryPath, EnvironmentVariableTarget.Process);

// Pointing IronPDF to use the defined temporary directory for operations
IronPdf.Installation.TempFolderPath = tempDirectoryPath;
IronPdf.Installation.CustomDeploymentDirectory = tempDirectoryPath;
```

