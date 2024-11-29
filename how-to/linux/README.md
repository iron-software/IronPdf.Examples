# IronPDF Linux Compatibility & Setup Guide

***Based on <https://ironpdf.com/how-to/linux/>***


IronPDF is compatible with Linux environments and supports applications developed with **.NET 8, 7, 6, 5**, as well as **.NET Core**. It also seamlessly integrates with Docker, Azure, AWS, macOS, and Windows platforms.

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

We suggest employing .NET Core 3.1 or other [LTS versions as designated by Microsoft](https://dotnet.microsoft.com/platform/support/policy), which offer long-term support and have undergone extensive testing on Linux platforms.

There is no need for modifications in your code to use IronPDF on Linux; it typically functions seamlessly right from the start, a testament to the extensive testing and optimization efforts undertaken by our engineering team.

The integration of Linux is crucial due to its widespread use in numerous cloud environments like Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker. At Iron Software, we frequently utilize these technologies and recognize their significance for our Enterprise and SAAS clientele.

## System Requirements for IronPDF

IronPDF leverages the Chromium engine to convert HTML into PDFs, achieving the same quality as Chrome's printing functionality. The specified hardware requirements are essential for efficiently running the Chromium engine, as it demands significant computational resources.

- **Minimum Configuration**: Requires at least 1 CPU core and 1.75 GB of RAM.
- **Recommended Configuration**: Ideally, the system should have 2 CPU cores and at least 8 GB of RAM.

### Supported Linux Distributions for IronPDF

IronPDF fully supports and recommends the use of the following **64-bit** Linux distributions for a hassle-free installation experience:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11 (Default Linux Distro for Microsoft Azure)
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2. For details on AWS Lambda configurations, refer to our [AWS Lambda Setup Guide for IronPdf](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

For Linux operating systems not listed above, please see the section titled "Other Linux Distros" for guidance on setting up IronPDF.

We advise utilizing the [Official Docker Images provided by Microsoft](https://hub.docker.com/_/microsoft-dotnet-runtime/) for the most reliable experience. Other distributions may be compatible but could require additional manual configuration through commands like apt-get. For further information on dependency management for such distributions, refer to the "Common Dependency Patterns for Linux" section found at the end of this document.

## Automated Linux Configuration

By default, when the setting `LinuxAndDockerDependenciesAutoConfig` is enabled (`true`), it automatically handles the installation of all required dependencies for IronPDF to operate on Linux systems. Be aware, the initial HTML-to-PDF conversion might take additional time.

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## NuGet Packages Optimized for Linux

There are specialized NuGet packages available specifically for IronPDF deployments on Linux platforms. These packages are detailed in our [IronPDF Advanced NuGet Installation Guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

You can leverage these optimized packages for Linux, and they are fully compatible with development environments on Windows or macOS as well.

For direct access, you can [download the Linux DLL here](https://ironpdf.com/packages/IronPdf.Linux.zip).

Here's the paraphrased version of the specified section:

```shell
# Install the package optimized for Linux environments

***Based on <https://ironpdf.com/how-to/linux/>***

dotnet add package IronPdf.Linux
```

NuGet Packages specifically designed for Linux-based IronPDF implementations are detailed in our [IronPDF advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These packages enable you to develop using Linux-optimized IronPDF, even if you are working from a Windows or macOS environment.

For direct installation, you may [download the Linux-specific DLL here](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Docker and Linux Configuration

For detailed guidance on configuring IronPDF within a Docker environment, please refer to our comprehensive [documentation on implementing IronPDF with Docker](https://ironpdf.com/how-to/docker-linux/). This resource will assist you in creating and managing Docker images that leverage IronPDF.

## Compatibility with Ubuntu

Ubuntu ranks as our most rigorously tested Linux OS, primarily due to its extensive use within the Azure ecosystem for our ongoing testing and deployment processes. Additionally, this platform benefits from robust support for Microsoft .NET and official Docker images.

### Compatibility with Ubuntu 20

Ubuntu 20 is fully compatible with IronPDF and requires no additional configuration. This Linux distribution is extensively tested due to its heavy usage within Microsoft Azure's infrastructure, which we utilize for continuous integration and deployment.

![Microsoft logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Google Chrome logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Apple Safari logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker logo](https://img.icons8.com/color/48/000000/docker.png)
![Microsoft Azure logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

Key advantages include:
- Enhanced support for **Chrome** and **WebKit** as HTML to PDF engines.
- Complete compatibility with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes directly supported by IronPDF.
- Ongoing validation includes running over 997 unit tests on this platform before each software release.

#### Official Docker Images for Ubuntu 20:
- [Ubuntu 20.04 Docker Image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Ubuntu 20.04 Docker Image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

#### Manual Installation on Ubuntu 20
For manual setups or installations without _sudo_ privileges, disable auto-configuration by setting:
```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Execute the following commands to install the necessary libraries:
```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1 libgdiplus libva-dev
```
Adjust the permissions for `IronCefSubprocess`:
```sh
chmod 755 IronCefSubprocess
# (Typically located at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/how-to/linux/>***

```
**Note:** The exact path for `IronCefSubprocess` might vary and it's located in the `runtimes` sub-directory of `bin`. Admin privileges might be requisite for these commands.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 20 is seamlessly supported by IronPDF without any need for additional configuration.

- Enables HTML to PDF conversions utilizing both **Chrome** and **WebKit** rendering engines.
- Provides robust support for multiple **.NET Core** runtimes including **3.1, 5, 6 (LTS), 7, and 8**.
- Additional, informal support is available for other .NET Core versions on Ubuntu 20.
- Extensive testing is conducted with more than 997 unit tests executed on this platform for each software release.

### Official Microsoft Docker Images

- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Setup for Ubuntu 20

For manual installations, or in situations where it's not possible to run applications with administrative privileges:

Deactivate automatic dependency management by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false;`.

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
apt install -y libgdiplus
apt install -y libva-dev

# Make IronCefSubprocess executable.

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Typically found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

```
- The **IronCefSubprocess** binary file, referred to below, can be found within your application's `bin` directory. It may be necessary to specify the full path, potentially located within the `runtimes` folder of the `bin` directory.

- Execution of this operation might require `sudo` privileges.
```

### Ubuntu 18 Support

IronPDF is fully compatible with the Ubuntu 18 operating system, providing seamless integration right out of the box, requiring no additional configuration.

![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

Key Features:
- Provides support for **Chrome** and **WebKit** browsers in HTML to PDF conversions.
- Fully compatible with **.NET Core 3.1 LTS** and **.NET 5** runtimes.
- While the focus is on the officially supported runtimes, other versions of .NET Core may also be compatible with Ubuntu 18.
- Every new release undergoes rigorous smoke tests on this platform to ensure stability and performance.

**Docker Images Supported by Microsoft:**
- [64-bit Ubuntu 18.04 Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- While there is no official .NET 5 Docker image for Ubuntu 18 from Microsoft, compatibility is robust.

**Manual Setup for Ubuntu 18:**
For scenarios where direct installation with root access isn’t feasible:

Disable automatic dependency configuration:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Manually installing the required libraries:
```sh
apt update
apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev
chmod 755 IronCefSubprocess
# IronCefSubprocess should be located in your bin/runtimes/linux-x64 directory

***Based on <https://ironpdf.com/how-to/linux/>***

```
Ensure the `IronCefSubprocess` binary is executable, adjusting its location if necessary based on your application's directory structure.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully compatible with IronPDF and requires no initial configuration to start using.

- Enables HTML to PDF conversions via **Chrome** and **WebKit** rendering engines
- Provides built-in support for **.NET Core 3.1 LTS** and **.NET 5 runtimes**
- Extends unofficial support to various other .NET Core runtimes, including those on Ubuntu 18 and Ubuntu 16
- Undergoes thorough smoke testing on Ubuntu 18 ahead of each product release

**Official Microsoft Docker Images for Ubuntu 18:**

- [Ubuntu 18.04, 64-bit Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- Despite the absence of an official .NET 5 Docker image, Ubuntu 18 maintains high compatibility levels with .NET 5.

**Manual Configuration for Ubuntu 18**

In scenarios where manual installation is required or if the application doesn't have _sudo_ admin privileges, opt out of automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

Here's the paraphrased section, with updated URLs and proper formatting for the markdown:

```sh
# Update package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install required libraries and components

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Make IronCefSubprocess executable; typically located in the bin/runtimes/linux-x64 directory

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# (Usually found at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/how-to/linux/>***

```

### Ubuntu 16 Compatibility

![Ubuntu](https://img.icons8.com/color/48/000000/ubuntu--v1.png) ![Testing](https://img.icons8.com/fluency/48/000000/test.png)

Ubuntu 16 receives limited support and hasn't undergone extensive testing with IronPdf. 

- While .NET supports Ubuntu 16 officially, and it is reported to be compatible with IronPdf by numerous users, you might need to manually configure dependencies using `apt-get`.
- Rendering Engines like **Chrome** and **WebKit** are generally compatible with some manual configuration.
- .NET Core versions **3.1 LTS** and **.NET 5 runtimes** are supported by Microsoft on this distribution.
- There are no official Microsoft Docker images available for Ubuntu 16, pointing to potential limitations in automatic configurations.

#### Manual Setup for Ubuntu 16

If automated installations or running applications with _sudo_ privileges isn't feasible, you can manually install dependencies by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

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
# (The IronCefSubprocess binary is typically located in the bin/runtimes/linux-x64 directory)

***Based on <https://ironpdf.com/how-to/linux/>***

```

These manual steps ensure that all necessary libraries and configurations are in place for effective operation of IronPdf on Ubuntu 16 systems.

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Support for Ubuntu 16 in conjunction with IronPDF is non-official and limited; IronPDF has not been subjected to extensive testing on this operating system.

Microsoft's .NET, particularly versions .NET Core 3.1 LTS and .NET 5, is fully supported on Ubuntu 16 and many users report successful integrations with IronPDF, albeit with possible manual installations of dependencies.

The compatibility with **Chrome** and **WebKit** for HTML to PDF conversions is achievable through manual configurations. However, note that there are no officially released Microsoft Docker images tailored for Ubuntu 16 at this time.

### Manual Installation on Ubuntu 16

For scenarios where your application cannot be run with _sudo_ privileges, or you prefer a manual setup:

Disable the automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false;`—this will require manual configuration and installation of necessary packages.

```sh
# Update the package list

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install essential libraries and dependencies

***Based on <https://ironpdf.com/how-to/linux/>***

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

# Make IronCefSubprocess executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess typically resides in the bin/runtimes/linux-x64/ directory.

***Based on <https://ironpdf.com/how-to/linux/>***

```

## Debian Support Details

Debian ranks as the second most rigorously tested operating system for our purposes, after Ubuntu. It is fully backed by official Microsoft .NET support and benefits from having official Docker images available.

With this robust testing and support, IronPDF ensures high reliability and seamless integration when deployed in environments based on Debian. Whether you're using Docker or traditional hosting methods, Debian provides a solid foundation for running IronPDF with confidence.

### Debian 11 Compatibility

Debian 11 is configured out-of-the-box, requiring no special setup to work with IronPDF. This makes it a default choice in many Microsoft projects involving Docker and .NET in Visual Studio due to its straightforward integration.

![Debian 11](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft](https://img.icons8.com/color/48/000000/microsoft.png)
![Google Chrome](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker](https://img.icons8.com/color/48/000000/docker.png)
![Azure](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 11 is compatible with IronPDF and supports rendering engines based on Chrome and WebKit for HTML to PDF conversions. It officially supports multiple .NET Core runtimes including **.NET Core 3.1, 5, 6 (LTS), 7, and 8**. While these versions are officially supported, IronPDF also functions with other .NET Core runtimes on Debian 11.

To ensure robust performance and compatibility, over 997 unit tests are executed on this platform prior to each software release. This rigorous testing underscores our commitment to delivering a reliable product.

**Official Docker Images for Debian 11:**

- [.NET Runtime 3.1 (64-bit) Debian 11 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 (64-bit) Debian 11 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

Should there be a need for manual installation or in scenarios where administrative rights are restricted:

1. Disable automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.
2. Update the package lists and install the necessary libraries:

```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxkbcommon-x11-0 libxrender1 libfontconfig1 libxshmfence1
chmod 755 IronCefSubprocess
# Adjust the path as required, usually found in bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

These steps will ensure that your application is equipped to run IronPDF on Debian 11, even under restricted permissions.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 11 is the chosen Linux distribution by Microsoft for integrating Docker into a .NET project within Visual Studio.

IronPDF fully supports Debian 11 right out of the gate, requiring no additional configuration.

- Enables HTML to PDF conversions via **Chrome** and **WebKit** rendering engines.
- Provides official support for **.NET Core** versions 3.1, 5, 6 (LTS), 7, and 8.
- Offers unofficial compatibility with many more .NET Core runtimes on Debian 11.
- Executes over 997 Unit tests on this platform during each release cycle.

**Official Docker Images by Microsoft:**

- [64-bit Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting Up Manually in Debian 11**

For manual installations or scenarios where your application cannot be run with administrative (_sudo_) privileges:

Set `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;` to manage dependencies manually.

Here's the paraphrased section of the article, with relative URL paths resolved to `ironsoftware.com`:

```sh
# Update package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install required dependency packages

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libc6-dev  # C library development files
apt install -y libgtk2.0-0  # GTK graphical user interface library
apt install -y libnss3  # Network Security Services
apt install -y libatk-bridge2.0-0  # Accessibility Toolkit
apt install -y libx11-xcb1  # X11 client-side library
apt install -y libxcb-dri3-0  # X protocol C-language Binding
apt install -y libdrm-common  # Direct Rendering Manager
apt install -y libgbm1  # Generic Buffer Management API
apt install -y libasound2  # ALSA sound library
apt install -y libxkbcommon-x11-0  # XKB common library for X11
apt install -y libxrender1  # rendering extension client library
apt install -y libfontconfig1  # Font configuration and customization library
apt install -y libxshmfence1  # X shared memory fences

# Change permissions of the IronCefSubprocess binary to ensure it's executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located within the 'bin/runtimes/linux-x64/' directory of your application.

***Based on <https://ironpdf.com/how-to/linux/>***

```

This version maintains the same technical cadence while rephrasing descriptions and commands for clarity and readability.

### Debian 10 Compatibility

![Debian 10](https://img.icons8.com/color/48/000000/debian.png) ![Microsoft](https://img.icons8.com/color/48/000000/microsoft.png) ![Chrome](https://img.icons8.com/color/48/000000/chrome--v1.png) ![Safari](https://img.icons8.com/color/48/000000/safari--v1.png) ![Docker](https://img.icons8.com/color/48/000000/docker.png) ![Azure](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 10 is fully supported and operational with IronPDF right from the start, requiring no special configuration efforts.

- Supports **Chrome** and **WebKit** engines for converting HTML to PDF.
- Fully compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Offers support for several other .NET Core runtimes, though considered unofficial.
- Each release is preceded by over 997 unit tests ensuring reliability and robust performance.

**Official Docker Releases:**

- [64-bit Debian 10 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 10 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup for Debian 10**

For setups where administrative rights are restricted or for manual configurations, disable automatic dependency configuration:

```csharp
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

chmod 755 IronCefSubprocess
# (IronCefSubprocess is usually located at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/how-to/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 10 is fully compatible with IronPDF right out of the gate, requiring no special configuration to function optimally.

- The system supports HTML to PDF conversion using both **Chrome** and **WebKit** rendering engines.
- There's formal support for **.NET Core** versions **3.1, 5, 6 (LTS), 7, and 8**.
- While not officially listed, numerous other **.NET Core** runtimes can also run on Debian 10.
- We ensure reliability through more than 997 unit tests conducted on this operating system with each new release.

### Official Microsoft Docker Images for Debian 10

- [.NET Runtime 3.1 for 64-bit Debian 10](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 for 64-bit Debian 10](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Installation on Debian 10

For installations without administrative (`sudo`) privileges or for those who prefer manual setup:

You'll need to disable automatic dependency management settings:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here is the paraphrased content as requested, with the relative URL paths resolved to `ironsoftware.com`:

-----

```sh
# Update the package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install necessary libraries for IronPDF compatibility

***Based on <https://ironpdf.com/how-to/linux/>***

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

# Make IronCefSubprocess executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory within your app's structure

***Based on <https://ironpdf.com/how-to/linux/>***

```

### Support for Debian 9 and Earlier Versions

Debian 9 and its predecessors have not undergone official testing with IronPdf, and thus do not offer out-of-the-box functionality. While .NET is officially supported on Debian 9 by Microsoft, it can still be made compatible with IronPdf through proper configuration (refer to the section on "Common Dependency Patterns for Linux" further in this document).

Unfortunately, Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 on Debian 9. It is highly advisable to upgrade to Debian 10 for better support and integration capabilities.

For any further queries or if there's a specific Linux distribution you'd like to see supported, please reach out to us at [support@ironsoftware.com](mailto:support@ironsoftware.com).

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 has not undergone official testing with IronPdf and does not offer out-of-the-box support. Nevertheless, Microsoft does officially support .NET for Debian 9, which can be compatible with IronPdf when properly configured. For details on appropriate setup, refer to the "[Common Dependency Patterns for Linux](#anchor-other-linux-distros)" section located at the end of this article.

Additionally, it should be noted that Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 specifically for Debian 9. Transitioning to Debian 10 is strongly advised for optimal support and functionality.

### Compatibility with CentOS

IronPDF offers robust support for CentOS, ensuring seamless integration and performance.

#### CentOS 8 Compatibility

CentOS 8 works perfectly with IronPDF right out of the box, requiring no additional configuration.

- IronPDF can render HTML to PDF using **Chrome** and **WebKit** engines.
- The platform supports all **.NET Core** versions from **3.1 to 8**, with 3.1, 5, 6 (LTS), 7, and 8 being officially supported.
- While these versions are officially supported, other .NET Core runtimes also work well with CentOS 8.
- We conduct detailed smoke tests on CentOS 8 to ensure reliability and quality with every software update.

Regrettably, there are no .NET Core 3.1 or .NET 5.0 Docker images officially available for CentOS 8 from Microsoft.

#### Manual Configuration for CentOS 8

For scenarios where automatic installation isn't feasible or when administrative privileges aren't available, manual setup is necessary. Below are the commands to manually configure IronPDF on CentOS 8:

Disable `LinuxAndDockerDependenciesAutoConfig` if the setup needs to be manual:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Update system packages and install the necessary dependencies:

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
```

Ensure the `IronCefSubprocess`, essential for IronPDF's operation, is executable:

```sh
chmod 755 $(find /bin/runtimes -name IronCefSubprocess)
```

### CentOS 7 and Older Versions

CentOS 7 and earlier versions have not been extensively tested with IronPDF and do not support the software out of the box.

- .NET on CentOS 7 is supported by Microsoft, suggesting potential compatibility with IronPDF if configured properly.
- Please refer to the "<a href="https://ironsoftware.com/common-dependency-patterns-for-linux/">Common Dependency Patterns for Linux</a>" in the documentation below for guidance on setting up unsupported CentOS versions.

Currently, there are no official Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 on CentOS 7.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Iron Software is a dedicated supporter and this commitment extends robustly into its use of CentOS.

### CentOS 8 Compatibility

Out-of-the-box, we ensure seamless compatibility with CentOS 8, requiring **no initial configuration**.

- Provides support for **Chrome** and **WebKit** for HTML to PDF conversions.
- Officially supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- Additionally, we maintain compatibility with a range of other .NET Core runtimes on CentOS.
- Rigorous smoke tests are performed on CentOS 8 to assure quality with every new release.

Unfortunately, CentOS 8 lacks official Microsoft Docker images for both **.NET Core 3.1** and **.NET 5.0**.

**Setting Up CentOS 8 Manually**

For scenarios where manual installation is necessary, or your application cannot operate with _sudo_ privileges:

Disable automatic dependency configuration by setting:

```plaintext
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update the system packages

***Based on <https://ironpdf.com/how-to/linux/>***

dnf -y update

# Install necessary library headers and binaries

***Based on <https://ironpdf.com/how-to/linux/>***

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

# Grant appropriate permissions to the IronCefSubprocess binary

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# (Location typically found in the 'bin/runtimes/linux-x64/' directory)

***Based on <https://ironpdf.com/how-to/linux/>***

```

### Support for CentOS 7 and Earlier Versions

CentOS 7, and its predecessors, have not undergone rigorous testing for compatibility with IronPdf and may not operate seamlessly upon initial setup.

Despite this, Microsoft officially supports .NET on CentOS 7, suggesting potential compatibility with IronPdf, provided that the installation is executed properly. For more guidance on setting up IronPdf on these Linux distributions, refer to ["Common Dependency Patterns for Linux"](https://www.ironpdf.com/#anchor-other-linux-distros) in the subsequent sections of this documentation.

It's important to note that there are currently no official Docker images available from Microsoft for .NET Core 3.1 or .NET 5.0 specifically tailored for CentOS 7.

## Compatibility with Amazon AWS Linux 2

![Amazon AWS](https://img.icons8.com/color/48/000000/amazon-web-services.png)
![Chrome](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari](https://img.icons8.com/color/48/000000/safari--v1.png)
![Test Icon](https://img.icons8.com/fluency/48/000000/test.png)

IronPDF is fully compatible with Amazon AWS Linux 2, which is integral to Amazon's suite of cloud offerings including EC2 and Lambda.

- Although there are no official Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 on Amazon AWS Linux 2, IronPDF has been tailored to ensure functionality on this platform through rigorous manual testing.

For developers looking to set up IronPDF on Amazon AWS Linux 2 without administrative privileges, the setup can be conducted manually:

Ensure you disable the automatic dependency configuration:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then proceed with the installation of necessary libraries:
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
# (IronCefSubprocess is normally found at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/how-to/linux/>***

```

For additional guidance, consider reviewing the [IronPDF AWS Lambda guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), which includes comprehensive information on setting up a Docker file for IronPDF on AWS Lambda.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Below is the paraphrased section regarding Amazon AWS Linux 2 compatibility and setup for IronPDF:

-----

IronPDF is fully compatible with Amazon AWS Linux 2, which underpins various Amazon cloud services, including EC2 and Lambda.

- Currently, there are no Microsoft-provided Docker images for .NET Core versions 3.1 and 5.0 that are tailored specifically for Amazon AWS Linux 2.

- Our development team conducts hands-on testing to ensure the compatibility of IronPDF with Amazon AWS Linux 2 throughout the development process.

We strongly suggest consulting our [IronPDF AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) guide, which includes instructions on incorporating a functioning Docker file for IronPDF within AWS Lambda environments.

**Manual Configuration for Amazon Linux 2**

Should you need to handle the installation manually, or if your application lacks _sudo_ administrative rights, begin by setting the following configuration:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

This setup instruction disables automatic dependency configuration, allowing for manual management of installation requirements.

Here's the paraphrased section with resolved URL paths:

```sh
# Update system packages

***Based on <https://ironpdf.com/how-to/linux/>***

yum -y update

# Install necessary libraries for font and graphic handling

***Based on <https://ironpdf.com/how-to/linux/>***

yum -y install pango.x86_64
yum -y install libXcomposite.x86_64
yum -y install libXcursor.x86_64
yum -y install libXdamage.x86_64
yum -y install libXext.x86_64
yum -y install libXi.x86_64
yum -y install libXtst.x86_64
yum -y install cups-libs.x86_64
yum -y install libXScrnSaver.x86_64
yum -y install libXrandr.x86_64
yum -y install GConf2.x86_64
yum -y install alsa-lib.x86_64
yum -y install atk.x86_64
yum -y install gtk3.x86_64

# Install various X11 fonts for better rendering

***Based on <https://ironpdf.com/how-to/linux/>***

yum -y install ipa-gothic-fonts
yum -y install xorg-x11-fonts-100dpi
yum -y install xorg-x11-fonts-75dpi
yum -y install xorg-x11-utils
yum -y install xorg-x11-fonts-cyrillic
yum -y install xorg-x11-fonts-Type1
yum -y install xorg-x11-fonts-misc

# Install additional development libraries

***Based on <https://ironpdf.com/how-to/linux/>***

yum -y install glibc-devel.x86_64
yum -y install at-spi2-atk.x86_64
yum -y install mesa-libgbm.x86_64
yum -y install libxkbcommon

# Ensure the IronPDF subprocess has the necessary permissions

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Path to IronCefSubprocess might vary, commonly found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

For further insights and step-by-step guidance on utilizing IronPdf within AWS Lambda environments, consult our dedicated documentation on [IronPdf for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), where you'll find detailed instructions on setup and logging for deployment on the Amazon cloud platform.

----
## Compatibility with Fedora Linux

IronPDF offers full compatibility with Fedora Linux.

Out-of-the-box support for Fedora Linux 33 requires no additional configuration.

- Capable of utilizing both **Chrome** and **WebKit** for HTML to PDF conversions.
- Full support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Exhaustive smoke tests are performed on this environment with each new release.

### Manual Setup on Fedora Linux

For installations that cannot run with _sudo_ administrative rights or for custom setups on different versions of Fedora Linux, manual configuration may be necessary.

To disable automatic dependency management:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

This configuration helps facilitate manual setups on Fedora, regardless if the system is on an older or updated build.

```sh
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

# Set the IronCefSubprocess executable permission

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Typically located in bin/runtimes/linux-x64 directory of your application

***Based on <https://ironpdf.com/how-to/linux/>***

```

## Compatibility with Alpine Linux

Unfortunately, IronPDF does not support Alpine Linux at this time. We appreciate Alpine and look forward to its progression, but its reliance on outdated "musl" C libraries prevents full compatibility with the Chromium technology necessary for IronPDF's functionality as of 2023.

### Integrating IronPdfEngine with Alpine in .NET 6 Using Docker

IronPdf offers a comprehensive Docker container image with complete IronPdf capabilities. This facilitates the incorporation of IronPdf features into projects on Alpine Linux through the IronPdfEngine container.

#### Step 1: Acquire and Deploy the IronPdf Engine Docker Image

Run these commands in your terminal to download and initiate the IronPdf Engine Docker image:
```shell
docker pull ironsoftwareofficial/ironpdfengine
docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

```shell
# Retrieve the IronPDF Engine Docker image from Iron Software's official repository

***Based on <https://ironpdf.com/how-to/linux/>***

docker pull ironsoftwareofficial/ironpdfengine
```

Here's the paraphrased section with the code instruction suitably rewritten:

```shell
docker run --detach -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

This command ensures that the IronPDF Engine Docker image runs in detached mode, binding port 33350 on the host to port 33350 in the Docker container.

## Step 2: Configuring Your Console Application

Begin by establishing a new console application that targets .NET 6.

Proceed to install the IronPdf.Slim NuGet package via the NuGet Package Manager to incorporate it into your project.
```

## Additional Linux Distributions

For other Linux distributions not directly supported, you can manually configure your environment to use IronPDF by installing key dependencies through package managers like **apt-get**, **hfs**, and **yum**. This flexibility allows IronPDF to function across a wider range of Linux distributions that are not officially supported.

During your initial setup, IronPDF might indicate missing system dependencies through exceptions, guiding you through the necessary adjustments.

The critical binary `IronCefSubprocess`, located in your application's `bin` folder, particularly under the `runtimes` subdirectory, should be correctly identified and made executable. Administrative rights (`sudo` privileges) may be required for this setup.

Should you encounter uncertainty on how to handle dependencies on unsupported Linux versions, it's beneficial to examine the dependency requirements for the Chromium browser on those systems.

For advocating the addition of official support for other Linux distributions, please forward your suggestions or requests to [support@ironsoftware.com](mailto:support@ironsoftware.com).

### Recognizing Common Dependency Patterns

It's advisable to familiarize yourself with the installation packages listed for other Linux operating systems earlier in this document, as these encapsulate common dependency trends essential for running IronPDF effectively.

```sh
sudo apt update
sudo apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1

# Ensure the IronCefSubprocess is executable

***Based on <https://ironpdf.com/how-to/linux/>***

sudo chmod 755 $(find /path/to/your/application/bin -name IronCefSubprocess)
```

```sh
# Update package lists to ensure versions are current

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install necessary libraries and dependencies for IronPDF

***Based on <https://ironpdf.com/how-to/linux/>***

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

# Ensure that the IronCefSubprocess binary has the proper permissions to execute

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# This binary is typically located in the bin/runtimes/linux-x64 directory of your application.

***Based on <https://ironpdf.com/how-to/linux/>***

```

## IronCefSubprocess Section

`IronCefSubprocess` is essentially a binary executable located in your application’s `bin` directory. It must have executable permissions to function correctly within a .NET environment.

Example: (Please note the path could differ depending on the setup) 

```sh
chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

Here's the paraphrased section, with the relative URL paths resolved against ironpdf.com, as requested:

```sh
# Granting executable permissions to the IronCefSubprocess binary in the Linux runtime environment.

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

Here's the revised version of the specified section:

---
## Publishing a Single-File Application in Linux with Dotnet

To distribute your project as a single-file application on Linux platforms, follow these instructions:

```sh
dotnet publish -r linux-x64 --property:PublishProfile=FolderProfile /bl
```

This command compiles your application into a single executable for easier deployment on Linux environments.

Below is the paraphrased content of the specified section with the updated URL resolved to ironsoftware.com:

-----

To publish your .NET project in a single-file distribution for Linux x64, execute the following command in your terminal:

```sh
dotnet publish -r linux-x64 --property:PublishProfile=FolderProfile /bl
```

This command compiles your application and its dependencies into a single executable file, optimizing it for deployment on Linux x64 systems.

## Temp File Locations

In some scenarios, programmers need to designate a directory that permits the creation of temporary files.

A widely accepted and secure location for this purpose is `/tmp/` on Linux systems. It's essential to ensure that this directory allows both reading and writing operations.

Here's the paraphrased section of the article:

```cs
// Configure the temporary path for IronPDF operations
string temporaryPath = @"/tmp/";

// Set the log file path for IronPDF
IronPdf.Logging.Logger.LogFilePath = temporaryPath;

// Define environment variables for TEMP and TMP to the temporary path
Environment.SetEnvironmentVariable("TEMP", temporaryPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", temporaryPath, EnvironmentVariableTarget.Process);

// Assign the temporary folder path and custom deployment directory for IronPDF
IronPdf.Installation.TempFolderPath = temporaryPath;
IronPdf.Installation.CustomDeploymentDirectory = temporaryPath;
```

