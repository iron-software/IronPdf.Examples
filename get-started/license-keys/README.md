# IronPDF Licensing Process

***Based on <https://ironpdf.com/get-started/license-keys/>***


## Acquiring a License Key

Utilizing a license key with IronPDF enables you to develop and launch your applications without any deployment restrictions.

---

## Step 1: Obtain the Newest IronPDF Release

### Install using NuGet

Within Visual Studio, navigate to the solution explorer, right-click your project, and opt for "Manage NuGet Packages...". Then, search for "IronPDF" and proceed to install the most recent version, accepting any prompts that appear.

This procedure is applicable to any C# .NET Framework starting from version 4.6.2, as well as .NET Core 2.0 and above. This installation is equally effective in VB.NET projects.

```shell
Install-Package IronPdf
```

Access IronPDF on NuGet at: [https://www.nuget.org/packages/IronPdf](https://www.nuget.org/packages/IronPdf)

### Manual Installation via DLL

If preferred, you can directly download the IronPDF DLL and manually integrate it into your project or the Global Assembly Cache (GAC) from [https://ironpdf.com/packages/IronPdf.zip](https://ironpdf.com/packages/IronPdf.zip).

It's necessary to include the following at the top of any C# class file that utilizes IronPDF:

```cs
using IronPdf;
```

---

## Step 2: Activate Your License Key

### Code Activation

To activate, enter the following command at the start of your application before calling any IronPDF methods. This applies to both .NET Core and .NET Framework platforms.

```cs
IronPdf.License.LicenseKey = "YOUR-LICENSE-KEY-HERE";
```

To verify the activation, use `IronPdf.License.IsValidLicense("YOUR-LICENSE-KEY-HERE")` or check the `IronPdf.License.IsLicensed` property.

### Config File Activation in .NET Framework

Globally apply your license via the Web.Config or App.Config by adding this entry within the `<appSettings>` section:

```xml
<configuration>
  ...
  <appSettings>
    <add key="IronPdf.LicenseKey" value="YOUR-LICENSE-KEY-HERE"/>
  </appSettings>
  ...
</configuration>
```

Note a licensing issue observed in IronPdf versions from [2023.4.4](https://www.nuget.org/packages/IronPdf/2023.4.4) to [2024.3.3](https://www.nuget.org/packages/IronPdf/2024.3.3) in ASP.NET projects using .NET Framework version 4.6.2 and up. The license key might not be recognized if placed in a `Web.config` file. Learn more at the '[Setting License Key in Web.config](https://ironpdf.com/troubleshooting/license-key-web.config/)' guide.

### JSON Configuration in .NET Core

For a global setting in .NET Core projects, involve the key in the project's root `appsettings.json` file and set it to copy always:

File: *appsettings.json*
```json
{
	"IronPdf.LicenseKey": "YOUR-LICENSE-KEY-HERE"
}
```

### Azure Functions Setup

**Local Configuration:**

Insert into your `local.settings.json`:

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

**For Deployment:**

Navigate to your Azure portal, find and select your function app. Under Settings, click on Configuration, then Application settings, and add a new application setting:

  - `Name: IronPdf.LicenseKey`
  
  - `Value: YOUR-LICENSE-KEY`

Save changes.

---

## Step 3: Confirm License Installation

```cs
// Validates the license key
bool result = IronPdf.License.IsValidLicense("YOUR-LICENSE-KEY-HERE");

// Checks if IronPDF is licensed
bool is_licensed = IronPdf.License.IsLicensed;
```

*Note:* After incorporating a license, always ensure to clean and republish your application to prevent deployment errors.

---

## Step 4: Begin Your Project

Follow our guides on how to [Start Using IronPDF](https://ironpdf.com/docs/).

---

## Need Help?

If you have any inquiries, contact us via [support@ironsoftware.com](mailto:support@ironsoftware.com).