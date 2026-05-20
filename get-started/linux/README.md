# Utilizing IronPDF on Linux

***Based on <https://ironpdf.com/get-started/linux/>***


IronPDF is compatible with Linux environments across multiple versions of **.NET 10, 9, 8, 7, 6, 5**, as well as **.NET Core**. This compatibility extends to various deployment and containerization platforms including Docker, Azure, AWS, macOS, and Windows.

**Officially Supported Platforms for Deployment and Hosting**

<img src="https://ironpdf.com/img.icons8.com/color/96/000000/linux--v1.png" width="96" height="96" style="display:inline; width: 96px !important; height: 96px !important;" />
<img src="https://ironpdf.com/img.icons8.com/color/96/000000/docker.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />
<img src="https://ironpdf.com/img.icons8.com/fluency/96/000000/azure-1.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />
<img src="https://ironpdf.com/img.icons8.com/color/96/000000/amazon-web-services.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />

<img src="https://img.icons8.com/color/96/000000/linux--v1.png" width="96" height="96" style="display:inline; width: 96px !important; height: 96px !important;" />
<img src="https://img.icons8.com/color/96/000000/docker.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />
<img src="https://img.icons8.com/fluency/96/000000/azure-1.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />
<img src="https://img.icons8.com/color/96/000000/amazon-web-services.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />

**Recognized Linux Distributions Supported by IronPDF**

![Linux Ubuntu](https://img.icons8.com/color/96/000000/ubuntu--v1.png "Ubuntu") ![Linux Debian](https://img.icons8.com/color/96/000000/debian--v1.png "Debian") ![Linux CentOS](https://img.icons8.com/color/96/000000/centos--v1.png "CentOS")

<img src="https://img.icons8.com/color/96/000000/ubuntu--v1.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />
<img src="https://img.icons8.com/color/96/000000/debian--v1.png" width="96" height="96" style="display:inline; width: 96px !important; height: 96px !important;" />
<img src="https://img.icons8.com/color/96/000000/centos--v1.png" width="96" height="96" style="display:inline;  width: 96px !important; height: 96px !important;" />

### Tips for IronPDF on Linux

For optimal performance, it's advised to employ .NET Core 8.0 or other [Microsoft-maintained LTS versions](https://dotnet.microsoft.com/platform/support/policy) as they offer stable long-term support and have been thoroughly tested on Linux platforms.

IronPDF is engineered to function seamlessly on Linux right out of the box, obviating the need for any code modifications. This smooth integration is the result of rigorous testing and meticulous configuration by our development team.

Supporting Linux is crucial given its widespread use in key cloud services including Azure Web Apps, Azure Functions, AWS EC2, AWS Lambda, and Docker on Azure DevOps. Our familiarity with these technologies ensures that both enterprise and SaaS clients receive robust support when using IronPDF.

For further assistance or to deepen your understanding of IronPDF’s implementation on Docker, please consult our detailed [guide on using IronPDF with Docker](https://ironpdf.com/how-to/docker-linux/). Additionally, IronPDF can be utilized on Linux via a Windows environment with the aid of WSL, providing another convenient usage scenario.

### Linux-Specific Packages for IronPDF

#### NuGet Availability

- Access the `IronPdf.Linux` package directly from [NuGet](https://www.nuget.org/packages/IronPdf.Linux).

#### Downloadable DLL

For scenarios requiring offline development, download the DLL to include in your project:

- [IronPdf.Linux.zip](https://ironpdf.com/packages/IronPdf.Linux.zip)

For detailed guidelines on Linux packages and additional information on system-specific packages, please refer to our comprehensive [IronPDF advanced NuGet installation tutorial](https://ironpdf.com/how-to/advanced-installation-nuget/).

### Supported Linux Distributions for IronPDF

IronPDF is fully compatible and optimized for the following **64-bit** Linux distributions, allowing for seamless integration without any additional configuration:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Ubuntu 16
- Debian 11
- Debian 10
- CentOS 8
- Fedora Linux 33
- Amazon AWS Linux 2

For implementations using IronPDF on Linux versions not listed here, please consult the [Common Dependency Patterns for Linux](#other-linux-distros) detailed later in this documentation.

## Hardware Requirements

IronPDF leverages the Chromium engine to convert HTML content to PDFs, ensuring precision that aligns with the printing functionalities of the Chrome browser. This process demands substantial system resources due to the sophisticated nature of the rendering process.

- **Minimum System Requirements**: At least 1 CPU core and 1.75 GB of RAM.
- **Recommended System Configuration**: 2 CPU cores and a minimum of 8 GB of RAM.

### Automated Setup for Linux

By default, the `LinuxAndDockerDependenciesAutoConfig` setting is enabled (`true`). This configuration will proactively handle the installation of all necessary dependencies required for IronPDF to operate on Linux systems. Be aware that the initial conversion from HTML to PDF might require additional processing time.

```csharp
// Automatically manage Linux and Docker dependencies for IronPDF
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

## Compatibility with Ubuntu Systems

Ubuntu ranks as the most thoroughly evaluated Linux distribution within our framework, extensively utilized across Azure's infrastructure for ongoing tests and deployments. Additionally, this platform is officially supported by Microsoft for .NET developments and includes official Docker images.

### Ubuntu 20 Compatibility Details

Ubuntu 20 is fully compatible with IronPDF and offers seamless integration without requiring any configuration adjustments. This is our most thoroughly tested Linux distribution, primarily utilized in the Azure ecosystem for relentless testing and deployment activities. Additionally, it benefits from official .NET support from Microsoft and is equipped with officially endorsed Docker images.

![Microsoft Logo](https://img.icons8.com/color/48/000000/microsoft.png)
![Ubuntu Logo](https://img.icons8.com/color/48/000000/ubuntu--v1.png)
![Chrome Logo](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Logo](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker Logo](https://img.icons8.com/color/48/000000/docker.png)
![Azure Logo](https://img.icons8.com/fluency/48/000000/azure-1.png)

IronPDF fully supports Ubuntu 20 right out of the box, facilitating:

- Both Chrome and WebKit for HTML to PDF conversions.
- Compatibility with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Inclusive support for numerous additional .NET Core runtimes on Ubuntu 20.
- Extensive testing through over 997 unit tests on this platform prior to each software release.

**Official Microsoft Docker Images for Ubuntu 20:**

- [.NET Runtime 3.1 on 64-bit Ubuntu 20.04 ('3.1-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 on 64-bit Ubuntu 20.04 ('5.0-focal') Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup Guide for Ubuntu 20**

For scenarios where manual installation becomes essential or in cases where your application is not operable with admin privileges, you should manually handle the dependencies. Furthermore, set `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to false to proceed with the manual setup.

```sh
# First, update and install essential libraries

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
apt install -y libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0
apt install -y libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1
apt install -y libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence1
apt install -y libgdiplus libva-dev

# Ensure that IronCefSubprocess has the appropriate permissions

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Usually located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

Ubuntu 20 represents a robust platform for deploying applications with IronPDF, ensuring a smooth and efficient operation.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

# Seamless Integration with Ubuntu 20 Using IronPDF

***Based on <https://ironpdf.com/get-started/linux/>***


IronPDF fully supports Ubuntu 20, which requires **no configuration** to get started.

- It offers support for both **Chrome** and **WebKit** HTML to PDF conversion engines.
- Includes full support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Provides additional, non-guaranteed support for other .NET Core runtimes applicable to Ubuntu 20.
- Each release is rigorously tested with over 997 unit tests conducted on the Ubuntu 20 platform.

### Official Microsoft Docker Images for Ubuntu 20

IronPDF supports the following official Docker images from Microsoft for seamless deployment:

- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 3.1 ('3.1-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Ubuntu 20.04 Docker Image for .NET Runtime 5.0 ('5.0-focal')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Setup for Ubuntu 20

In scenarios where you require manual installation, or your application cannot run with _sudo_ admin privileges, you can configure IronPDF manually. To do so, ensure that the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` is set to `false`. This enables manual control over the installation of necessary dependencies. Here is how you can proceed:

```sh
# Update and fetch the latest packages

***Based on <https://ironpdf.com/get-started/linux/>***

apt update

# Install all necessary libraries

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
apt install -y libxshmfence1
apt install -y libgdiplus
apt install -y libva-dev

# Make sure IronPdf's IronCefSubprocess has the appropriate permissions

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Assuming the file is located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

``` 

By addressing these manual setup attributes, Ubuntu 20 users can tailor IronPDF settings to fit unique application requirements, ensuring the best possible performance and compatibility.

```sh
# Start by updating your system and installing the required libraries

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
apt install -y libc6-dev        # C standard library
apt install -y libgtk2.0-0      # GNOME toolkit for GUIs
apt install -y libnss3          # Network Security Services lib
apt install -y libatk-bridge2.0-0  # Accessiblity Toolkit for GTK+ apps
apt install -y libx11-xcb1        # X11 client-side library
apt install -y libxcb-dri3-0      # X protocol C-language Binding
apt install -y libdrm-common      # Direct Rendering Manager
apt install -y libgbm1            # Graphics Buffer Management
apt install -y libasound2         # ALSA sound library
apt install -y libappindicator3-1 # Symbol and menu registration for apps
apt install -y libxrender1        # X Rendering Extension client lib
apt install -y libfontconfig1     # Font configuration and customization library
apt install -y libxshmfence1      # X shared memory fence library
apt install -y libgdiplus         # GDI+ API for X Window System
apt install -y libva-dev          # Development files for libva

# Modify the permissions to ensure IronCefSubprocess can execute

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: You will typically find IronCefSubprocess located in your project's bin/runtimes/linux-x64 path.

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Ubuntu 18 Compatibility

Ubuntu 18 is fully compatible with IronPDF right out of the box, requiring no additional configuration.

- Supports both Chrome and WebKit HTML to PDF conversion technologies
- Provides official backing for **.NET Core 3.1 LTS** and **.NET 5 runtimes**
- Offers unofficial support across a wider range of .NET Core runtimes for Ubuntu 18 and Ubuntu 16
- Extensive testing is performed through rigorous smoke tests before each product release
- Although there is no official Docker image for .NET 5 on Ubuntu 18, compatibility is typically excellent

**Official Microsoft Docker Images:**

For precise runtime compatibility, you can consider:

- [Ubuntu 18.04 Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Custom Installation for Ubuntu 18:**

For instances where automatic setup is not possible or if your application demands manual privileges management, you can disable IronPDF's automatic dependency handling by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false` and proceeding with manual installation.

```sh
# Refreshing repositories and installing necessary packages

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
apt install -y libc6 libc6-dev libgtk2.0-0 libnss3 libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0 libdrm-common libgbm1 libasound2 libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Updating permissions to ensure executability

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# IronCefSubprocess is generally located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

By following these instructions, you ensure that your IronPDF implementation on Ubuntu 18 will operate smoothly and effectively.

<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Ubuntu 18 is fully supported by IronPDF without any need for initial configuration.

- Supports both **Chrome** and **WebKit** for HTML to PDF conversions.
  
- Provides official support for **.NET Core 3.1 LTS** and **.NET 5** runtimes.
  
- Offers additional, albeit unofficial, support for a range of other .NET Core runtimes on both Ubuntu 18 and 16.

- Extensive testing through continuous smoke tests is conducted on this platform before each software release.

### Official Images from Microsoft for Docker

- [64-bit Ubuntu 18.04 Docker Image for .NET Runtime 3.1 ('3.1-bionic')](https://hub.docker.com/_/microsoft-dotnet-runtime/)

- There's no specific official Docker image for .NET 5 on Ubuntu 18, yet they maintain a high level of compatibility.

### Manual Installation Process for Ubuntu 18

For scenarios where automated installation is not suitable, or if your application must be executed without _sudo_ privileges, disable automatic dependency installation by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`. Afterward, proceed to manually install the necessary dependencies.

```sh
# Refresh repository and install required packages

***Based on <https://ironpdf.com/get-started/linux/>***

apt update
apt install -y libc6 libc6-dev libgtk2.0-0 libnss3
apt install -y libatk-bridge2.0-0 libx11-xcb1 libxcb-dri3-0
apt install -y libdrm-common libgbm1 libasound2
apt install -y libappindicator3-1 libxrender1 libfontconfig1 libxshmfence-dev

# Set executable permissions for IronCefSubprocess binary

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: You can find the IronCefSubprocess typically in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Ubuntu 16 Support

Ubuntu 16 compatibility is provided with limited support, and .NET on Ubuntu 16 is officially backed by Microsoft, frequently proving functional with IronPdf according to several user experiences. Developer intervention may be needed for additional installations.

- **Chrome** and **WebKit** are generally operable with manual adjustments.
- **.NET Core 3.1 LTS** and **.NET 5 runtimes** are supported by Microsoft for Ubuntu 16.
- Currently, there are no official Microsoft Docker images available for Ubuntu 16.

**Custom Installation for Ubuntu 16**

In cases where automatic capabilities are restricted or administrator rights are not available, it is necessary to manually address software dependencies. Disabling auto-config is advised by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

```sh
# Begin updates and library installations

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Setting necessary permissions for IronCefSubprocess

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Usually found in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/ubuntu--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Our support for Ubuntu 16 is somewhat limited, although Microsoft officially endorses .NET on this version, and many users have successfully integrated IronPdf into their applications on this platform. To achieve optimal functionality, some manual installations of dependencies might be necessary.

Both **Chrome** and **WebKit** can be effectively utilized with manual configurations set up.

Additionally, **.NET Core 3.1 LTS** and **.NET 5 runtimes** are supported on Ubuntu 16 by Microsoft. However, it’s important to note that there are no official Docker images available from Microsoft for Ubuntu 16 at this time.

### Manual Setup for Ubuntu 16

In cases where a manual setup is required, or if your application cannot operate under _sudo_ administrator privileges, you should disable automatic dependency resolution. Do this by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false` and proceed to manually install the necessary dependencies.

```sh
# Begin the update and installation of necessary libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Adjust permissions for IronCefSubprocess to ensure it's executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Reminder: You'll typically find IronCefSubprocess at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Compatibility with Debian

Debian ranks as our second most rigorously tested Linux OS and it is backed by official support from Microsoft for .NET, including Official Docker Images.

### Debian 11 Compatibility

IronPDF is fully compatible with Debian 11 right out of the box, requiring no additional setup for immediate use.

- **Browsers for Rendering**: Supports Chrome and WebKit-based engines for accurate HTML to PDF conversions.
- **.NET Core Support**: Fully compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- **Testing and Reliability**: Over 997 unit tests are performed on this platform before each new release to ensure reliability and performance.

**Official Docker Images for Debian 11**:

- [Debian 11 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [Debian 11 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Manual Setup for Debian 11**:

For scenarios where automatic setup might not be possible or if your application lacks administrative privileges, the automatic dependency setup can be disabled by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;`. Follow these steps to manually install the required libraries:

```sh
# Update the package lists and install the necessary libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Ensure the IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Usually found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 11 is seamlessly supported by IronPDF without requiring any configuration adjustments.

- Provides compatibility with HTML to PDF conversion engines like **Chrome** and **WebKit**.
- Fully supports **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Offers additional, though unofficial, support for numerous other .NET Core runtimes specifically for Debian 11.
- Extensively tested, with more than 997 unit tests performed on this platform for each software release.

### Official Microsoft Docker Images

Access the Debian 11 Docker images for various .NET runtimes provided by Microsoft:

- [.NET Runtime 3.1 - 64-bit Debian 11 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [.NET Runtime 5.0 - 64-bit Debian 11 Docker Image](https://hub.docker.com/_/microsoft-dotnet-runtime/)

### Manual Installation Process for Debian 11

Manual setup might be essential if your application doesn't have _sudo_ admin rights. In such cases, disable the automatic configuration by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` property to `false`, and proceed with installing the required dependencies yourself.

```sh
# Refresh package lists and install essential libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Adjust permissions to allow execution of the IronCefSubprocess binary

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: Typically, the IronCefSubprocess binary is located in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Debian 10 Support

Debian 10 is fully supported by IronPDF, enabling straightforward "no configuration" deployment for users.

![Debian 10 Icon](https://img.icons8.com/color/48/000000/debian.png)
![Microsoft Icon](https://img.icons8.com/color/48/000000/microsoft.png)
![Chrome Icon](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari](https://img.icons8.com/color/48/000000/safari--v1.png)
![Docker](https://img.icons8.com/color/48/000000/docker.png)
![Azure](https://img.icons8.com/fluency/48/000000/azure-1.png)

IronPDF provides full support for Debian 10, facilitating effortless integration and functionality.

- Supports both Chrome and WebKit for HTML to PDF conversions
- Fully compatible with **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes
- While mainly supporting the listed .NET cores, the platform offers limited support for additional runtimes
- Undergoes over 997 unit tests to ensure reliability and robustness with each update

**Official Docker Images from Microsoft:**

- [64-bit Debian 10 Docker Image for .NET Runtime 3.1](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit Debian 10 Docker Image for .NET Runtime 5.0](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Procedure for Manual Setup in Debian 10**

For scenarios requiring manual installation or where administrative privileges are unavailable, you can configure IronPDF manually by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` property to false.

```sh
# Begin by updating and installing essential libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Ensure the IronCefSubprocess binary is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Typically located in bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

This guide streamlines the process of incorporating IronPDF into Debian 10 systems, ensuring you can leverage its powerful PDF rendering capabilities efficiently.

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/microsoft.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/docker.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/azure-1.png" style="display:inline" />

Debian 10 is fully supported by IronPDF directly "out-of-the-box," requiring no additional configuration.

- Provides support for HTML to PDF conversion engines based on **Chrome** and **WebKit**.
- Full support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Offers compatibility, although not officially supported, with a broader range of .NET Core runtimes on Debian 10.
- Over 997 unit tests are executed on this system prior to each release to ensure reliability.

**Official Docker Images from Microsoft:**

- [64-bit .NET 3.1 Runtime Docker Image for Debian 10](https://hub.docker.com/_/microsoft-dotnet-runtime/)
- [64-bit .NET 5.0 Runtime Docker Image for Debian 10](https://hub.docker.com/_/microsoft-dotnet-runtime/)

**Procedures for Manual Setup in Debian 10:**

Should there be a need for manual setup, or if your application cannot operate with _sudo_ administrative rights, you can disable automatic dependency configuration. By setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false`, you can proceed to manually install the necessary dependencies.

Here is the paraphrased section you requested:

```sh
# Commence updates and initiate necessary library installations

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Adjust permissions to allow execution of IronCefSubprocess 

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: The IronCefSubprocess executable is typically located in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Compatibility with Debian 9 and Earlier Versions

Debian 9 and earlier releases are not pre-configured to work seamlessly with IronPdf. While .NET is officially supported on Debian 9 by Microsoft, additional setup is necessary to ensure compatibility. You are encouraged to consult the [Common Dependency Patterns for Linux](#other-linux-distros) provided at the end of this document for guidance.

There are no endorsed Docker images for .NET Core 3.1 or .NET 5.0 available for Debian 9 from Microsoft. Upgrading to Debian 10 is highly recommended to ensure smoother operation and support.

![Debian Version](https://ironpdf.com/images/icons8-color/48/000000/debian.png)
![Testing Icon](https://ironpdf.com/images/icons8-fluency/48/000000/test.png)

<img src="https://img.icons8.com/color/48/000000/debian.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Debian 9 has not undergone official testing with IronPdf and does not provide immediate compatibility. However, while Microsoft officially supports .NET on Debian 9, correct configuration can enable compatibility with IronPdf. For setup guidance, please see the [Common Dependency Patterns for Linux](#other-linux-distros) section provided later in this documentation.

It's important to note that Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 compatible with Debian 9. Transitioning to Debian 10 is strongly advised for better support and functionality.

## CentOS Support with IronPDF

IronPDF provides robust support for CentOS, ensuring seamless integration with this Linux distribution.

### CentOS 8 Compatibility

IronPDF is fully compatible with CentOS 8 right out of the box, requiring no additional configuration. Here's what you can expect:

- **HTML to PDF Conversion**: Supports both Chrome and WebKit-based engines for reliable HTML to PDF rendering.
- **.NET Core Runtime Support**: Fully supports .NET Core versions 3.1, 5, 6 (LTS), 7, and 8.
- **Extended Testing**: Before each release, we conduct detailed smoke tests to ensure reliability and performance on CentOS.

It's important to note that, as of now, there are no official Microsoft Docker images available for .NET Core 3.1 or .NET 5.0 on CentOS 8.

#### Manual Setup Instructions for CentOS 8

If you need to manually set up IronPDF on CentOS 8 or if your application doesn’t have _sudo_ administrative privileges, you'll need to manually install the necessary libraries. Here’s how you can do it:

First, make sure to disable the automatic dependency configuration by setting:
```csharp
IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = false;
```

Then, execute the following commands in your terminal:

```sh
# Start by updating your packages

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y update

# Install required libraries

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y install glibc-devel nss at-spi2-atk libXcomposite libXrandr mesa-libgbm alsa-lib pango cups-libs libXdamage libxshmfence

# Adjust permissions for the IronCefSubprocess, ensuring it is executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# IronCefSubprocess is typically located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Earlier Versions

Currently, CentOS 7 and earlier versions are not tested and hence, are not guaranteed to work right out-of-the-box with IronPdf.

However, CentOS 7 is still officially supported by Microsoft for .NET applications, which suggests that it might be compatible with IronPDF after correct setup. Please refer to the generalized [Common Dependency Patterns for Linux](https://ironpdf.com/how-to/#other-linux-distros) if you plan on configuring it manually.

Reiterating, no official Docker images exist for .NET Core 3.1 or .NET 5.0 on CentOS 7, and upgrading to a newer version of CentOS is strongly recommended for the best experience.

<img src="https://img.icons8.com/color/48/000000/centos.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
 <img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

### Comprehensive CentOS Support

IronPDF provides robust support for CentOS, ensuring seamless operation and optimal performance.

### CentOS 8 Compatibility

CentOS 8 is fully supported right out of the box, which makes setup effortless.

- We offer support for both **Chrome** and **WebKit** based HTML to PDF conversion technologies.
- Official support is extended for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtime versions.
- Although support for additional .NET Core runtimes on CentOS is not official, it is available.
- Regular comprehensive smoke tests are conducted on this platform to ensure reliability before every software update.

Sadly, Microsoft does not offer official Docker images for **.NET Core 3.1** or **.NET 5.0** on CentOS 8, but this does not affect the performance and capabilities of IronPDF's functionalities.

**Manual Installation for CentOS 8**

In situations where automatic installation is not suitable, or when the application cannot be run with _sudo_ admin rights, you can alter the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` setting to `false` to perform a manual setup:

```sh
# Command sequence to update system and install required libraries

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

# Update permissions for the IronCefSubprocess binary

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Location: bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Support for CentOS 7 and Earlier Versions

CentOS 7 is not currently tested and does not have guaranteed out-of-the-box compatibility with IronPdf.

However, since .NET on CentOS 7 is officially supported by Microsoft, it is likely compatible when set up correctly. For detailed configuration, consult the section "Common Dependency Patterns for Linux" earlier in this document.

There are no specified Microsoft official Docker images for .NET Core 3.1 or .NET 5.0 on CentOS 7 currently available.

### CentOS 8 Compatibility

IronPDF offers immediate compatibility with CentOS 8, requiring no preliminary setup.

- Enables both **Chrome** and **WebKit** for HTML to PDF conversions.
- Provides official support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8** runtimes.
- Offers additional, unofficial support for a broader range of .NET Core runtimes on CentOS.
- Performs detailed smoke testing on this operating system before each product release.

Regrettably, Microsoft does not supply official Docker images for **.NET Core 3.1 or 5.0** on CentOS 8.

#### Setup Instructions for CentOS 8

Should manual configuration be required, or if running applications with administrative (_sudo_) privileges is not possible, proceed with the following steps:

Disable automatic dependencies setup by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

```sh
# Start by updating your system's package manager

***Based on <https://ironpdf.com/get-started/linux/>***

dnf -y update

# Proceed to install the necessary development libraries

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

# Modify the permissions to make the IronCefSubprocess executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: Typically, the IronCefSubprocess binary is located in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

### CentOS 7 and Prior Versions Compatibility

The IronPdf software does not directly support CentOS 7 and earlier versions without preliminary configuration.

While Microsoft officially backs .NET on CentOS 7, achieving operational status with IronPdf on these versions necessitates proper setup. For guidance on configuring dependencies, refer to the section on [Common Dependency Patterns for Linux](#other-linux-distros).

It's important to note that Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 tailored to CentOS 7.

## Compatibility with Amazon AWS Linux 2

![Amazon Web Services Icon](https://img.icons8.com/color/48/000000/amazon-web-services.png)
![Chrome Icon](https://img.icons8.com/color/48/000000/chrome--v1.png)
![Safari Icon](https://img.icons8.com/color/48/000000/safari--v1.png)
![Test Icon](https://img.icons8.com/fluency/48/000000/test.png)

IronPDF is fully compatible with Amazon AWS Linux 2, which is the foundation for important Amazon cloud services such as EC2 and Lambda.

- Microsoft does not currently provide official Docker images for .NET Core versions 3.1 or 5.0 on Amazon AWS Linux 2.
- Our developers conduct hands-on testing for Amazon AWS Linux 2 to ensure compatibility as IronPDF evolves.

For further guidance, consult our [IronPDF AWS Lambda guide](https://www.ironpdf.com/get-started/aws/), offering a comprehensive Docker file example optimized for AWS Lambda with IronPDF.

**Manual Configuration for Amazon AWS Linux 2**

To configure IronPDF manually in environments without _sudo_ privileges, disable automatic dependency configuration by setting `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` to `false`.

```sh
# Perform system updates and install required libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Ensure IronCefSubprocess has the appropriate permissions

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# This file is typically found at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

Read our official documentation for more in-depth instructions on [setting up IronPdf for AWS Lambda](https://www.ironpdf.com/get-started/aws/) that includes details on installation and logging within the Amazon cloud environment.

<img src="https://img.icons8.com/color/48/000000/amazon-web-services.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/chrome--v1.png" style="display:inline" />
<img src="https://img.icons8.com/color/48/000000/safari--v1.png" style="display:inline" />
<img src="https://img.icons8.com/fluency/48/000000/test.png" style="display:inline" />

Here’s the revised content as requested:

---
IronPDF is compatible with Amazon AWS Linux 2, which underpins key Amazon cloud services like EC2 and Lambda.

- Microsoft does not provide official Docker images for .NET Core 3.1 or .NET 5.0 specifically for Amazon AWS Linux 2.
- Our compatibility with Amazon AWS Linux 2 is assured through regular manual testing during IronPDF's development.

For detailed guidance, consider exploring our [IronPDF AWS Lambda guide](https://ironpdf.com/get-started/aws/), which includes a practical Docker file setup for using IronPdf with AWS Lambda.

**Manual Configuration for Amazon Linux 2**

When automatic installation isn't feasible, or if your application operates without _sudo_ admin rights, you’ll need to manually configure your system. Begin by ensuring that the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` is set to `false`. Following this, proceed with the manual installation of necessary dependencies.

```sh
# Upgrade and install required system libraries

***Based on <https://ironpdf.com/get-started/linux/>***

yum -y update
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
yum -y install ipa-gothic-fonts
yum -y install xorg-x11-fonts-100dpi
yum -y install xorg-x11-fonts-75dpi
yum -y install xorg-x11-utils
yum -y install xorg-x11-fonts-cyrillic
yum -y install xorg-x11-fonts-Type1
yum -y install xorg-x11-fonts-misc
yum -y install glibc-devel.x86_64
yum -y install at-spi2-atk.x86_64
yum -y install mesa-libgbm.x86_64
yum -y install libxkbcommon

# Modify permissions for IronCefSubprocess to make it executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Note: IronCefSubprocess is typically located in the bin/runtimes/linux-x64/ directory

***Based on <https://ironpdf.com/get-started/linux/>***

```

Please make sure to review our detailed guide on [IronPdf for AWS Lambda](https://ironpdf.com/get-started/aws/) which offers comprehensive instructions for installation and how to handle logs on the Amazon cloud platform.

## Compatibility with Fedora Linux

Fedora Linux seamlessly integrates with IronPDF, requiring no configuration to get started.

- Enables HTML to PDF conversion using **Chrome** and **WebKit** rendering engines.
- Provides native support for **.NET Core 3.1, 5, 6 (LTS), 7, and 8**.
- Extensively tested on this platform prior to each release with detailed smoke tests.

### Setting Up Fedora Linux Manually

For scenarios where a manual setup is required or running with _sudo_ privileges is not feasible, disable automatic dependency management by setting the `IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig` property to `false`. Proceed to manually install the necessary libraries:

Here's the paraphrased section with resolved URL paths as requested:

```sh
# Execute the following commands to install the required libraries

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

# Modify permissions for IronCefSubprocess to make it executable

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Reminder: IronCefSubprocess is typically located at bin/runtimes/linux-x64/

***Based on <https://ironpdf.com/get-started/linux/>***

```

## Alpine Linux Compatibility

As of the current year, Alpine Linux does not support IronPDF. This limitation arises because Alpine continues to utilize the older "musl" C libraries, which are not fully compatible with the requirements of Chromium developers needed to support the operating system.

### Deploying IronPdfEngine on Alpine with Docker in .NET 6

IronPdf offers a comprehensive Docker container that encapsulates all the functionalities of IronPdf. This setup allows applications on Alpine Linux to leverage IronPdf capabilities by linking with the IronPdfEngine Docker container.

#### Step 1: Obtain and Execute the IronPdf Engine Docker Container

Use the commands below in your terminal to retrieve and initiate the IronPdf Engine Docker container:

```shell
# Download the IronPdfEngine Docker container

***Based on <https://ironpdf.com/get-started/linux/>***

docker pull ironsoftwareofficial/ironpdfengine

# Start the IronPdfEngine Docker container

***Based on <https://ironpdf.com/get-started/linux/>***

docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

```shell
# Retrieve the Docker image for IronPdfEngine from Iron Software's official repository

***Based on <https://ironpdf.com/get-started/linux/>***

docker pull ironsoftwareofficial/ironpdfengine

# Start the IronPdfEngine in a detached container

***Based on <https://ironpdf.com/get-started/linux/>***

docker run -d --publish 33350:33350 ironsoftwareofficial/ironpdfengine
```

Here's the paraphrased section with updated URL paths:


## Step 2: Configure Your Console Application

- Begin by creating a new console application designed for .NET 6.

- Proceed to add the IronPdf.Slim package from NuGet Package Manager to your project.

For further details on the deployment and usage of [IronPdfEngine](https://ironpdf.com/get-started/ironpdfengine-docker/), consult the linked guide.
```

## Compatibility with Additional Linux Distributions

For Linux systems that are not officially supported, IronPDF can still be utilized by manually installing the necessary prerequisites using package managers like **apt-get**, **hfs**, and **yum**. This flexibility permits the use of IronPDF across diverse Linux environments that aren’t directly listed as supported.

If encountering issues during the initial setup, IronPDF might generate exceptions to highlight missing system dependencies.

Within your application directory, the **IronCefSubprocess** binary is crucial for operation. You may need to identify its exact location, often found within the `runtimes` or `bin` directory. Furthermore, execution of some commands might require `sudo` access to ensure proper installation and configuration.

For users working with a Linux OS not mentioned in our documentation, a practical approach involves studying the Chromium browser's dependency requirements on your specific Linux distribution.

Should you need assistance or wish to see official support extended to other Linux distros, do not hesitate to reach out to us at [support@ironsoftware.com](mailto:support@ironsoftware.com).

### Standard Dependency Configurations for Linux

For other Linux operating systems not specifically listed, you can use the standard packages mentioned earlier in the document.

Below is the paraphrased section of the article, with the URLs resolved to `ironpdf.com`:

```sh
# Start by updating the package list and then install the required libraries

***Based on <https://ironpdf.com/get-started/linux/>***

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

# Set the correct permissions for IronCefSubprocess to allow it to run

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 IronCefSubprocess
# Reminder: Typically, the IronCefSubprocess binary is located in the bin/runtimes/linux-x64 folder

***Based on <https://ironpdf.com/get-started/linux/>***

```

### Diagnosing Missing Dependencies

The `ldd` utility is an effective tool for identifying missing dependencies in applications. When executing `ldd IronInterop.so`, this tool displays all required shared libraries for the application. If a library is missing, such as if you see a message like **libcef.so => not found**, it suggests that there's a vital dependency missing that could hinder the application from functioning properly. Typically, the `IronInterop.so` file can be found in the directory specific to the OS, such as **bin/Debug/net6.0/runtimes/linux-x64/native**.

```shell
# Analyzing the dependencies of IronInterop.so

***Based on <https://ironpdf.com/get-started/linux/>***

ldd IronInterop.so
```

### The IronCefSubprocess Binary

The `IronCefSubprocess` is a crucial binary located within the `bin` directory of your application. It is essential for the correct functioning of the application and must have executable permissions set for the .NET process to utilize it.

Here is the paraphrased section with updated paths:

```sh
# Update permission settings for IronCefSubprocess

***Based on <https://ironpdf.com/get-started/linux/>***

chmod 755 /bin/runtimes/linux-64/IronCefSubprocess
```

