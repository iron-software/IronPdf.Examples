# IronPDF License Keys

## Obtaining a License Key

To enhance your project with IronPDF licensing, enabling unrestricted development and deployment, consider acquiring a license.

Secure your license through [this link](https://ironpdf.com/licensing/) or obtain a [free 30-day trial key](https://ironpdf.com/trial-license).

---

## Step 1: Acquire the Most Recent Version of IronPDF

### Installation via NuGet

Within Visual Studio, click on your project in the solution explorer and choose "Manage NuGet Packages..." Search for IronPDF, select it, and proceed with the installation by accepting any prompts.

This installation method is compatible with any C# .NET projects using Framework version 4.6.2 or higher and .NET Core version 2 or higher, as well as VB.NET projects.

```shell
Install-Package IronPdf
```

Explore more details at [NuGet IronPDF page](https://www.nuget.org/packages/IronPdf).

### Installation via DLL

For manual setups, the IronPDF DLL can be integrated directly into your project or GAC from this [downloadable link](https://ironpdf.com/packages/IronPdf.zip).

Don't forget to include IronPDF in your code files:

```csharp
using IronPdf;
```

---

## Step 2: Activate Your License Key

### Integrating Your License Key Via Code

Implement the license key at the start of your application, before employing any IronPDF functionality. This method is universally applicable to both .NET Core and .NET Framework applications.

```csharp
IronPdf.License.LicenseKey = "YOUR-LICENSE-KEY";
```

To verify licensing, you can use `IronPdf.License.IsValidLicense(string LicenseKey)` or check the `IronPdf.License.IsLicensed` property.

### Configuration File Method in .NET Framework Applications

Globally configure your license key using the Web.Config or App.Config by inserting the following in your `<appSettings>`:

```xml
<configuration>
....
  <appSettings>
    <add key="IronPdf.LicenseKey" value="YOUR-LICENSE-KEY"/>
  </appSettings>
....
</configuration>
```

Please note the licensing compatibility issues affecting versions from [2023.4.4 to 2024.3.3](https://www.nuget.org/packages/IronPdf/2024.3.3) of IronPdf in ASP.NET projects using .NET Framework version 4.6.2 and above where `Web.config` keys aren't recognized. For more on this issue, refer to the [Troubleshooting License Key Integration](https://ironpdf.com/troubleshooting/license-key-web.config/).

### Incorporating Your Key in a .NET Core appsettings.json file

For a global application-wide license key setup in .NET Core:

1. Create an `appsettings.json` in the project's root.
2. Insert your license key as shown below, and set *Copy to Output Directory* as *Copy always*.
3. Confirm the license activation with `IronPdf.License.IsLicensed`.

```json
{
	"IronPdf.LicenseKey": "YOUR-LICENSE-KEY"
}
```

### License Key Setup in Azure Functions

#### For Local Development

Enter the following in your `local.settings.json`:

```json
{
  "IsEncrypted": false,
  "Values":
  {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "IronPdf.LicenseKey": "YOUR-LICENSE-KEY"
  }
}
```

#### For Deployment

1. Navigate to your function app via the Azure portal.
2. Select Configuration under Settings.
3. Click New Application setting in Application settings.
4. Provide Name as `IronPdf.LicenseKey` and your license as the Value.
5. Commit your changes with a Save.

---

## Step 3: Verify Correct License Key Installation

```csharp
// Validates the specified license key.
bool result = IronPdf.License.IsValidLicense("YOUR-LICENSE-KEY");

// Confirmation if IronPDF is appropriately licensed 
bool is_licensed = IronPdf.License.IsLicensed;
```

*Note:* Post-license key configuration, it's crucial to clean and republish your application to minimize deployment errors.

---

## Step 4: Start Building Your Project

Embark on your project with our comprehensive guide: [Getting Started with IronPDF](https://ironpdf.com/docs/).

---

## Need Help?

Do not hesitate to contact us at [support@ironsoftware.com](mailto:support@ironsoftware.com) for any inquiries.