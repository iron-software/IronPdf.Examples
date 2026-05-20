***Based on <https://ironpdf.com/get-started/installation-overview/>***

<style>
    .main-article {
        p {
            font: normal 400 16px/1.8 "Gotham-Book";
            color: #181818;
        }

```css
ol:not(.linenums):not(.breadcrumb) {
    li {
        font: normal 400 16px/1.8 "Gotham-Book";
    }
}

.related-link {
    strong {
        font: normal 700 16px/1.8 "Gotham-Bold";
    }

    a {
        font: normal 700 14px/1.4 "Gotham-Bold";
        color: #2A95D5;
        transition: all 0.2s ease;

        i {
            font-size: 12px;
        }

        &:has(i):hover {
            color: #E01A59;

            i {
                transform: translateX(4px);
            }
        }
    }
}

hr {
    height: 2px;
    background-color: #E7EEF0;
    color: #E7EEF0;
    margin-top: 40px;
    margin-bottom: 40px;
    border: none;
}

.code-content-with-cta {
    margin-top: 24px;

    h2 {
        display: none;
    }

    ol:not(.linenums):not(.breadcrumb) {
        list-style-type: none;

        li:not(:last-child) {
            display: none;
        }

        h3 {
            display: none;
        }

        .code-content-with-cta__cta-text {
            font: normal 400 15px/1.8 "Gotham-Book";
            color: #181818;
        }

        li:last-child {
            margin-top: 0;

            div {
                column-gap: 12px !important;
            }
        }
    }
}

h2[id^="anchor-"] {
    font: normal 900 20px/1.4 "Gotham-Black";
    color: #181818;
    padding-top: 0;
}

.classic-table {
    margin-top: 24px;
    border-collapse: separate;
    border-radius: 8px;
    border-spacing: 0;
    overflow: clip;

    &.hover-cell {
        td {
            a {
                transition: all 0.2s ease;
            }

            &:hover {
                a {
                    color: #E01A59;
                }
            }
        }
    }

    thead {
        tr {
            background-color: #FAFAFB;

            th {
                padding: 12px;
                text-align: center;
                border: 1px solid #D9E5E9;

                span {
                    font: normal 700 14px/1.4 "Gotham-Bold";
                    color: #181818;
                }
            }
        }
    }

    tbody {
        tr {
            td {
                padding: 16px 12px;
                border: 1px solid #D9E5E9;

                &:first-child {
                    text-align: center;
                }

                span, ul {
                    font: normal 400 14px/1.4 "Gotham-Book";
                    color: #181818;
                }

                a {
                    font: normal 700 14px/1.4 "Gotham-Bold";
                    color: #2A95D5;
                    text-decoration-line: underline;
                    text-decoration-color: rgba(42, 149, 213, 0.3);
                }
            }
        }
    }
}

.install-modes {
    margin-top: 35px;

    .install-mode {
        --border-color: #D9E5E9;
        --header-background: #FAFAFB;
        border: 2px solid var(--border-color);
        border-radius: 8px;
        background-color: #FFF;

        &.install-mode--recommended {
            --border-color: #63C1A0;
            --header-background: #F0FFFA;

            .install-mode__header {
                position: relative;

                .recommended-float {
                    position: absolute;
                    right: 0;
                    top: -45px;
                }
            }
        }

        .install-mode__header {
            padding: 12px;
            background-color: var(--header-background);
            display: flex;
            flex-direction: column;
            row-gap: 4px;
            border-bottom: 1px solid var(--border-color);
            border-top-left-radius: 8px;
            border-top-right-radius: 8px;

            .install-mode__title {
                font: normal 700 16px/1.6 "Gotham-Bold";
                color: #181818;
                text-align: center;
            }

            .install-mode__subtitle {
                font: normal 400 14px/1.4 "Gotham-Book";
                color: #181818;
                text-align: center;
            }
        }

        .install-mode__body {
            padding: 16px 12px;

            ul {
                font: normal 400 14px/1.8 "Gotham-Book";
                color: #181818;
                padding-left: 1rem;
            }
        }
    }
}

.deployment-scenarios {
    margin-top: 16px;

    .deployment-card {
        padding: 12px 16px;
        display: flex;
        align-items: center;
        column-gap: 12px;
        border-radius: 8px;
        border: 1px solid #E7EEF0;
        background-color: #FFF;
        cursor: pointer;
        transition: all 0.2s ease;

        &:hover {
            box-shadow: 0 4px 12px 0 rgba(24, 24, 24, 0.08);

            .deployment-card__info {
                .deployment-card__link {
                    color: #E01A59;
                }
            }
        }

        .deployment-card__icon {
            display: flex;
            align-items:center;
            justify-content: center;
        }

        .deployment-card__info {
            .deployment-card__title {
                font: normal 500 14px/1.6 "Gotham-Medium";
                color: #181818;
                margin-top: 0;
                margin-bottom: -2.4px;
            }

            .deployment-card__link {
                font: normal 700 14px/1.6 "Gotham-Bold";
                color: #2A95D5;
                transition: all 0.2s ease;

                i {
                    font-size: 12px;
                }
            }
        }
    }
}

#anchor-next-steps {
    margin-bottom: 24px;
}

.next-step__card {
    border-radius: 8px;
    border: 1px solid #E7EEF0;
    background: #FFF;
    padding: 24px;
    display: flex;
    flexDirection: column;
    row-gap: 32px;
    height: 100%;
    cursor: pointer;
    transition: transform 0.2s ease;

    &:hover {
        boxShadow: 0 4px 12px 0 rgba(24, 24, 24, 0.08);

        p {
            color: #E01A59;

            i {
                transform: translateX(4px);
            }
        }
    }

    .next-step__card-info {
        display: flex;
        flexDirection: column;
        row-gap: 16px;

        .next-step__card-icon {
            max-width: 40px;
            height: 32px;
            display: flex;
            alignItems: center;
            justifyContent: center;

            i {
                color: #678CB1;
                fontSize: 32px;
            }
        }

        .next-step__card-text {
            font: normal 700 15px/1.6 "Gotham-Bold";
            color: #181818;
        }
    }

    .next-step__card-cta {
        font: normal 700 14px/1.4 "Gotham-Bold";
        color: #2A95D5;
        marginTop: auto;
    }
}

.tutorials-navigation {
    display: flex;
    alignItems: center;
    justifyContent: spaceBetween;

    .tutorials-navigation__cta {
        display: flex;
        alignItems: center;
        column-gap: 8px;
        font: normal 500 16px/1.8 "Gotham-Medium";
        color: #181818;
        transition: color 0.2s ease;

        i {
            fontSize: 12px;
        }

        &:hover {
            color: #2A95D5;
        }
    }
}
```

</style>

# Installation Overview

A comprehensive guide to setting up and customizing IronPDF for all supported platforms.

Here's the paraphrased section of the article:

```cs
:title=Begin PDF Creation!
IronPdf.ChromePdfRenderer
       .RenderHtmlAsPdf("<p>Welcome to PDF generation!</p>")
       .SaveAs("PerfectPdfOutput.pdf");
```

<hr>

## 1. System Specifications

A comprehensive table detailing the necessary requirements for each platform that supports the IronPDF library.

<table class="classic-table hover-cell">
    <thead>
        <tr>
            <th><span>Platform</span></th>
            <th><span>.NET Version</span></th>
            <th><span>Hardware</span></th>
            <th><span>Additional Criteria</span></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="https://www.ironsoftware.com/static-assets/svgs/logo-table_windows.svg" width="64" height="64" alt="Windows Logo" />
                </div>
                <a href="https://www.ironsoftware.com/get-started/windows/">Windows</a>
            </td>
            <td rowspan="3"><span>Includes .NET 10, 9, 8, 7, 6, 5, as well as .NET Core, .NET Standard, and .NET Framework.</span></td>
            <td rowspan="3">
                <ul>
                    <li>Minimum: 1 Core & 1.75 GB RAM</li>
                    <li>Recommended: 2 Cores & 8 GB RAM or more</li>
                </ul>
            </td>
            <td>
                <ul>
                    <li>Windows 10, 11, and Windows Server editions</li>
                    <li>Requires Visual C++ Redistributable (x86 & x64)</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="https://www.ironsoftware.com/static-assets/svgs/logo-table_linux.svg" width="64" height="64" alt="Linux Logo" />
                </div>
                <a href="https://www.ironsoftware.com/get-started/linux/">Linux</a>
            </td>
            <td>
                <ul>
                    <li>Supported on 64-bit Linux OSs such as Ubuntu 22, 20, 18, 16; Debian 10-11; CentOS 8; Fedora Linux 33; Amazon AWS Linux 2</li>
                    <li>Requires IronCefSubprocess and Chrome dependencies</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="https://www.ironsoftware.com/static-assets/svgs/logo-table_mac.svg" width="64" height="64" alt="macOS Logo" />
                </div>
                <a href="https://www.ironsoftware.com/get-started/macos/">macOS</a>
            </td>
            <td><span>Compatible with all macOS versions released since 2020</span></td>
        </tr>
    </tbody>
</table>

<table class="classic-table hover-cell">
    <thead>
        <tr>
            <th><span>Platform</span></th>
            <th><span>.NET Version</span></th>
            <th><span>Hardware</span></th>
            <th><span>Additional Requirements, Compatibility</span></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="/static-assets/svgs/logo-table_windows.svg" width="64" height="64" alt="" />
                </div>
                <a href="/get-started/windows/">Windows</a>
            </td>
            <td rowspan="3"><span>.NET 10, 9, 8, 7, 6, 5, .NET Core, .NET Standard, and .NET Framework.</span></td>
            <td rowspan="3">
                <ul>
                    <li>Minimum: 1 Core & 1.75 GB of RAM</li>
                    <li>Recommended: 2 Cores & 8 GB of RAM or above</li>
                </ul>
            </td>
            <td>
                <ul>
                    <li>Windows 10, 11, and Windows Server</li>
                    <li>Visual C++ Redistributable (x86 & x64)</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="/static-assets/svgs/logo-table_linux.svg" width="64" height="64" alt="" />
                </div>    
                <a href="/get-started/linux/">Linux</a>
            </td>
            <td>
                <ul>
                    <li>64-bit Linux OSs: Ubuntu 22, Ubuntu 20, Ubuntu 18, Ubuntu 16, Debian 10-11m CentOS 8, Fedora Linux 33, Amazon, AWS, Linux 2</li>
                    <li>IronCefSubprocess</li>
                    <li>Chrome dependencies</li>
                </ul>
            </td>
        </tr>
        <tr>
            <td>
                <div class="d-flex align-items-center justify-content-center">
                    <img src="/static-assets/svgs/logo-table_mac.svg" width="64" height="64" alt="" />
                </div>
                <a href="/get-started/macos/">macOS</a>
            </td>
            <td><span>All macOS versions since 2020</span></td>
        </tr>
    </tbody>
</table>

<hr>

## Installation Options

IronPDF can be installed using two distinct strategies: Native Mode and Remote Engine Mode. Native Mode is recommended as the standard approach. However, for deployment on production servers that utilize Docker or Kubernetes, Remote Engine Mode is advisable.

<div class="row install-modes g-3">
    <div class="col-6">
        <div class="install-mode">
            <div class="install-mode__header">
                <span class="install-mode__title">Remote Engine Mode</span>
                <span class="install-mode__subtitle">Separate PDF processing via gRPC protocol.</span>
            </div>
            <div class="install-mode__body">
                <ul>
                    <li><strong>Best for:</strong> Cloud and containerized deployments, legacy OS support.</li>
                    <li><strong>Package:</strong> IronPdf.Slim</li>
                    <li><strong>Size:</strong> More lightweight, taking up a few MB. </li>
                    <li><strong>Requirements:</strong> Requires configuring the connection to host.</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="install-mode install-mode--recommended">
            <div class="install-mode__header">
                <span class="install-mode__title">Native Mode (Default)</span>
                <span class="install-mode__subtitle">Everything runs locally in your application</span>
                <div class="recommended-float">
                    <img src="/static-assets/svgs/float-recommended.svg" width="151" height="37.8" alt="" />
                </div>
            </div>
            <div class="install-mode__body">
                <ul>
                    <li><strong>Best for:</strong> Modern Windows, macOS, and Linux deployments.</li>
                    <li><strong>Package:</strong> Full IronPdf NuGet package.</li>
                    <li><strong>Size:</strong> Larger in size (hundreds of MBs), including Chrome and Pdfium binaries.</li>
                    <li><strong>Requirements:</strong> Works on modern operating systems.</li>
                </ul>
            </div>
        </div>
    </div>
</div>

<hr>

## 3. Installation Choices

The process of setting up the C# PDF library is swift and efficient—it can be accomplished in under five minutes. You can obtain it at no cost through NuGet or by direct download, allowing you to integrate it into your Visual Studio projects immediately.

<style>
    .installation-options__container {

```css
[data-active-tab="1"] {

    .installation-options__tab[data-tab="1"] {
        border-bottom: 3px solid #E01A59;

        span {
            font: normal 700 16px/1.2 "Gotham-Bold";
        }
    }

    .installation-options__info[data-tab="1"], .additional-configurations__info[data-tab="1"] {
        display: block;
    }
}

[data-active-tab="2"] {

    .installation-options__tab[data-tab="2"] {
        border-bottom: 3px solid #E01A59;

        span {
            font: normal 700 16px/1.2 "Gotham-Bold";
        }
    }

    .installation-options__info[data-tab="2"], .additional-configurations__info[data-tab="2"] {
        display: block;
    }
}

[data-active-tab="3"] {

    .installation-options__tab[data-tab="3"] {
        border-bottom: 3px solid #E01A59;

        span {
            font: normal 700 16px/1.2 "Gotham-Bold";
        }
    }

    .installation-options__info[data-tab="3"], .additional-configurations__info[data-tab="3"] {
        display: block;
    }
}

.installation-options__tabs {
    display: flex;
    align-items: center;
    gap: 24px;
    height: 34px;
    border-bottom: 1px solid #D9E5E9;

    .installation-options__tab {
        padding: 0 8px;
        height: 100%;
        cursor: pointer;
        white-space: nowrap;
        overflow: hidden;
        text-overflow: ellipsis;

        span {
            font: normal 500 16px/1.2 "Gotham-Medium";
            color: #181818;
        }
    }
}

.installation-options__info, .additional-configurations__info {
    display: none;
    padding: 24px 0;

    p:not(.related-link) {
        margin: 0;
        margin-bottom: 8px;

        a {
            font: normal 500 16px/1.8 "Gotham-Medium";
            color: #181818;
            text-decoration-line: underline;
            text-decoration-color: rgba(42, 149, 213, 0.3);
        }
    }
}
```

</style>

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1">
            <span>NuGet Package</span>
        </div>
        <div class="installation-options__tab" data-tab="2">
            <span>Manual Download</span>
        </div>
        <div class="installation-options__tab" data-tab="3">
            <span>Remote IronPdfEngine</span>
        </div>
    </div>
    <div class="installation-options__info" data-tab="1"></div>
    <div class="installation-options__info" data-tab="2"></div>
    <div class="installation-options__info" data-tab="3"></div>
</div>

<div id="nuget-package-start"></div>
Go to the [IronPDF NuGet library](/packages/IronPdf) (or Package Manager Console in Visual Studio)

Here's the paraphrased section with resolved URLs:

-----
1. Within Solution Explorer, perform a right-click on "References."

2. Choose 'Manage NuGet Packages', click 'Browse', then search for "IronPdf."

3. Choose the IronPdf package and proceed with the installation.

Here's the paraphrased section:

```shell
Install-Package IronPdf
```

<p class="related-link"><strong>RELATED:</strong> <a href="/get-started/advanced-installation-nuget/">More advanced IronPDF Nuget packages <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="nuget-package-end"></div>

<div id="manual-download-start"></div>
<ol>
    <li>Download IronPDF DLL package for your platform: Windows, Linux, macOS</li>
    <li>Unzip the ZIP file for your OS to a location within your Solution directory.</li>
    <li>In Visual Studio Solution Explorer, right-click on 'Dependencies.'</li>
    <li>'Add Project Reference' > Select 'Browse' to include all the DLLs extracted from the zip.</li>
</ol>
<div id="manual-download-end"></div>

<div id="remote-ironpdfengine-start"></div>
Please note: Each IronPDF release requires the matching version of IronPdfEngine. Cross-version support isn’t available. For example, IronPDF 2024.2.2 must use IronPdfEngine 2024.2.2.

```shell
:InstallCmd Install-Package IronPdf.Slim
```

Below is the paraphrased content for the specified section:

```shell
:InstallCmd Install-Package IronPdf.Slim
```

<div id="remote-ironpdfengine-end"></div>

## 4. Additional Configuration Options

This section outlines further customization options available after installing the IronPDF library, allowing for enhanced control and integration into your development environment.

### Managing Licenses

After obtaining your IronPDF license by purchase or a 30-day trial, locate the license key provided via email.

Insert the license key early in your application's lifecycle:

```csharp
IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";
```

To verify if your license activation is successful:

```csharp
bool isLicensed = IronPdf.License.IsLicensed;
```

### Path and Permissions Setup

It's crucial to specify the temporary folder path for IronPDF operations to ensure reliable performance:

```csharp
IronPdf.Installation.TempFolderPath = @"C:\My\Preferred\Temp";
```

Ensure routine maintenance of temporary directories across your development and production environments by clearing old files and deploying clean applications.

Adjust the environment variables related to the temporary path specifically for your application, which aids IronPDF in handling temporary files more efficiently:

```csharp
using IronPdf;

// Configuration for temporary paths
var MyTempPath = @"C:\Preferred\TempPath\";
Environment.SetEnvironmentVariable("TEMP", MyTempPath, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", MyTempPath, EnvironmentVariableTarget.Process);

// Configuring IronPDF's temporary folder path
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(MyTempPath, "IronPdfTemp");

// Sample PDF creation using the configured settings
var Renderer = new IronPdf.ChromePdfRenderer();
using var Doc = Renderer.RenderHtmlAsPdf("<h1>Custom HTML Content Here</h1>");
Doc.SaveAs("CustomPdfOutput.pdf");
```

If your server has restricted access, make sure that the user account under which your web server's IIS is running (typically IUSER) has necessary read-write permissions both at your specified installation path and the temporary files folder.

### Connecting to Remote IronPdfEngine

For setups involving the lightweight `IronPdf.Slim` package, ensure that you establish connectivity with your IronPdfEngine container early during the application's execution or prior to utilizing any specific IronPDF functionalities. Ensure that the version of IronPdfEngine matches the core IronPDF library version.

Example to configure connection to a remote IronPdfEngine instance:

```csharp
IronPdf.Installation.ConnectToIronPdfHost(
    new IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
);
```

Handling specific environments:

- **Linux Configuration:** Enable automatic configuration to install necessary dependencies when running IronPDF on Linux, which might cause the initial HTML-to-PDF conversion to take additional time:

    ```csharp
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
    ```

- **Docker Setup:** Pre-initialize the Chrome engine within Docker to mitigate the initial load time:

    ```csharp
    IronPdf.Installation.Initialize();
    ```

For expanded guidelines on these topics and to address potential limitations, explore related resources provided by IronPDF:

- [Learn about IronPDF Engine's limitations and compatibility on Linux with Docker](https://ironsoftware.com/get-started/ironpdfengine/#ironpdfengine-limitations)
- [Setup guide for IronPDF on Linux environments](https://ironsoftware.com/how-to/linux/)

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1">
            <span>Manage License</span>
        </div>
        <div class="installation-options__tab" data-tab="2">
            <span>Path & Permission</span>
        </div>
        <div class="installation-options__tab" data-tab="3">
            <span>Remote Engine</span>
        </div>
    </div>
    <div class="additional-configurations__info" data-tab="1"></div>
    <div class="additional-configurations__info" data-tab="2"></div>
    <div class="additional-configurations__info" data-tab="3"></div>
</div>

<div id="manage-license-start"></div>
After you’ve purchased or signed up for a 30-day trial of IronPDF, find the license key sent to your email.

To begin using your subscription or trial, enter the license key you received by email at the very start of your application's code.

Here's the paraphrased section of the article with resolved relative URL paths, focused on setting the IronPDF license key within a .NET application:

```csharp
// Assign your IronPDF license key to activate the product
IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY_HERE";
```

In this snippet, the placeholder `"YOUR_LICENSE_KEY_HERE"` should be replaced with the actual license key you've received after your purchase or during your trial period. This setup is essential for enabling all features without limitations.

Here’s how you can verify the licensing status of IronPDF in your application:

```csharp
bool isLicensed = IronPdf.License.IsLicensed;
```

Here is the paraphrased section of the article, with resolved URL paths:

```csharp
// Check if your IronPDF license is active and valid
bool licenseIsValid = IronPdf.License.IsLicensed;
```

<div id="manage-license-end"></div>

<div id="path-permission-start"></div>
Set the TempFolderPath property of the IronPdf.Installation object.

Here's a paraphrased version of the specific C# code snippet provided:

```csharp
// Setting the temporary folder path for IronPDF operations
IronPdf.Installation.TempFolderPath = @"C:\My\Secure\Directory";
```

Ensure that all temporary and cache folders are cleared on both your development environments and servers. Subsequently, redeploy a pristine version of your application whenever a path is updated.

Define the temporary folder environment variable across the entire scope of your application.

Here's the paraphrased section of the article:

```csharp
using IronPdf;

// Adjust the temporary file system path settings for your application to ensure proper operation
var temporaryDirectory = @"C:\Safe\Path\";
Environment.SetEnvironmentVariable("TEMP", temporaryDirectory, EnvironmentVariableTarget.Process);
Environment.SetEnvironmentVariable("TMP", temporaryDirectory, EnvironmentVariableTarget.Process);

// Configure the path for IronPDF's temporary file storage
IronPdf.Installation.TempFolderPath = System.IO.Path.Combine(temporaryDirectory, "IronPdf");

// Example of generating and editing a PDF document
var pdfRenderer = new IronPdf.ChromePdfRenderer();
using var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>");
pdfDocument.SaveAs("example.pdf");
```

This version maintains the same actions but slightly alters variable names and comments for clarity and variation.

In secure server environments, ensure that the IIS user (IUSER) is granted both read and write access to the directories where IronPDF is installed, as well as to the Windows and Temporary folders.

<div id="path-permission-end"></div>

<div id="remote-engine-start"></div>
**[Remote IronPdfEngine]** After installing the IronPdf.Slim package, connect to the engine container and configure the connection at app startup or before calling any IronPDF method.

Assuming that the IronPdfEngine is operational remotely at the IP `123.456.7.8` on port `33350`, you can establish a connection using the following configuration:

```csharp
Installation.ConnectToIronPdfHost(
    IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
);
```

For further discussions on the capabilities and limitations of the IronPdfEngine, please consult the [IronPdfEngine Limitations](https://ironpdf.com/get-started/ironpdfengine/#ironpdfengine-limitations) documentation.

To automate the installation of necessary dependencies on Linux systems, use this setting:

```csharp
Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

When deploying IronPDF within a Docker environment, it’s efficient to pre-initialize the Chrome engine to ensure faster performance during the first use:

```csharp
IronPdf.Installation.Initialize();
```

For additional information on setting up IronPDF with Linux and Docker environments, visit [IronPDF Linux Docker Compatibility and Setup](https://ironpdf.com/how-to/linux/).

Here's the paraphrased section of the article with resolved URLs where necessary:

```csharp
// Establish a connection to a remote IronPDF server using gRPC
IronPdf.GrpcLayer.IronPdfConnectionConfiguration
    .Connect("123.456.7.8:33350");  // Remote server IP and port
```

<p class="related-link"><strong>RELATED:</strong> <a href="/get-started/ironpdfengine/#ironpdfengine-limitations">IronPdfEngine Limitations <i class="fa-solid fa-arrow-right"></i></a></p>

**[Linux]** Activate the automatic installation feature for all necessary Linux dependencies in IronPDF. Be prepared for the initial HTML-to-PDF conversion to take a bit longer than normal.

Here's the paraphrased section:

```csharp
// Automatically configure dependencies needed by Linux and Docker
Installation.LinuxAndDockerDependenciesAutoConfig = true;
```

**[Docker]** To enhance startup performance in Docker environments, pre-initialize the Chrome engine, ensuring that all necessary components are loaded beforehand. This preparation reduces initial launch times significantly.
```

Here is the paraphrased section of the article, with the URL path resolved:

-----
```csharp
// Initialize IronPDF settings before usage
IronPdf.Installation.Initialize();
```

<p class="related-link"><strong>RELATED:</strong> <a href="/how-to/linux/">IronPDF Linux Docker Compatibility and Setup <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="remote-engine-end"></div>

<hr>

## 5. Deployment Scenarios

Here are various environments where IronPDF .NET can be seamlessly deployed:

<div class="row deployment-scenarios g-4">
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-azure.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Execute & Deploy IronPDF .NET on</p>
                <a href="https://ironpdf.com/get-started/azure/" class="deployment-card__link">Azure Function <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-aws.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Execute & Deploy IronPDF .NET on</p>
                <a href="https://ironpdf.com/get-started/aws/" class="deployment-card__link">AWS Lambda <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-linux.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Operate IronPDF in</p>
                <a href="https://ironpdf.com/get-started/ironpdf-docker/" class="deployment-card__link">Linux Docker Container <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-remote.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Operate IronPDF as a</p>
                <a href="https://ironpdf.com/get-started/ironpdfengine-docker/" class="deployment-card__link">Remote Container <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div>

<hr>

<div class="row deployment-scenarios g-4">
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="/static-assets/svgs/logo-azure.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Run & Deploy IronPDF .NET on</p>
                <a href="/get-started/azure/" class="deployment-card__link">Azure Function <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="/static-assets/svgs/logo-aws.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Run & Deploy IronPDF .NET on</p>
                <a href="/get-started/aws/" class="deployment-card__link">AWS Lambda <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="/static-assets/svgs/logo-linux.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Run IronPDF in</p>
                <a href="/get-started/ironpdf-docker/" class="deployment-card__link">Linux Docker Container <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
    <div class="col-6">
        <div class="deployment-card">
            <div class="deployment-card__icon">
                <img src="/static-assets/svgs/logo-remote.svg" width="64" height="64" alt="" />
            </div>
            <div class="deployment-card__info">
                <p class="deployment-card__title">Run IronPDF as a</p>
                <a href="/get-started/ironpdfengine-docker/" class="deployment-card__link">Remote Container <i class="fa-solid fa-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div>

<hr>

## Upcoming Actions

Explore the steps you can take next to expand your knowledge and utilization of IronPDF:

<div class="row g-3">
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/tutorials/html-to-pdf/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-graduation-cap"></i>
                </div>
                <span class="next-step__card-text">Complete HTML to PDF C# Tutorial</span>
            </div>
            <p class="next-step__card-cta">Explore the Tutorial <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/product-updates/changelog/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-solid fa-clock-rotate-left"></i>
                </div>
                <span class="next-step__card-text">Latest Updates, Milestones & Future Plans</span>
            </div>
            <p class="next-step__card-cta">Review Product Updates <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/troubleshooting/engineering-request-pdf/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-wrench"></i>
                </div>
                <span class="next-step__card-text">Engineering Support and Technical Help</span>
            </div>
            <p class="next-step__card-cta">Get Troubleshooting Help <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
</div>

<hr>

Discover more resources and guides to enhance your IronPDF implementation and troubleshooting skills.

<div class="row g-3">
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/tutorials/html-to-pdf/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-graduation-cap"></i>
                </div>
                <span class="next-step__card-text">Complete Guide on HTML to PDF C#</span>
            </div>
            <p class="next-step__card-cta">See Tutorial <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/product-updates/changelog/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-solid fa-clock-rotate-left"></i>
                </div>
                <span class="next-step__card-text">Changelog: Updates, milestones, roadmap</span>
            </div>
            <p class="next-step__card-cta">See Product Updates <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/troubleshooting/engineering-request-pdf/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-wrench"></i>
                </div>
                <span class="next-step__card-text">Request Engineering Support</span>
            </div>
            <p class="next-step__card-cta">See Troubleshooting <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
</div>

<hr>

<div class="tutorials-navigation">
    <a href="/get-started/quickstart/" class="tutorials-navigation__cta tutorials-navigation__cta--left">
        <i class="fa-solid fa-chevron-left"></i>Quickstart Guide
    </a>
    <a href="/get-started/ironpdfengine/" class="tutorials-navigation__cta tutorials-navigation__cta--right">
        Native vs Remote Engine<i class="fa-solid fa-chevron-right"></i>
    </a>
</div>

<script>
    window.addEventListener("DOMContentLoaded", () => {
        const mainArticle = document.querySelector(".main-article");

        if (mainArticle) {
            // Installation Options
            appendChildrenToTab(mainArticle, "nuget-package-start", "nuget-package-end", "installation-options__info", 1);

            appendChildrenToTab(mainArticle, "manual-download-start", "manual-download-end", "installation-options__info", 2);

            appendChildrenToTab(mainArticle, "remote-ironpdfengine-start", "remote-ironpdfengine-end", "installation-options__info", 3);

            // Additional Configurations
            appendChildrenToTab(mainArticle, "manage-license-start", "manage-license-end", "additional-configurations__info", 1);

            appendChildrenToTab(mainArticle, "path-permission-start", "path-permission-end", "additional-configurations__info", 2);

            appendChildrenToTab(mainArticle, "remote-engine-start", "remote-engine-end", "additional-configurations__info", 3);

            // Switch tab 
            mainArticle.addEventListener("click", (evt) => {
                const clickedTab = evt.target.closest(".installation-options__tab");

                if (clickedTab) {
                    const container = clickedTab.closest(".installation-options__container");

                    if (container) {
                        container.dataset.activeTab = clickedTab.dataset.tab;
                    }
                }
            });
        }
    });

    function getNodesBetweenMarkers(root, startText, endText) {
        const walker = document.createTreeWalker(root, NodeFilter.SHOW_ELEMENT);

        let start = null, end = null, n;

        while((n = walker.nextNode())) {
            if (!start && n.id === startText) start = n;
            else if (start && n.id === endText) { end = n; break; }
        }

        if (!start 
 !end) return [];

        const between = [];

        for (let cur = start.nextSibling; cur && cur !== end; cur = cur.nextSibling) {
            if (cur.nodeType === Node.ELEMENT_NODE) between.push(cur);
        }

        return between;
    }

    function appendChildrenToTab(mainArticle, start, end, className, tabId) {
        const kids = getNodesBetweenMarkers(mainArticle, start, end);

            if (kids.length > 0) {
                const tab = mainArticle.querySelector(`.${className}[data-tab="${tabId}"]`);

                if (tab) {
                    kids.forEach(kid => tab.appendChild(kid));
                }
            }

    }
</script>

