# IronPDF License Keys

***Based on <https://ironpdf.com/get-started/license-keys/>***


## Acquiring a License Key

Obtaining an IronPDF license key enables you to freely develop and launch your projects in a live environment without any limitations.

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

<hr class="separator">

## Step 1: Download the Latest Version of IronPDF

### Installation via NuGet

Open Visual Studio, navigate to your project in the Solution Explorer, and choose "Manage NuGet Packages...". Search for IronPDF and proceed to install the newest version. Accept any prompts that appear.

This is compatible with any C# .NET Framework project from version 4.6.2 onwards, .NET Core 2.0 or later, and it is also suitable for VB.NET projects.

```shell
/Install-Package IronPdf
```

[IronPDF on NuGet](https://www.nuget.org/packages/IronPdf)

### Manual Installation via DLL

You can also opt to download the IronPDF DLL and integrate it directly into your project or the Global Assembly Cache from [IronPDF Packages](https://ironpdf.com/packages/IronPdf.zip).

Include the following using directive in any `.cs` file that utilizes IronPDF:

```csharp
using IronPdf;
```

---

## Step 2: Implement Your License Key

### Coding the license key into your application

To set up your IronPDF license key, insert the following code at the beginning of your application's execution. This is a simple and universally effective method applicable to both .NET Core and .NET Framework applications.

```csharp
// Initialize the IronPdf license key
IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";
```

Confirm the licensing status using `IronPdf.License.IsValidLicense(string LicenseKey)` or `IronPdf.License.IsLicensed` property.

### Embedding your key in Web.Config or App.Config for .NET Framework Applications

For a global application-wide license key in .NET Framework, add your license details in the `<appSettings>` section of your configuration file:

```xml
<configuration>
  <appSettings>
    <add key="IronPdf.LicenseKey" value="IRONPDF-MYLICENSE-KEY-1EF01"/>
  </appSettings>
</configuration>
```

Please note an ongoing issue with IronPdf versions from [2023.4.4](https://www.nuget.org/packages/IronPdf/2023.4.4) to [2024.3.3](https://www.nuget.org/packages/IronPdf/2024.3.3) affecting:

- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

License keys in `Web.config` are not being recognized. More details can be found in the '[Setting License Key in Web.config](https://ironpdf.com/troubleshooting/license-key-web.config/)' help article.

Ensure `IronPdf.License.IsLicensed` returns `true` to confirm proper setup.

### Configuring your key in a .NET Core appsettings.json file

For global licensing in a .NET Core application:

* Create an `appsettings.json` file at the root of your project.
* Add an 'IronPdf.LicenseKey' entry with your license key as its value.
* Change the file properties to *Copy to Output Directory: Copy always*.
* Verify by checking if `IronPdf.License.IsLicensed` returns `true`.

File: `appsettings.json`
```json
{
  "IronPdf.LicenseKey": "IRONPDF-MYLICENSE-KEY-1EF01"
}
```

### Licensing in Azure Functions

#### Locally

Insert the license key into `local.settings.json`:

```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "IronPdf.LicenseKey": "YOUR-LICENSE-KEY"
  }
}
```

#### During Deployment

1. Log into the Azure portal and search for your function app in the top search bar, selecting it from the results.
2. In the left pane under Settings, choose Configuration.
3. Click on Application settings then select "New Application setting".
4. Enter the details as follows:

   - `Name`: IronPdf.LicenseKey
   - `Value`: YOUR-LICENSE-KEY

5. Click Save.

---

## Step 3: Verify Your License Installation

```csharp
// Validate the IronPDF license key
bool result = IronPdf.License.IsValidLicense("IRONPDF-MYLICENSE-KEY-1EF01");

// Confirm IronPDF is properly licensed
bool is_licensed = IronPdf.License.IsLicensed;
```

*Remember:* Always clean and republish your application after configuring the license to prevent potential deployment issues.

---

## Step 4: Begin Your Project

Explore our guide on [Getting Started with IronPDF](https://ironpdf.com/docs/).

---

## Need Assistance?

For further inquiries, contact [support@ironsoftware.com](mailto:support@ironsoftware.com).