# IronPDF License Keys

***Based on <https://ironpdf.com/how-to/license-keys/>***


Acquiring an IronPDF license key enhances your ability to take your project from development to production without any limitations.

You can [purchase a license key here](https://ironpdf.com/licensing/) or begin with a [free 30-day trial key](https://ironpdf.com/trial-license).

---

## Step 1: Download the Latest Version of IronPDF

### Install via NuGet

Within Visual Studio, right-click on the project in the solution explorer and choose "Manage NuGet Packages...". Search for IronPDF and proceed to install the newest version. Accept any prompts that appear.

This method is compatible with C# .NET Framework versions starting from 4.6.2 and all .NET Core versions beginning from 2.0, as well as VB.NET projects.

```shell
Install-Package IronPdf
```

[View on NuGet](https://www.nuget.org/packages/IronPdf)

### Install via DLL

You can also opt to manually download and integrate the IronPDF DLL into your project or the Global Assembly Cache (GAC) from [IronPDF ZIP package](https://ironpdf.com/packages/IronPdf.zip).

Ensure you include the following using directive at the beginning of any `.cs` file that utilizes IronPDF:

```csharp
using IronPdf;
```

--------------------------------------------------------------------------------

## Step 2: Apply Your License Key

### Set your IronPDF license key programmatically

Incorporate this code snippet at the beginning of your application's lifecycle, prior to any IronPDF utilization. This setting is equally effective in .NET Core and .NET Framework.

```csharp
// Assign the IronPDF license key
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

Check if the software is properly licensed either by using `IronPdf.License.IsValidLicense(string LicenseKey)` method or checking the `IronPdf.License.IsLicensed` property.

### Configure your key using Web.Config or App.Config in .NET Framework Applications

For a system-wide key application in .NET Framework, insert the following lines in your config file under the `<appSettings>` section.

```xml
<configuration>
  ...
  <appSettings>
    <add key="IronPdf.LicenseKey" value="IRONPDF-MYLICENSE-KEY-1EF01"/>
  </appSettings>
  ...
</configuration>
```

There's a licensing compatibility issue between IronPdf versions 2023.4.4 and 2024.3.3 in:

- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

The key from a `Web.config` isn't recognized. Visit the '[Setting License Key in Web.config](https://ironpdf.com/troubleshooting/license-key-web.config/)' guide for further information.

Verify `IronPdf.License.IsLicensed` returns `true`.

### Configure your key in a .NET Core appsettings.json file

For a global license key configuration in .NET Core:

- Create a `appsettings.json` in the root directory of your project
- Add a 'IronPdf.LicenseKey' entry to your JSON configuration. Set the value to your license key.
- Adjust the file properties to include _Copy to Output Directory: Copy always_
- Verify that `IronPdf.License.IsLicensed` is `true`.

File: _appsettings.json_

```json
{
  "IronPdf.LicenseKey": "IRONPDF-MYLICENSE-KEY-1EF01"
}
```

### Apply your key in Azure Functions

#### Local

Incorporate the license key in `local.settings.json`:

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

#### Deployment

1. Access the Azure portal and locate your Function app using the search function.
2. Navigate to **Settings** then **Environment variables** from the selection on the left.
3. Hit **+ Add**, and input the following when the panel appears:

    ```plaintext
    Name - IronPdf.LicenseKey
    Value - YOUR-LICENSE-KEY
    ```

4. Tap on **Apply** to save changes.

---

## Step 3: Test if your key has been installed correctly

```csharp
// Validate the entered license key.
bool result = IronPdf.License.IsValidLicense("IRONPDF-MYLICENSE-KEY-1EF01");

// Confirm that IronPDF is authorized
bool isLicensed = IronPdf.License.IsLicensed;
```

_Reminder:_ Always perform a clean and republish of your application after adding a license to prevent deployment errors.

---

## Step 4: Get started with your project

Follow our tutorial on [how to get started with IronPDF](https://ironpdf.com/docs/).

---

## Questions?

For any inquiries, please contact <support@ironsoftware.com>.