# Advanced Installation of IronPDF

***Based on <https://ironpdf.com/how-to/advanced-installation-nuget/>***


From IronPDF Release v2022.1 onward, there are more specialized methods to install IronPDF for particular environments.

Rather than opting for the general `IronPDF` NuGet package, NuGet now hosts specialized IronPDF packages tailored to specific development scenarios. While the API interface remains consistent, the deployment strategies are distinct.

Notably, you can utilize a platform-specific package such as IronPdf.Linux for an optimized deployment on Linux, yet still carry on development on your usual operating system like Windows using Visual Studio!

## IronPdf General NuGet Package

<img src="https://ironpdf.com/img/icons8-windows-72-000000-nuget.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-linux--v1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-docker.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-fluency-72-000000-azure-1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-amazon-web-services.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-ubuntu--v1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-mac-client.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-windows-logo.png" style="display:inline"/>

This is the most commonly utilized package, designed to fast-track your setup in Visual Studio. It's apt for the majority of projects.

[**Download IronPdf NuGet Package**](https://www.nuget.org/packages/IronPdf/)
- Includes `IronPdf.Slim`
- Carries Windows-specific dependencies for the Chrome (default) renderer
- This default package automatically downloads Windows-specific dependencies during runtime
- Primarily uses Chrome as the renderer
- Compatible with all platforms, although it is optimized for Windows without needing extra downloads

## IronPdf.Slim NuGet Package

<img src="https://ironpdf.com/img/icons8-color-72-000000-cloud-backup-restore.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-fluency-72-000000-azure-1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-windows-72-000000-nuget.png" style="display:inline" />

Perfect for applications requiring minimal disk space or those being distributed across various operating systems. The exact Chromium/WebKit rendering engine will be downloaded dynamically on the target machine upon execution.

[**Download IronPdf.Slim NuGet Package**](https://www.nuget.org/packages/IronPdf.Slim/)
- References all other packages
- Includes the primary `IronPdf.dll`
- Does not contain platform-specific dependencies initially
- Dependencies for Windows, Linux, or macOS are automatically downloaded at runtime
- Preset to use Chrome renderer across all platforms
- Ideal for cross-platform applications that fetch platform-specific dependencies on-the-fly

## IronPdf.Linux NuGet Package

<img src="https://ironpdf.com/img/icons8-color-72-000000-linux--v1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-debian.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-ubuntu.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-centos.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-windows-72-000000-nuget.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-fluency-72-000000-azure-1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-amazon-web-services.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-docker.png" style="display:inline" />

Ideal for [Deploying IronPdf on Linux](https://ironpdf.com/how-to/linux/). Cloud-optimized and performs excellently on AWS & Lambda, Azure Functions and Linux WebApps.

[**Download IronPdf.Linux NuGet Package**](https://www.nuget.org/packages/IronPdf.Linux/)
- Includes `IronPdf.Slim`
- Contains Linux-specific dependencies for the Chrome renderer

## IronPdf macOS NuGet Packages

<img src="https://ironpdf.com/img/icons8-color-72-000000-mac-client.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-windows-72-000000-nuget.png" style="display:inline" />

Available specific packages for deploying [IronPdf on macOS](https://ironpdf.com/how-to/macos/).

[**Download IronPdf.MacOs NuGet Package**](https://www.nuget.org/packages/IronPdf.MacOs/)

[**Download IronPdf.MacOs.ARM NuGet Package**](https://www.nuget.org/packages/IronPdf.MacOs.ARM/)

- Includes `IronPdf.Slim`
- Packs Mac-specific dependencies for the Chrome renderer

## IronPdf.Classic NuGet Package

<img src="https://ironpdf.com/img/icons8-office-72-000000-time-machine--v1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-linux--v1.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-mac-client.png" style="display:inline" />
<img src="https://ironpdf.com/img/icons8-color-72-000000-windows-logo.png" style="display:inline"/>
<img src="https://ironpdf.com/img/icons8-windows-72-000000-nuget.png" style="display:inline" />

This package supports legacy customers who started using IronPDF before August 2021 and prefer their HTML to PDF conversion process remains unchanged. This leverages our classic 2020-2021 WebKit renderer.

[**Download IronPdf.Classic NuGet Package**](https://www.nuget.org/packages/IronPdf.Classic/)
- Contains both `IronPdf.Slim` and `IronPdf.Native.WebKit`
- Includes all platform dependencies for the WebKit renderer