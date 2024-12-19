# IronPDF Licensing Guide

***Based on <https://ironpdf.com/how-to/license-keys/>***


## Obtaining Your License Key

Securing an IronPDF license key lets you shift your project from development to production seamlessly.

You can [purchase a license key](https://ironpdf.com/licensing/) or [obtain a 30-day trial key for free](https://ironpdf.com/trial-license).

--------------------------------------------------------------------------------

## Step 1: Installing the Latest IronPDF Version

### Installation via NuGet

Using Visual Studio, right-click on your project in the solution explorer and opt for "Manage NuGet Packages...". Search and install IronPDF by confirming any prompts that appear.

This method supports C# projects on .NET Framework 4.6.2 and newer, .NET Core 2.0 and above, as well as VB.NET projects.

```shell
# Install the IronPdf package using NuGet package manager

***Based on <https://ironpdf.com/how-to/license-keys/>***

Install-Package IronPdf
```

[View IronPdf on NuGet](https://www.nuget.org/packages/IronPdf)

### Manual Installation via DLL

Download and manually add the IronPDF DLL to your project or the Global Assembly Cache from [https://ironpdf.com/packages/IronPdf.zip](https://ironpdf.com/packages/IronPdf.zip)

Include the following statement at the beginning of any **cs** class file that uses IronPDF:

```csharp
using IronPdf;
```

--------------------------------------------------------------------------------

## Step 2: Activate Your License Key

### Coding in the License Key

Early in your application's lifecycle, before utilizing IronPDF, insert the following code to activate your license. This approach is reliable across both .NET Core and .NET Framework applications.

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

To confirm your license's activation, you can use `IronPdf.License.IsValidLicense(string LicenseKey)` or check the `IronPdf.License.IsLicensed` property.

### Applying Key with Web.Config or App.Config in .NET Framework

For a global application scope in .NET Framework, insert your license key into your configuration file within the `<appSettings>` section.

```xml
<configuration>
  <appSettings>
    <add key="IronPdf.LicenseKey" value="IRONPDF-MYLICENSE-KEY-1EF01"/>
  </appSettings>
</configuration>
```

Notice an issue with .NET Framework versions >= 4.6.2 in ASP.NET projects where the key in `Web.config` might not be recognized. Visit the '[Setting License Key in Web.config](https://ironpdf.com/troubleshooting/license-key-web.config/)' guide for assistance.

### Applying Key in .NET Core with appsettings.json

For .NET Core applications:

- Introduce a `appsettings.json` in your project's root.
- Insert 'IronPdf.LicenseKey' key with your license key as the value.
- Set file properties to _Copy to Output Directory: Copy always_.
- Check if `IronPdf.License.IsLicensed` returns `true`.

Example content of `appsettings.json`:

```json
{

    "IronPdf.LicenseKey":"IRONPDF-MYLICENSE-KEY-1EF01"

}
```

### Azure Functions Licensing

#### Local Setup

Insert your license key in `local.settings.json`:

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

#### During Deployment

In Azure portal:

1. Search and select your function app.
2. Navigate to Settings > Configuration.
3. Add a new application setting with the license key:

    ```txt
    Name - IronPdf.LicenseKey
    Value - YOUR-LICENSE-KEY
    ```

4. Save the configuration.

--------------------------------------------------------------------------------

## Step 3: Verify the License Installation

```csharp
// Validate the provided license key
bool result = IronPdf.License.IsValidLicense("IRONPDF-MYLICENSE-KEY-1EF01");

// Confirm if IronPDF is correctly licensed
bool is_licensed = IronPdf.License.IsLicensed;
```

_Reminder:_ Always clean and republish your application after licensing to avoid deployment errors.

--------------------------------------------------------------------------------

## Step 4: Begin Your Project

Explore our [Starting Guide with IronPDF](https://ironpdf.com/docs/).

--------------------------------------------------------------------------------

## Need Assistance?

For further inquiries, contact <support@ironsoftware.com>.