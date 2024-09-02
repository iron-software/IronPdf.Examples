# IronPDF Linux Compatibility & Setup Guide

IronPDF provides comprehensive support for Linux environments across various .NET versions including **.NET 8, 7, 6, 5**, and **.NET Core**. It's also fully compatible with Docker, Azure, AWS, macOS, and of course, Windows.

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

We advocate for the utilization of .NET Core 3.1 and any other runtimes that are designated as [LTS](https://dotnet.microsoft.com/platform/support/policy) (Long Term Support) by Microsoft, as they offer extended support and have undergone thorough testing on Linux platforms.

Running IronPDF on Linux doesn't necessitate any modifications to your code. IronPDF is designed to operate seamlessly right from the installation, which is a testament to the extensive testing and setup performed by our development team.

The support for Linux is crucial as numerous cloud services—including Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker—primarily utilize Linux. At Iron Software, we frequently employ these tools in our operations, ensuring we are well acquainted with the needs of our Enterprise and SAAS clients who rely on these environments.

## Hardware Requirements

IronPDF leverages the Chromium engine for converting HTML to PDF, providing output fidelity comparable to the print functionality of Google Chrome. The hardware requirements are focused on adequately supporting the Chromium engine due to its intensive computing demands.

- **Minimum Configuration**: 1 CPU Core & 1.75 GB of RAM
- **Recommended Configuration**: 2 CPU Cores & 8 GB of RAM or more

### Recommended Linux Distributions for IronPDF

IronPDF seamlessly integrates with the following **64-bit Linux operating systems**, ensuring a "zero configuration" setup:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11 _[Current default Linux distribution for Microsoft Azure]_
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2. For detailed installation instructions, view the [IronPDF AWS Lambda Setup Guide](https://ironsoftware.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

For other Linux distributions not listed here, refer to the "Other Linux Distros" section in this guide for installation tips.

We also endorse using [Microsoft’s Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) for a streamlined experience. Please note that while these other distributions are partially supported, they might require manual configurations via apt-get. For common dependency setups, consult the ["Common Dependency Patterns for Linux"](https://ironsoftware.com#anchor-other-linux-distros) section at the end of this document.

## Automatic Linux Configuration

By enabling the `LinuxAndDockerDependenciesAutoConfig` setting to `true`, IronPDF will automatically handle the installation of all necessary dependencies for operating on Linux platforms. Be aware that the initial HTML to PDF conversion might require additional time to complete.

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

This line of code automatically configures IronPDF to install necessary dependencies for Linux environments, ensuring a seamless setup for Docker compatibility.

Here's the paraphrased section on Linux optimized NuGet packages, with links resolved to `ironsoftware.com`:

---
## Tailored NuGet Packages for Linux

IronPDF offers specifically optimized NuGet packages for deploying on Linux environments. Complete instructions can be found in our [detailed guide on advanced NuGet installations for IronPDF](https://ironsoftware.com/how-to/advanced-installation-nuget/).

Utilizing these optimized packages will enable seamless development across different operating systems, including Windows and macOS.

For those who prefer direct downloads, the Linux-specific DLL can be accessed here: [Download IronPDF Linux DLL](https://ironsoftware.com/packages/IronPdf.Linux.zip).

---

```shell
:InstallCmd Install-Package IronPdf.Linux
```

For Linux systems, optimized NuGet packages for IronPDF are detailed in our [IronPDF advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These packages facilitate not only Linux development but also enable you to develop on Windows or macOS platforms.

Alternatively, the Linux-specific DLL can be directly [downloaded here](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Docker and Linux Configuration

For guidance on configuring Docker to utilize IronPDF, consult our [detailed guide](https://ironpdf.com/how-to/docker-linux/). This documentation covers all necessary steps for integrating IronPDF within a Docker environment.

## Compatibility with Ubuntu

Ubuntu ranks as the most rigorously tested Linux distribution within our scope. The reason for this extensive testing is due to its significant use in the Azure frameworks, which supports our continuous integration and delivery processes. Additionally, this system is fully backed by official .NET support from Microsoft and provides access to official Docker images.

### Ubuntu 20 Compatibility

Ubuntu 20 is fully supported by IronPDF, requiring no additional setup for immediate use.

![Microsoft Icon](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Chrome Icon](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Icon](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Icon](https://img.icons8.com/color/48/000000/docker.png)
![Azure Icon](https://img.icons8.com/fluency/48/000000/azure-1.png)

This distribution supports both Chrome and WebKit for HTML to PDF conversions, providing a reliable PDF rendering experience.

This version of Ubuntu seamlessly supports various .NET Core runtimes including **.NET Core 3.1, 5, 6 (LTS), 7, and 8**. Although primarily geared for these specific long-term support versions, unofficial support extends to a broader range of .NET Core runtimes.

To ensure reliable operation, we conduct over 997 unit tests on this platform with each software release, demonstrating our commitment to quality and stability.

**Official Docker Images for Ubuntu 20:**

- [Ubuntu 20.04 64-bit Docker Image for .NET Runtime 3.1 (3.1-focal)](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Ubuntu 20.04 64-bit Docker Image for .NET Runtime 5.0 (5.0-focal)](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting Up Ubuntu 20 Manually**

If your application requirements do not permit automatic configurations or require non-administrative installation, you can set up IronPDF manually by adjusting the configuration and manually installing necessary dependencies. 

Disable automatic dependency management:

```csharp
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
apt install -y libxshmfence1
apt install -y libgdiplus
apt install -y libva-dev
```

Ensure that the `IronCefSubprocess` binary is executable, which can typically be found in the `bin/runtimes/linux-x64/` directory of your project:

```sh
chmod 755 IronCefSubprocess
```

By following these guidelines, you can manually configure Ubuntu 20 to effectively run IronPDF applications.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 20 is fully compatible with **IronPDF** and operates perfectly right out of the box, requiring _zero configuration_ to get started.

- The software is designed to support both **Chrome** and **WebKit** for HTML to PDF conversions.
- Officially, it supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- It also offers support for a range of other .NET Core runtimes on Ubuntu 20, although these are not officially included.
- To ensure reliability and consistency, we conduct over 997 unit tests on this platform with each new release.

### Official Microsoft Docker Images for Ubuntu 20:

- For **.NET Runtime 3.1**, use the [64-bit Ubuntu 20.04 Docker image labeled '3.1-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/).
- For **.NET Runtime 5.0**, use the [64-bit Ubuntu 20.04 Docker image labeled '5.0-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/).

### Manual Setup for Ubuntu 20:

If your application setup does not permit automatic installations or if you lack administrator ('sudo') privileges, you can opt for a manual setup.

Just set the following property in your application to disable automatic dependency resolution:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

This manual configuration allows for more controlled environment setup and dependency management.

```sh
# Update package lists
apt update

# Install essential and system libraries
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1 libgdiplus libva-dev

# Set the execution permissions for IronCefSubprocess binary
chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory of your project structure.
```

The **IronCefSubprocess** binary mentioned is located in your application's `bin` directory, and the specific path might often be found under the `runtimes` sub-folder.

Administrative rights (`sudo` privileges) might be required for certain operations involving this file.

### Ubuntu 18 Compatibility

Ubuntu 18 is fully supported by IronPDF without the need for any configuration adjustments.

- HTML to PDF conversion is enabled through **Chrome** and **WebKit**-based rendering engines.
- Full support for **.NET Core 3.1 LTS** and **.NET 5 runtimes** is available.
- Support for additional .NET Core runtimes on Ubuntu 18, as well as Ubuntu 16, is provided though not officially verified.
- Each software release is preceded by thorough testing, including comprehensive smoke tests on this platform.

**Official Microsoft Docker Images for Ubuntu 18:**

- [64-bit Ubuntu 18.04 Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- High compatibility with .NET 5 on Ubuntu 18, despite the absence of an official Docker image.

**Manual Setup Procedure for Ubuntu 18**

If manual installation is necessary, or if administrative privileges are not available, you can adjust the setup as follows:

Disable automatic dependency configuration:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Proceed with system updates and necessary installations:

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
# (IronCefSubprocess is usually located in bin/runtimes/linux-x64/)
```

These steps ensure that all necessary libraries are installed and that the `IronCefSubprocess` binary has the proper permissions to execute.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully supported by IronPDF and requires no configuration to get started.

- Chrome and WebKit are utilized for HTML to PDF conversion.
- Officially, support is offered for .NET Core 3.1 LTS and .NET 5 runtimes.
- While not officially supported, many other .NET Core runtimes are also compatible with Ubuntu 18, including Ubuntu 16.
- Before every product release, we conduct extensive smoke tests on Ubuntu 18.

### Official Microsoft Docker Images

- [Ubuntu 18.04 Docker Image for .NET Runtime 3.1 (labeled '3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/).
- No official Docker image exists for Ubuntu 18 .NET 5; however, the compatibility remains exceptionally high.

### Manual Installation on Ubuntu 18

For systems without administrative privileges or those that require a manual setup, follow these guidelines.

Disable automatic dependency configuration:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here's the paraphrased section:

```sh
# Update package lists
apt update
# Install necessary libraries
apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Ensure IronCefSubprocess is executable
chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory
```

### Ubuntu 16 Compatibility

Ubuntu 16 is provided with limited and unofficial support by IronPDF. While not extensively tested, Ubuntu 16 offers a suitable environment due to its compatibility with IronPdf, as confirmed by user reports.

- **Chrome** and **WebKit**: This platform should generally support these browsers with some manual configurations.
- **Supported .NET Versions**: Official support from Microsoft encompasses **.NET Core 3.1 LTS** and **.NET 5 runtimes**, ensuring a reliable foundation for IronPDF functionalities.
- **Docker Images**: Currently, there are no established Microsoft Docker images available for Ubuntu 16, indicating a need for alternative solutions or updates.

#### Configuring IronPDF on Ubuntu 16 Manually

For scenarios where automated installation isn’t possible or if administrative rights are restricted, setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false` is recommended.

```sh
sudo apt update
sudo apt install -y libc6-dev
sudo apt install -y libgtk2.0-0
sudo apt install -y libnss3
sudo apt install -y libatk-bridge2.0-0
sudo apt install -y libx11-xcb1
sudo apt install -y libxcb-dri3-0
sudo apt install -y libdrm-common
sudo apt install -y libgbm1
sudo apt install -y libasound2
sudo apt install -y libappindicator3-1
sudo apt install -y libxrender1
sudo apt install -y libfontconfig1
sudo apt install -y libxshmfence-dev

chmod 755 /path/to/your/application/bin/runtimes/linux-x64/IronCefSubprocess
```
In this setup, it's crucial to ensure the `IronCefSubprocess` binary has the correct permissions to execute effectively. Depending on your specific application directory, you might have to modify the path to where `IronCefSubprocess` is located.

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Support for Ubuntu 16 within IronPDF is somewhat limited and unofficial, as comprehensive testing for this OS version has not been conducted.

Microsoft officially supports .NET on Ubuntu 16, and based on reports from numerous developers, it functions compatibly with IronPDF. However, manual installation of necessary dependencies using `apt-get` may be required for full functionality.

- **Chrome** and **WebKit** are known to operate properly with some manual configurations.
- Microsoft offers support for both **.NET Core 3.1 LTS** and **.NET 5 runtimes** on Ubuntu 16, although not through Docker, as no official Microsoft Docker images exist for Ubuntu 16.

For developers needing to proceed with a manual setup of IronPDF on Ubuntu 16, especially in circumstances where sudo administrative privileges are unavailable, the configuration should begin by explicitly disabling the automatic dependency resolution:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update available packages and their versions
apt update

# Install necessary libraries for IronPDF
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

# Set IronCefSubprocess to executable
chmod 755 IronCefSubprocess
# IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory
```

## Compatibility with Debian

Debian ranks as our second-most frequently tested Linux OS. This system enjoys both Microsoft .NET official support and recognized Docker images.

### Debian 11 Compatibility

Debian 11 is a preferred distribution for Microsoft when integrating Docker support with .NET projects in Visual Studio, and we fully support it at Iron Software.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 11 is fully supported by IronPDF, requiring no special configurations to get started.

- Facilitates **Chrome** and **WebKit** for flawless HTML to PDF transformations.
- Fully compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Also supports additional .NET Core runtimes that are not officially documented.
- Over 997 unit tests are performed on Debian 11 to ensure robust functionality with each software release.

**Official Microsoft Docker Images for Debian 11:**

- [64-bit Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup for Debian 11:**
For scenarios where you may not have admin rights or prefer manual installation:

Disable automatic dependency downloading by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;`.

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
apt install -y libxkbcommon-x11-0
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1

chmod 755 IronCefSubprocess
# (IronCefSubprocess is usually located at bin/runtimes/linux-x64/)
```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

# IronPDF's Seamless Integration with Debian 11

Debian 11 serves as the go-to choice for Microsoft when incorporating Docker functionality into .NET projects within Visual Studio, highlighting its robust compatibility.

IronPDF delivers immediate, effortless integration with Debian 11, requiring _no initial configuration_.

### Features and Support
- Implements **Chrome** and **WebKit** for HTML to PDF conversions.
- Fully supports **.NET Core** versions **3.1, 5, 6 (LTS), 7, and 8**.
- Provides informal support for additional .NET Core versions on Debian 11.
- Conducts extensive testing, executing over 997 unit tests on this platform with each software release.

### Official Images from Microsoft:

- [64-bit Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Setup for Debian 11

For those requiring manual installation, or when administrative privileges are unavailable, begin by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false;`.

This manual approach ensures that IronPDF runs successfully on Debian 11 by allowing customized installations suited to your specific system requirements.

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
apt install -y libxkbcommon-x11-0  # Additional package for keyboard compatibility
apt install -y libxrender1
apt install -y libfontconfig1
apt install -y libxshmfence1

# Change IronCefSubprocess permissions to be executable
chmod 755 IronCefSubprocess
# Typically found in the bin/runtimes/linux-x64 directory within your application
```

### Debian 10 Compatibility

![Debian Logo](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

Debian 10 is fully compatible and supported right from the start without requiring any configuration adjustments.

- Enables HTML to PDF conversions using both Chrome and WebKit rendering engines.
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Provides support for additional .NET Core runtimes beyond the officially listed ones.
- Rigorous unit testing, with over 997 tests, ensures reliability for each software release.

**Official Microsoft Docker Images:**

- [.NET Runtime 3.1 on 64-bit Debian 10 Docker image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 on 64-bit Debian 10 Docker image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting Up Debian 10 Manually**

For installations requiring manual configuration or where administrative rights aren't available, disable automatic dependency management:

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1

chmod 755 IronCefSubprocess
# (Location generally at bin/runtimes/linux-x64/)
``` 

This setup ensures IronPDF operates effectively in environments where you manage dependencies directly.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 10 is seamlessly supported by Iron Software without any configuration needed.

- Implements HTML to PDF conversion using **Chrome** and **WebKit** engines.
- Provides out-of-the-box support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Extends support to additional .NET Core versions on Debian 10, even though this support is not official.
- Prior to each release, executes more than 997 unit tests to ensure reliability on this platform.

**Accredited Microsoft Docker Images:**

- [64-bit Debian 10 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 10 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Guidance for Manual Installation on Debian 10**

For installations without _sudo_ privileges or for manual setup:

Disable automatic dependency management by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;`.

```sh
# Update package lists
apt update

# Install necessary libraries
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

# Make the IronCefSubprocess executable
chmod 755 IronCefSubprocess
# IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory
```

### Compatibility with Debian 9 and Earlier Versions

Debian 9 and its predecessors are not officially tested and do not come pre-configured to work with IronPdf. Nonetheless, .NET is fully supported on Debian 9 by Microsoft, and it's possible to get IronPdf functioning correctly with the proper setup. This requires adherence to certain setup procedures detailed in the "Common Dependency Patterns for Linux" found later in this guide.

No official Docker images from Microsoft are available for Debian 9 for either .NET Core 3.1 or .NET 5.0. Upgrading to Debian 10 is strongly recommended for better compatibility and support.

Refer to [<a href="https://ironsoftware.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/">IronPdf for AWS Lambda</a>](https://ironsoftware.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) guide for deeper insights and practical setup help on Debian platforms.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 hasn't undergone formal testing with IronPdf and isn't supported out of the box. Nonetheless, since Microsoft officially backs .NET on Debian 9, it can be configured to operate successfully with IronPdf if appropriately set up. For guidance on installation, refer to the "[Common Dependency Patterns for Linux](#anchor-other-linux-distros)" section later in this guide.

There is also an absence of official Microsoft Docker images for .NET Core 3.1 and .NET 5.0 available for Debian 9. It is advisable to upgrade to Debian 10 for better compatibility and support.

## Compatibility with CentOS

IronPDF actively supports and endorses CentOS.

### CentOS 8 Support

IronPDF is fully compatible with CentOS 8 right out of the box, necessitating no configuration.

- Supports HTML to PDF rendering with **Chrome** and **WebKit** engines.
- Officially compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- While officially supported for the listed .NET Core versions, it also works with several other versions under CentOS.
- Extensive testing is done on this platform before any release, ensuring reliability.

Unfortunately, there are no Docker images available from Microsoft that officially support .NET Core 3.1 or .NET 5.0 on CentOS 8.

**Setting Up CentOS 8 Manually**

If automated installations are not possible or your application cannot run with administrative privileges, follow the manual setup:

Ensure that the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` setting is set to `false`.

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
# (IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory)
```

### CentOS 7 and Earlier

CentOS 7 and versions below have not undergone specific testing and are not guaranteed to work seamlessly with IronPDF.

However, Microsoft officially supports .NET on CentOS 7, and users have had success running IronPDF with appropriate setups. Check the "**Common Dependency Patterns for Linux**" section for guidance on required dependencies.

There are no available official Docker images from Microsoft for .NET Core 3.1 or .NET 5.0 on CentOS 7.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

---
Iron Software actively endorses and supports CentOS as a reliable operating system for deploying .NET applications using IronPDF. This platform receives rigorous testing to ensure optimal performance and compatibility.

### CentOS 8 Compatibility

CentOS 8 is fully compatible with IronPDF and does not require any initial configuration for use.

- We provide support for both Chrome and WebKit HTML to PDF rendering engines.
- Officially, we back **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- Additional .NET Core runtimes on CentOS are supported though not officially.
- Extensive smoke tests are conducted on this platform prior to every software release.

Regrettably, Microsoft does not offer official Docker images for **.NET Core 3.1 or 5.0** specific to CentOS 8.

**Manual Installation Process for CentOS 8**

For scenarios where an application is unable to run with administrative (sudo) privileges, manual installation is required.

To switch off the automatic dependencies configuration, apply the following setting in your application:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update your Fedora Linux system packages
dnf -y update

# Install necessary libraries for running IronPdf
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

# Make sure the IronCefSubprocess binary is executable
chmod 755 IronCefSubprocess
# You typically find IronCefSubprocess in bin/runtimes/linux-x64/ directory of your project
```

### Compatibility with CentOS 7 and Earlier Versions

CentOS 7 and previous versions have not undergone testing for compatibility with IronPdf and are not supported out of the box.

Despite this, since Microsoft officially supports .NET on CentOS 7, it is probable that with proper setup, IronPdf can be configured to function effectively. For guidance on required configurations, consult the ["Common Dependency Patterns for Linux"](https://ironpdf.com#anchor-other-linux-distros) section below.

It should be noted that no official Docker images exist from Microsoft for .NET Core 3.1 or .NET 5.0 tailored to CentOS 7.

## Compatibility with Amazon AWS Linux 2

IronPDF is fully operational on Amazon AWS Linux 2, which underlies many of Amazon's critical cloud services such as EC2 and Lambda.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Despite the absence of Microsoft's official Docker images for .NET Core 3.1 or .NET 5.0 on this platform, our compatibility tests have been thoroughly conducted manually.

For tailored guidance on setting up IronPDF with AWS services, especially using AWS Lambda, please refer to our comprehensive [IronPDF AWS Lambda Guide](https://ironsoftware.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) which includes both installation instructions and a ready-to-use Docker file.

**Manual Setup for Amazon Linux 2**

Should you need to install IronPDF manually, or if your application operates under strict permissions that restrict `sudo` access, adjust `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`:

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
# (IronCefSubprocess is typically located in bin/runtimes/linux-x64/)
```

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

IronPDF is fully compatible with Amazon AWS Linux 2, providing the backbone for Amazon cloud solutions like EC2 and Lambda.

- Currently, Microsoft does not offer official Docker images for .NET Core 3.1 or .NET 5.0 specifically for Amazon AWS Linux 2.
- Throughout the development of IronPDF, we conduct hands-on compatibility tests with Amazon AWS Linux 2.

For an in-depth look at setting up IronPDF with AWS Lambda, including a functional Docker configuration, please consult our [IronPDF AWS Lambda Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

**Manual Configuration for Amazon Linux 2**

If your application setup does not allow for automatic installations or runs without _sudo_ privileges, you can manually configure your environment. Begin by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false` to handle the dependencies manually.

```sh
# Update system packages
yum update -y

# Install necessary libraries and dependencies for IronPDF
yum install -y pango.x86_64            # installs Pango library
yum install -y libXcomposite.x86_64    # for X Composite extension
yum install -y libXcursor.x86_64       # X cursor management library
yum install -y libXdamage.x86_64       # X Damage extension library
yum install -y libXext.x86_64          # various extensions to X
yum install -y libXi.x86_64            # X Input extension library
yum install -y libXtst.x86_64          # X Testing extension library
yum install -y cups-libs.x86_64        # CUPS libraries
yum install -y libXScrnSaver.x86_64    # X Screen Saver extension library
yum install -y libXrandr.x86_64        # X Resize, Rotate and Reflect extension
yum install -y GConf2.x86_64           # GNOME configuration database system
yum install -y alsa-lib.x86_64         # ALSA library for audio support
yum install -y atk.x86_64              # Accessibility Tookit
yum install -y gtk3.x86_64             # GTK+ graphical interface library
yum install -y ipa-gothic-fonts        # Japanese Gothic-type fonts
yum install -y xorg-x11-fonts-100dpi   # X11 fonts 100 dpi
yum install -y xorg-x11-fonts-75dpi    # X11 fonts 75 dpi
yum install -y xorg-x11-utils          # X11 utilities
yum install -y xorg-x11-fonts-cyrillic # X11 Cyrillic fonts
yum install -y xorg-x11-fonts-Type1    # X11 Type1 fonts
yum install -y xorg-x11-fonts-misc     # miscellaneous X11 fonts
yum install -y glibc-devel.x86_64      # GNU C Library development libraries and headers
yum install -y at-spi2-atk.x86_64      # Assistive Technology Service Provider Interface
yum install -y mesa-libgbm.x86_64      # Generic Buffer Manager
yum install -y libxkbcommon            # library to handle keyboard descriptions

# Ensure IronCefSubprocess is executable
chmod 755 IronCefSubprocess
# (IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory)
```

For a comprehensive guide on setting up and using IronPdf with AWS Lambda, including detailed steps on installation and configuration for optimal performance on the Amazon cloud platform, please refer to our dedicated [IronPdf for AWS Lambda documentation](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

**Fedora Linux Compatibility with IronPDF**

Fedora Linux is fully compatible and supported by IronPDF.

IronPDF seamlessly integrates with Fedora Linux 33 without requiring any additional configurations.

- It enables HTML to PDF conversions using **Chrome** and **WebKit** rendering engines.
- It fully supports multiple versions of **.NET Core**, specifically **3.1, 5, 6 (LTS), 7, and 8**.
- Extensive smoke testing is performed on Fedora Linux to ensure reliability and performance with every new release.

**Guidelines for Manual Setup on Fedora Linux**

For instances where automatic setup might not be possible, such as environments without _sudo_ privileges or when dealing with different versions of Fedora Linux, manual installation steps can be followed.

To disable automatic dependency management, adjust the IronPDF settings as follows:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

This manual approach is especially beneficial when adapting IronPDF for older or newer Fedora builds, providing more control over the installation environment.

```sh
# Update and install required libraries using the DNF package manager
dnf -y update
dnf -y install glibc-devel nss at-spi2-atk libXcomposite libXrandr mesa-libgbm alsa-lib pango cups-libs libXdamage libxshmfence

# Make the IronCefSubprocess executable 
chmod 755 IronCefSubprocess
# Note: IronCefSubprocess typically resides in the bin/runtimes/linux-x64/ directory of your application
```

## Compatibility with Alpine Linux

Currently, IronPDF does not support Alpine Linux. Although we appreciate Alpine and recognize its potential for growth, the use of outdated "musl" C libraries in Alpine as of 2023 prevents the Chromium developers from offering full support on this operating system.

### Integrating IronPdfEngine with Alpine Docker Using .NET 6

IronPdf offers a Docker container that houses all the capabilities of IronPdf, allowing Alpine-based projects to leverage these functionalities by linking to the IronPdfEngine container.

#### Step 1: Acquiring and Launching IronPdf Engine Docker Image

Use these commands in your terminal to download and initiate the IronPdf Engine Docker container:

```shell
docker pull ironsoftwareofficial/ironpdfengine
```

```shell
docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

```shell
# Retrieve the IronPDF Engine Docker image from Iron Software's official repository
docker pull ironsoftwareofficial/ironpdfengine
```

```shell
# Run the IronPdf Engine Docker image on port 33350 in detached mode
docker run -d --publish 33350:33350 ironsoftwareofficial/ironpdfengine
```

Here is the paraphrased section with URL paths resolved:

-----

### Step 2: Configure Your Console Application

Begin by creating a new console application specifically for .NET 6.

Next, add the IronPdf.Slim library to your project by utilizing the NuGet Package Manager to install this package.

## Configuring IronPDF for Various Linux Distributions

For Linux distributions that are not directly supported by IronPDF, manual installation of prerequisites can be performed using package managers like **apt-get**, **hfs**, and **yum**. This flexibility enables IronPDF integration across a broader range of Linux environments.

Initially, installing IronPDF might lead to exceptions. These serve as notifications for any additional system dependencies required for proper operation.

Particularly, you will encounter **IronCefSubprocess**, which is a crucial binary located in the `bin` folder (often under the `runtimes` subfolder) of your application. You might sometimes need to provide a specific path to access it. Administrative privileges or `sudo` may be required to execute some commands.

For unsupported Linux systems, investigate the dependencies related to the **Chromium** browser as a guideline for setting up your environment.

Should there be interest in advocating for official IronPDF support on additional Linux distributions, please forward your suggestion via email to [support@ironsoftware.com](mailto:support@ironsoftware.com).

**Common Dependency Patterns for Linux**: It's beneficial to familiarize yourself with the dependency packages noted in the above sections for various supported Linux systems. This knowledge can guide the manual setup process for other distributions.

Here's the paraphrased section:

```sh
# Update the package lists
apt update

# Install required libraries for IronPDF functionality
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

# Modify permissions to make IronCefSubprocess executable
chmod 755 IronCefSubprocess
# (IronCefSubprocess is generally located at bin/runtimes/linux-x64/)
```

## IronCefSubprocess

**IronCefSubprocess** is located in the `bin` directory of your application as a binary file. It must be executable by the .NET framework in order to function properly.

For instance, the location of the file might differ depending on the setup.

```sh
# Set the execute permission for the IronCefSubprocess binary
chmod 755 bin/runtimes/linux-x64/IronCefSubprocess
```

### Publishing a Single-File .NET Application on Linux

Should you decide to deploy your .NET project as a single-file application on Linux systems, the process is straightforward. To accomplish this, use the following command:

```sh
dotnet publish -r linux-x64 /property:PublishProfile=FolderProfile /bl
``` 

This command efficiently bundles all the necessary project components into one single executable for Linux, making deployment and distribution simpler.

Below is the paraphrased section of the article you provided:

```sh
# Publishing a .NET Application for Linux from the Command Line

To deploy your .NET application as a single self-contained file for Linux x64 systems, you would execute the following command in your terminal:

```sh
dotnet publish -r linux-x64 --property:PublishProfile=FolderProfile /bl
```

This command instructs the .NET CLI to publish the application specifically for Linux x64 architecture, utilizing the settings defined in the `FolderProfile` publishing profile and enabling binary logging with the `/bl` switch for detailed diagnostics.
```

## Configuration of Temporary File Paths

For certain operations, it's essential for developers to designate a directory where temporary files can be managed. A frequently recommended and safe location for this purpose is `/tmp/` on Linux systems. It is crucial, however, that the chosen directory permits file read and write access.

Here's the paraphrased section of the article:

```cs
// Configure the temporary directory for IronPDF
string tempDirectory = @"/tmp/";

// Set the directory for IronPDF logs
IronPdf.Logging.Logger.LogFilePath = tempDirectory;

// Assign the 'TEMP' and 'TMP' environment variables for the process
Environment.SetEnvironmentVariable("TEMP", tempDirectory, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", tempDirectory, EnvironmentVariableTarget.Process);

// Define the temporary folder and custom deployment directory for IronPDF
IronPdf.Installation.TempFolderPath = tempDirectory;
IronPdf.Installation.CustomDeploymentDirectory = tempDirectory;
```

