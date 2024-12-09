# IronPDF License Activation

***Based on <https://ironpdf.com/get-started/license-keys/>***


## Obtaining a License Key

To fully enable your development and live project deployment with IronPDF, you'll need a proper license key.

Purchase a license directly [here](https://ironpdf.com/licensing/) or [sign up for a free 30-day trial key](#trial-license).

---

## Step 1: Acquiring the Latest IronPDF Release

### Install Using NuGet

Launch Visual Studio, navigate to your project in the Solution Explorer, right-click, and choose "Manage NuGet Packages...". Search for IronPDF and proceed to install the most current version. Approve any subsequent prompts that appear.

This installation method is compatible with all C# .NET Framework projects from version 4.6.2 onwards and .NET Core 2 or higher. It is equally viable for use in VB.NET projects.

```shell
Install-Package IronPdf
```

Visit the NuGet page for IronPDF [here](https://www.nuget.org/packages/IronPdf).

### Install Using DLL

For manual installation, the IronPDF DLL can be added to your project or the Global Assembly Cache (GAC) [here](https://ironpdf.com/packages/IronPdf.zip)

It's important to include this line at the beginning of any C# class files that utilize IronPDF:

```cs
using IronPdf;
```

---

## Step 2: Applying Your License Key

### Code-Based License Key Setting

Early in your application's startup routine, before using IronPDF, insert the following code. This approach is effective across both .NET Core and .NET Framework applications.

```cs
IronPdf.License.LicenseKey = "YOUR-LICENSE-KEY";
```

To confirm that your application is properly licensed, either use `IronPdf.License.IsValidLicense(string LicenseKey)` or check the `IronPdf.License.IsLicensed` property.

### Using Web.Config or App.Config in .NET Framework Applications

For a global application key, modify your configuration file as shown below:

```xml
<configuration>
  <appSettings>
    <add key="IronPdf.LicenseKey" value="YOUR-LICENSE-KEY"/>
  </appSettings>
</configuration>
```

Note the licensing conflict between IronPdf versions [2023.4.4](https://www.nuget.org/packages/IronPdf/2023.4.4) and [2024.3.3](https://www.nuget.org/packages/IronPdf/2024.3.3) in certain ASP.NET and .NET Framework projects; refer to the [Web.config Licensing Issues](https://ironpdf.com/troubleshooting/license-key-web.config/) for more details.

### Applying a Key in .NET Core via appsettings.json

To set a global key in a .NET Core application:

- Include an `appsettings.json` in your project's root directory.
- Make sure 'IronPdf.LicenseKey' is included in the JSON configuration.
- Set the file properties to *Copy to Output Directory: Copy always*.

Verify using `IronPdf.License.IsLicensed`.

Example `appsettings.json`:

```json
{
  "IronPdf.LicenseKey": "YOUR-LICENSE-KEY"
}
```

### Azure Functions Licensing

#### Local Setup

Include the license in `local.settings.json`:

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

#### Deployment Procedure

1. Access your Azure portal and locate your function app.
2. Navigate to Settings > Configuration.
3. Add a new application setting with `Name` as `IronPdf.LicenseKey` and `Value` as `YOUR-LICENSE-KEY`.
4. Save the changes.

---

## Step 3: Verification of Key Installation

```cs
// Verify the validity of the license key
bool isKeyValid = IronPdf.License.IsValidLicense("YOUR-LICENSE-KEY");

// Confirm if IronPDF is fully licensed
bool isLicensed = IronPdf.License.IsLicensed;
```

*Note:* Always clean and republish your application after license modification to avoid deployment errors.

---

## Step 4: Beginning Your Project

Refer to our [Getting Started Guide](https://ironpdf.com/docs/) for detailed instructions.

---

## Need Help?

For additional support, contact [support@ironsoftware.com](mailto:support@ironsoftware.com).