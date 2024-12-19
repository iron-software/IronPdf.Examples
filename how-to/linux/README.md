# IronPDF Linux Compatibility & Setup Guide

***Based on <https://ironpdf.com/how-to/linux/>***


IronPDF is compatible with Linux for **.NET 8, 7, 6, 5**, and **.NET Core** platforms. It also supports various environments including Docker, Azure, AWS, macOS, and Windows.

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" style="display:inline" />

We advise opting for .NET Core 3.1 and other runtimes identified as [LTS (Long Term Support) by Microsoft](https://dotnet.microsoft.com/platform/support/policy) as they offer extended support periods, ensuring they are robustly tested on Linux platforms.

IronPDF is designed to be immediately operational on Linux systems without the need for any modifications in your codebase. This seamless functionality is a result of extensive engineering, involving numerous hours dedicated to testing and configuration.

The integration of Linux is crucial due to its extensive use in cloud services like Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Azure DevOps Docker. We at Iron Software not only utilize these platforms extensively but also recognize their significance to our Enterprise and SAAS clientele.

## Hardware Requirements

IronPDF leverages the Chromium rendering engine to convert HTML into PDFs, achieving the same quality as Chrome's printing capabilities. The hardware requirements are mainly derived based on the needs of the Chromium engine, which is the most resource-intensive component.

- **Minimum**:
  - 1 CPU Core
  - 1.75 GB RAM

- **Recommended**:
  - 2 CPU Cores
  - 8 GB RAM or more

### Supported Linux Distributions for IronPDF

IronPDF offers full support and recommends the most recent **64-bit** Linux operating systems listed below for effortless, "zero configuration" installation.

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11 _[Default Linux Distribution on Microsoft Azure]_
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2. For detailed setup instructions, [read the IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

For guidance on installing IronPDF in Linux distros that are **not officially supported,** please see the "Other Linux Distros" section below.

We highly recommend utilizing [Microsoft's Official Docker Images](https://hub.docker.com/_/microsoft-dotnet-runtime/) for Docker support. While other distributions are somewhat supported, they might require manual adjustments using apt-get. For directions on these adjustments, please refer to the [Common Dependency Patterns for Linux](#anchor-other-linux-distros) found at the end of this guide.

## Setting Up Linux Automatically

When enabled, the default configuration parameter `LinuxAndDockerDependenciesAutoConfig` set to `true`, ensures that all necessary dependencies for IronPDF to operate efficiently on Linux systems are automatically installed. You might notice that the initial conversion from HTML to PDF could take a bit longer than usual during this initial setup process.

Here's the paraphrased section of the article:

```cs
//Automatically configures dependencies for IronPDF on Linux environments
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

Here is the paraphrased section on Linux Optimized NuGet Packages:

---

## Specialized NuGet Packages for Linux

For those deploying IronPDF in Linux environments, carefully configured NuGet packages are available to streamline the process. Our detailed [Guide to Advanced NuGet Installations](https://ironpdf.com/how-to/advanced-installation-nuget/) provides complete documentation.

Using these specially optimized Linux packages ensures optimal performance and can be seamlessly used even if you're developing on Windows or macOS platforms.

Alternatively, it's possible to directly download the required Linux DLL from [this link](https://ironpdf.com/packages/IronPdf.Linux.zip). 

---

Here's the paraphrased section:

```shell
:InstallCmd Install-Package IronPdf.Linux
```

For Linux-targeted IronPDF implementations, there are specially optimized NuGet packages. You can find detailed steps for their installation in our [IronPDF advanced NuGet installation guide](https://ironpdf.com/how-to/advanced-installation-nuget/).

These Linux-optimized packages can be utilized not just on Linux systems but also when developing on Windows or macOS platforms.

If you prefer, you can also directly [download the DLL for Linux](https://ironpdf.com/packages/IronPdf.Linux.zip).

## Docker and Linux Configuration

For detailed guidance on integrating IronPDF within a Docker environment, please consult our [comprehensive guide](https://ironpdf.com/how-to/docker-linux/) which provides step-by-step instructions for configuring a Docker image to incorporate IronPDF.

## Compatibility with Ubuntu

Ubuntu stands as the most extensively tested Linux OS within our frameworks due to its significant role in the Azure systems we deploy for continuous testing. This environment is fully supported by official Microsoft .NET services and comes with approved Docker images.

### Compatibility with Ubuntu 20

IronPDF fully supports Ubuntu 20 right out of the box, requiring no additional configurations for effective use.

![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Google Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

- Provides innate support for **Chrome** and **WebKit** for rendering HTML to PDF.
- Seamlessly compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- The platform is also tested extensively with numerous other .NET Core versions on Ubuntu 20.
- Prior to every release, we conduct over 997 unit tests to ensure reliability and performance on this platform.

**Available Official Microsoft Docker Images:**

- [Ubuntu 20.04 Docker Image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Ubuntu 20.04 Docker Image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting Up Ubuntu 20 Manually**

For scenarios where you might prefer a manual setup, or if your application cannot be run with administrative privileges:

Disable automatic configuration setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Proceed with installing the necessary libraries:

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

chmod 755 IronCefSubprocess # Adjust the path if needed
```

The **IronCefSubprocess** binary is part of your application's binaries, usually found within the `bin/runtimes/linux-x64/` directory. You might require administrative (`sudo`) privileges for these operations.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 20 is fully compatible with IronPDF straight from the installation, requiring no additional configuration.

- Enables HTML to PDF conversions using **Chrome** and **WebKit** rendering engines.
- Provides full support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Also offers compatibility with numerous other .NET Core frameworks on Ubuntu 20, though unofficially.
- Prior to release, we execute more than 997 unit tests on this setup to ensure robustness and reliability.

**Microsoft's Official Docker Images:**

- [Ubuntu 20.04 Docker Image for .NET Runtime 3.1, labeled '3.1-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Ubuntu 20.04 Docker Image for .NET Runtime 5.0, labeled '5.0-focal'](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Guidelines for Manual Setup on Ubuntu 20**

Should you require a manual installation, or if your application lacks _sudo_ admin privileges:

Disable automatic dependency configuration by setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```
```

Below is the paraphrased section of the article:

```sh
# Refresh package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Bulk installation of required dependencies

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1 libgdiplus libva-dev

# Ensure the IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Location in project directory: bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```
This revision maintains the technical instructions and lists of installations, while streamlining the commands into fewer lines for clarity and efficiency.

- **IronCefSubprocess**, as referred to here, is a binary file located in your application's `bin` directory. It might be essential to specify the precise path, often found in the `runtimes` sub-folder of `bin`.

- Execution might require `sudo` privileges.
```

### Ubuntu 18 Compatibility Guide

Ubuntu 18 is fully compatible with IronPDF right from the setup, requiring no additional configuration.

- Both Chromium and WebKit HTML to PDF conversion engines are supported.
- Full support for **.NET Core 3.1 LTS** and **.NET 5 runtimes**.
- While not officially listed, numerous other .NET Core runtimes demonstrate high compatibility with Ubuntu 18.
- Every release of IronPDF undergoes rigorous smoke tests on Ubuntu 18.

**Certified Microsoft Docker Images:**

- **Ubuntu 18.04 LTS 64-bit Docker Image for .NET Core 3.1** available at [microsoft-dotnet-runtime: 3.1-bionic](https://hub.docker.com/_/microsoft-dotnet-runtime/).
- Despite the absence of an official Docker image for .NET 5 on Ubuntu 18, compatibility remains high.

**Guide for Manual Installation on Ubuntu 18:**

For those requiring a manual setup or for applications that cannot run with administrative privileges, you can disable the automatic configuration:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then, update and install necessary libraries:

```bash
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

chmod 755 /path/to/IronCefSubprocess  # Note: Adjust the path as necessary
```

This detailed manual process ensures that all dependencies are correctly installed, enabling IronPDF to function optimally on Ubuntu 18.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully supported by IronPDF right from the start, requiring no initial configuration for users.

- Implements HTML to PDF conversion using **Chrome** and **WebKit** rendering technologies
- Provides official support for **.NET Core 3.1 LTS** and **.NET 5** environments
- Offers additional, unofficial support for a broader range of .NET Core runtimes, extending even to Ubuntu 16
- Ensures high-quality operation through extensive smoke testing prior to each software release

### Official Docker Images for Ubuntu 18

- Access the [64-bit Docker image for .NET 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- Note that while there isn't an official Docker image for .NET 5 on Ubuntu 18, the compatibility level remains exceptionally high.

### Manual Installation on Ubuntu 18

For scenarios where manual installation is necessary or when your application does not have administrative privileges:

Disable automatic Linux and Docker dependencies configuration by setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install base libraries

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libc6 libc6-dev

# Install user interface and rendering libraries

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Set executable permissions for IronCefSubprocess

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Path for IronCefSubprocess within application

***Based on <https://ironpdf.com/how-to/linux/>***

# typically at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

### Ubuntu 16 Compatibility

Ubuntu 16 receives only limited and unofficial support from IronPdf. This version has not undergone extensive testing with our software.

Microsoft officially supports .NET for Ubuntu 16, which has shown compatibility with IronPdf based on user reports. For developers, some manual configurations may be needed, particularly with the `apt-get` dependancies.

- **Chrome** and **WebKit** are likely to operate with manual setup.
- **.NET Core 3.1 LTS** and **.NET 5 runtimes** are officially supported by Microsoft for Ubuntu 16.
- At this time, there are no official Microsoft Docker images available for Ubuntu 16.

**Setting Up Ubuntu 16 Manually**

If manual installation is necessary, or if your application cannot operate with administrative (_sudo_) privileges, configure the system as follows:

Disable automatic dependency configuration:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Update and install necessary libraries:

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
# (IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory)

***Based on <https://ironpdf.com/how-to/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Support for Ubuntu 16 within the IronPDF framework is limited and informal. It has not undergone extensive testing with IronPdf.

Microsoft officially supports .NET on Ubuntu 16, and there are many instances of successful IronPdf integrations reported by users. However, manual installation of dependencies using `apt-get` may be necessary.

The following functionalities typically require manual configuration to function:
- **Chrome** and **WebKit** rendering engines.
- The **.NET Core 3.1 LTS** and **.NET 5** runtimes are supported by Microsoft for Ubuntu 16.

Currently, there are no official Microsoft Docker images available for Ubuntu 16.

### Manual Setup for Ubuntu 16

For cases where your application does not have administrative privileges or you prefer a manual setup:

You should disable automatic dependency configuration by setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install necessary libraries

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

# Change permissions to make IronCefSubprocess executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory.

***Based on <https://ironpdf.com/how-to/linux/>***

```

## Compatibility with Debian

Debian ranks as the second most extensively tested Linux distribution within our systems. It enjoys robust support from Microsoft.NET and is also fully supported by Official Docker images.

### Debian 11 Compatibility

Debian 11 is fully compatible with IronPDF out of the box, requiring no additional set-up. This distribution is the default choice for Microsoft when integrating Docker into a .NET project with Visual Studio.

![Debian Logo](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

IronPDF supports HTML to PDF conversions using both Chrome and WebKit rendering engines on Debian 11. It officially supports .NET Core runtimes ranging from 3.1 to 8, as well as several other runtimes unofficially. Our team conducts over 997 unit tests to ensure reliable functionality on this platform.

**Official Microsoft Docker Images available for Debian 11:**
- [.NET Runtime 3.1 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Installation on Debian 11**
For scenarios where auto-configuration is not suitable or administrative privileges are unavailable, you can set up IronPDF manually by disabling automatic dependency management.

Set automatic configuration to false:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then proceed with installing the necessary dependencies:

```sh
apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libxkbcommon-x11-0 libxrender1 libfontconfig1 libxshmfence1

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is usually located in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/how-to/linux/>***

```

This setup ensures that all the required libraries and components are installed for optimal operation of IronPDF on Debian 11.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 11 serves as Microsoft's default Linux distribution when incorporating Docker support for .NET projects in Visual Studio.

IronPDF effortlessly integrates with Debian 11, requiring no additional configuration.

- Enables HTML to PDF rendering with both **Chrome** and **WebKit** engines.
- Fully supports **.NET Core** runtimes 3.1, 5, 6 (LTS), 7, and 8.
- Provides unofficial support for additional .NET Core runtimes on Debian 11.
- Conducts extensive testing, with over 997 unit tests performed on this platform for each release.

**Official Microsoft Docker Images:**

- [64-bit Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup for Debian 11:**

For scenarios where you prefer manual installation, or if your application does not have _sudo_ admin privileges.

Ensure to disable automatic dependency configuration by setting:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update the package listings

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install essential libraries and components

***Based on <https://ironpdf.com/how-to/linux/>***

apt install -y libc6-dev             # C standard library development files
apt install -y libgtk2.0-0           # GTK graphical user interface library
apt install -y libnss3               # Network Security Service libraries
apt install -y libatk-bridge2.0-0    # Accessibility Toolkit bridge
apt install -y libx11-xcb1           # X11 client-side library
apt install -y libxcb-dri3-0         # X protocol C-language Binding, Direct Rendering Infrastructure
apt install -y libdrm-common         # Userspace interface to kernel DRM services
apt install -y libgbm1               # Generic Buffer Management API
apt install -y libasound2            # ALSA sound library
apt install -y libxkbcommon-x11-0    # Common library to handle keyboard description files
apt install -y libxrender1           # Rendering Extension client library
apt install -y libfontconfig1        # Font configuration and customization library
apt install -y libxshmfence1         # X shared memory fence synchronization library

# Change permissions to make 'IronCefSubprocess' executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: 'IronCefSubprocess' is typically located in 'bin/runtimes/linux-x64/' within your application's directory

***Based on <https://ironpdf.com/how-to/linux/>***

``` 

This updated script handles the required updates and installation commands for your Linux system to support `IronPdf`. It also ensures that the 'IronCefSubprocess', essential for IronPdf operations, has the proper permissions set for execution.

### Debian 10 Compatibility 

Debian 10 is fully supported by IronPDF for hassle-free operation. 

![Debian Logo](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

This distribution aids in seamless operations with its support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes coupled with **Chrome** and **WebKit** for HTML to PDF transformations. Even better, the support extends to other .NET Core runtimes, though not officially stated. Each iteration undergoes rigorous validation with over 997 unit tests conducted before any release.

**Official Docker Containers Provided by Microsoft:**

- [Debian 10 Docker Image with .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Debian 10 Docker Image with .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Setting up Debian 10 Manually**

Manual setup is available for instances where administrative rights are absent, or for a more customized installation.

Toggle the auto configuration setting off if required:
```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then update and install necessary dependencies:
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

chmod 755 /path/to/bin/runtimes/linux-x64/IronCefSubprocess
```

Setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false` and performing manual steps ensures your setup meets the precise configurations needed for optimal PDF rendering.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 10 is fully compatible with IronPDF right away, requiring no initial setup to get started.

- Enables HTML to PDF conversions using both **Chrome** and **WebKit** engines.
- Provides official support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** versions.
- Also extends support to a wide range of other .NET Core versions under unofficial capacity.
- Conducts thorough testing with more than 997 unit tests on this platform with every new release.

### Official Microsoft Docker Images for Debian 10

- You can find the 64-bit Debian 10 Docker images for .NET Runtime 3.1 at [this location](https://hub.docker.com/_/microsoft-dotnet-runtime/).
- The Docker image for .NET Runtime 5.0 is also available [here](https://hub.docker.com/_/microsoft-dotnet-runtime/).

### Manual Setup for Debian 10

In cases where you prefer manual installation or where your application lacks _sudo_ administrative rights, start by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`. This adjustment disables automatic dependency configuration, prompting a manual setup approach.

```sh
# Update package lists

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install required libraries

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

# Ensure the IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory within your project.

***Based on <https://ironpdf.com/how-to/linux/>***

```

### Compatibility of Debian 9 and Earlier Versions

Debian 9 and prior versions are not officially tested, thus IronPDF may not work seamlessly with these older platforms. However, .NET is officially supported by Microsoft on Debian 9, and it's feasible to use IronPdf effectively with the proper setup. If you're working with Debian 9 or an earlier version, see [Common Dependency Patterns for Linux](#anchor-other-linux-distros) at the conclusion of this guide for detailed configuration instructions.

Unfortunately, Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 on Debian 9. We highly recommend upgrading to Debian 10 to ensure smoother operations and better support.

Refer to [this detailed guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) for specific instructions on dependency management and toolset compatibility issues associated with older Debian distributions.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 has not undergone official testing with IronPdf and cannot be expected to function immediately upon installation. Although Microsoft officially supports .NET for Debian 9, appropriate setup and configuration may enable it to work effectively with IronPdf. For detailed guidance on installation, refer to the ["Common Dependency Patterns for Linux"](ironsoftware.com#anchor-other-linux-distros).

Furthermore, there are no official Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 designed specifically for Debian 9. It is strongly advised to upgrade to Debian 10 for better compatibility and support.

## CentOS Support Overview

IronPDF provides robust support for CentOS operating systems, ensuring seamless functionality with simple setup requirements.

### CentOS 8 Compatibility

IronPDF is fully compatible with CentOS 8 and requires no additional configuration to start working.

- Supports **Chrome** and **WebKit** HTML to PDF conversion engines 
- Ensures compatibility with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes
- Although not officially supported, IronPDF may still function with other .NET Core runtimes
- Comprehensive smoke testing is performed before releases, confirming the reliability on CentOS platforms.

Unfortunately, as of the latest developments, there are no official Docker images for .NET Core 3.1 or .NET 5.0 on CentOS 8.

**Manual Setup for CentOS 8:**
For instances where automated installations are not possible (such as non-administrative rights settings), manual installation is feasible:

Ensure `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` is disabled:

```sh
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Run the following commands to introduce necessary dependencies:

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

# Ensure IronCefSubprocess is executable:

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# Common location: bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

### CentOS 7 and Earlier

CentOS 7 and lower versions are not actively supported by IronPDF. These editions have not undergone formal testing and may not operate correctly out-of-the-box.

However, .NET on CentOS 7 is recognized by Microsoft officially, suggesting potential compatibility with proper setup:

```sh
dnf -y update
dnf -y install [necessary-packages]
# Add other dependencies as required

***Based on <https://ironpdf.com/how-to/linux/>***


chmod 755 IronCefSubprocess  # Ensure it's executable
# Typically found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/how-to/linux/>***

```

For these versions, manual installations and configurations are advisable, especially for setting up dependencies required by the Chromium engine used by IronPDF. Concerns regarding legacy support should direct you to consult the section on "Common Dependency Patterns for Linux" provided later in the documentation.

For each version, it's essential to ensure that the IronCefSubprocess binary is executable to enable proper function within the .NET processes that depend on IronPDF.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Iron Software holds a positive attitude towards and provides robust support for CentOS.

### CentOS 8 Compatibility

CentOS 8 is fully compatible with IronPDF right from the start, requiring **no initial configuration**.

- Enables HTML to PDF conversions using **Chrome** and **WebKit** rendering engines.
- Provides full support for **.NET Core 3.1, 5, 6 (LTS), 7**, and **8**.
- Offers partial support for additional .NET Core runtimes on CentOS.
- Extensive smoke tests are conducted on this platform before each update.

Regrettably, there are no official Docker images from Microsoft for **.NET Core 3.1** or **.NET 5.0** on CentOS 8.

**Setting Up CentOS 8 Manually**

For manual installation or scenarios where your application lacks _sudo_ administrative rights:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

```sh
# Update the packages index

***Based on <https://ironpdf.com/how-to/linux/>***

dnf -y update

# Install necessary libraries and development packages

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

# Set execute permissions for IronCefSubprocess

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# (IronCefSubprocess is usually located in the bin/runtimes/linux-x64/ directory)

***Based on <https://ironpdf.com/how-to/linux/>***

```

### CentOS 7 and Prior Versions

CentOS 7 is not currently tested and therefore not guaranteed to seamlessly integrate with IronPDF.

While Microsoft officially supports running .NET on CentOS 7, it's probable that IronPDF could function properly if configured accurately. For more details on configuration, refer to ["Common Dependency Patterns for Linux"](ironsoftware.com/#anchor-other-linux-distros) in the text below.

It's important to note, Microsoft has not released official Docker images for .NET Core 3.1 or .NET 5.0 on CentOS 7.

## Compatibility with Amazon AWS Linux 2

IronPDF offers effective support for Amazon AWS Linux 2, which is integral to Amazon's core cloud services including EC2 and Lambda.

Unfortunately, there are no official Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 on Amazon AWS Linux 2. Despite this, we conduct manual testing to ensure the compatibility of IronPDF with this platform.

We highly recommend referring to our detailed [IronPDF AWS Lambda Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), which includes a functional Docker file tailored for IronPDF on AWS Lambda.

### Manual Setup for Amazon Linux 2

For instances where manual installation is necessary or when your application cannot be run with _sudo_ administrative rights, you should disable automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false`.

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
# (IronCefSubprocess is usually located at bin/runtimes/linux-x64/)

***Based on <https://ironpdf.com/how-to/linux/>***

```

Be sure to also check our full [IronPdf guide for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/) for more insights on installation and system logging on the Amazon cloud platform.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Iron Software provides robust support for Amazon AWS Linux 2, which is integral to Amazon’s cloud offerings like EC2 and Lambda.

- Unfortunately, there are no official Microsoft Docker images for .NET Core 3.1 or .NET 5.0 specifically tailored for Amazon AWS Linux 2.

- The compatibility of IronPDF with Amazon AWS Linux 2 is assured through rigorous manual testing done by our development team.

For guidance on implementing IronPDF with AWS Lambda, consider exploring our comprehensive guide which includes a functional Docker file setup for IronPDF on AWS Lambda. You can find this detailed resource here: [IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/).

**Manual Setup for Amazon Linux 2**

For instances where you prefer a manual setup, or if your application doesn’t have admin privileges typically required for automated installations, please ensure the following configuration is set to `false`:

```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```
This setting prevents the automatic configuration process, allowing for manual control over the installation.

```sh
# Update the system's package repository

***Based on <https://ironpdf.com/how-to/linux/>***

yum update -y

# Install necessary libraries and fonts

***Based on <https://ironpdf.com/how-to/linux/>***

yum install -y pango.x86_64 libXcomposite.x86_64 libXcursor.x86_64 libXdamage.x86_64
yum install -y libXext.x86_64 libXi.x86_64 libXtst.x86_64 cups-libs.x86_64
yum install -y libXScrnSaver.x86_64 libXrandr.x86_64 GConf2.x86_64 alsa-lib.x86_64
yum install -y atk.x86_64 gtk3.x86_64 ipa-gothic-fonts xorg-x11-fonts-100dpi
yum install -y xorg-x11-fonts-75dpi xorg-x11-utils xorg-x11-fonts-cyrillic xorg-x11-fonts-Type1
yum install -y xorg-x11-fonts-misc glibc-devel.x86_64 at-spi2-atk.x86_64 mesa-libgbm.x86_64
yum install -y libxkbcommon

# Ensure IronCefSubprocess is executable. Adjust the path as necessary.

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess # This file is typically located within the `bin/runtimes/linux-x64/` directory.
```

For further details, consult our guide on [IronPdf for AWS Lambda](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/), which covers both installation and logging procedures on the Amazon cloud platform.

## Fedora Linux Compatibility

Fedora Linux is fully compatible with IronPDF.

IronPDF seamlessly integrates with Fedora Linux 33, requiring no additional configuration to get started.

- Enables HTML to PDF conversions using both **Chrome** and **WebKit** rendering engines
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtime environments
- Extensive smoke tests are conducted regularly to ensure reliability on this platform

**Manual Setup for Fedora Linux**

For scenarios where automatic installations are not feasible, or if your application lacks _sudo_ administrative rights:

This guidance might also be applicable for both older and newer versions of Fedora Linux.

Disable automatic dependency management by setting:

```cs
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Here's the paraphrased version of the given section, with resolved relative links and image paths:

```sh
# Update the package databases to their latest versions.

***Based on <https://ironpdf.com/how-to/linux/>***

sudo dnf -y update

# Install essential libraries for system compatibility and performance.

***Based on <https://ironpdf.com/how-to/linux/>***

sudo dnf -y install glibc-devel nss at-spi2-atk libXcomposite libXrandr mesa-libgbm alsa-lib pango cups-libs libXdamage libxshmfence

# Set appropriate permissions for the IronCefSubprocess binary to ensure it is executable.

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 /bin/runtimes/linux-x64/IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64 directory.

***Based on <https://ironpdf.com/how-to/linux/>***

```

## Compatibility with Alpine Linux

Currently, IronPDF does not provide support for Alpine Linux. Despite our appreciation for this lightweight OS and our desire to include it, its use of the outdated "musl" C libraries hinders full compatibility with Chromium, necessary for IronPDF functionalities. As Alpine evolves, we hope to eventually offer support.

### Utilizing IronPdf Engine Container on Alpine with .NET 6

IronPdf offers a comprehensive container image that includes all functionalities of IronPdf. This allows applications on Alpine to take advantage of IronPdf by integrating with the IronPdfEngine container.

#### Step 1: Retrieve and Launch IronPdf Engine Docker Image

To start using the IronPdf Engine on your Docker setup, follow these commands in your terminal to fetch and execute the IronPdf Engine Docker image:

```shell
# Download the official IronPDF Engine Docker image from Iron Software's repository

***Based on <https://ironpdf.com/how-to/linux/>***

docker pull ironsoftwareofficial/ironpdfengine
```

```shell
# Start the IronPdf Engine Docker container in detached mode, mapping port 33350

***Based on <https://ironpdf.com/how-to/linux/>***

docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

Here is the paraphrased section:

-----
## Step 2: Configuration of Console Application

Initialize a fresh console application designed for .NET 6.

Proceed to install the `IronPdf.Slim` NuGet package via the NuGet Package Manager.

## Support for Additional Linux Distributions

IronPDF can be manually installed on unsupported Linux distributions using package managers like **apt-get**, **hfs**, and **yum**. This flexibility allows developers to integrate IronPDF even into environments not officially supported.

Initially, IronPDF might signal some missing system dependencies through exceptions. Addressing these is crucial for successful installation and operation.

One critical component is the **IronCefSubprocess** binary, commonly located in the `bin` folder of your application or, more specifically, within the `runtimes` subdirectory. This file is essential for proper function, and it's vital to ensure it's executable:

```sh
chmod 755 IronCefSubprocess
```

Remember, running these commands might require `sudo` privileges to ensure the necessary access rights.

For those using a Linux OS not listed in our documentation, it's advisable to investigate and mimic the dependency patterns of the Chromium browser specific to that OS. This approach can often resolve potential compatibility issues.

Should you wish to request official support for an additional Linux distribution, please get in touch with us at [support@ironsoftware.com](mailto:support@ironsoftware.com).

**Examining Common Dependency Patterns for Linux**

It's beneficial to learn about the common dependencies required across various Linux systems, as detailed in the previous sections of this guide. Understanding these patterns can help streamline the setup process for IronPDF on your specific Linux distribution.

```sh
# Update package information

***Based on <https://ironpdf.com/how-to/linux/>***

apt update

# Install essential libraries needed for proper functioning

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

# Make the IronCefSubprocess executable, usually found within the bin's runtimes for Linux x64 architectures.

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 IronCefSubprocess
# (Path can vary)

***Based on <https://ironpdf.com/how-to/linux/>***

```

## IronCefSubprocess

The **IronCefSubprocess** is an essential binary component located inside the `bin` directory of your application. It must be set as executable to function properly with the .NET environment.

For instance, the path to set it could be different based on your setup:
```sh
chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

```sh
# Give execute permission to the IronCefSubprocess binary within your Linux environment

***Based on <https://ironpdf.com/how-to/linux/>***

chmod 755 bin/runtimes/linux-64/IronCefSubprocess
```

## Publishing a .NET Project as a Single File on Linux

To package your .NET project into a single executable file for Linux distributions, follow these steps:
```cs
dotnet publish -r linux-x64 /property:PublishProfile=FolderProfile /bl
```

Here's the paraphrased section of the article:

```sh
dotnet publish --runtime linux-x64 --property:PublishSingleFile=true /bl
```

## Configuration of Temporary File Paths

For certain scenarios, developers must define a writable location where temporary files can be stored.

A frequently used and secure directory for this purpose on Linux is `/tmp/`. However, it's essential to ensure that this directory is accessible and writable by the user.

Here's the paraphrased version of the specified section:

```cs
// Configure the temporary path for IronPDF
string temporaryPath = @"/tmp/";

// Set the log file path for IronPDF operations
IronPdf.Logging.Logger.LogFilePath = temporaryPath;

// Configure environment variables for temporary file storage
Environment.SetEnvironmentVariable("TEMP", temporaryPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", temporaryPath, EnvironmentVariableTarget.Process);

// Set the temporary folder path and the custom deployment directory for IronPDF
IronPdf.Installation.TempFolderPath = temporaryPath;
IronPdf.Installation.CustomDeploymentDirectory = temporaryPath;
```

