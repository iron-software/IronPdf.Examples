# IronPDF License Keys

***Based on <https://ironpdf.com/how-to/license-keys/>***


## Acquiring a License Key

Employing an IronPDF license key permits full operational deployment and development of your project without boundaries.

Consider [purchasing a license key](https://ironpdf.com/licensing/) or [opting for a free 30-day trial key](https://ironpdf.com/trial-license).

--------------------------------------------------------------------------------

## Step 1: Download the Latest Version of IronPDF

### Installation via NuGet

In Visual Studio, perform a right-click on your project in the solution explorer and select "Manage NuGet Packages...". Proceed to search for IronPDF and install the most recent version. Accept any prompts that appear.

This version is compatible with any C# .NET Framework beginning from 4.6.2 onwards, as well as .NET Core 2.0 and higher. It functions identically in VB.NET projects.

```shell
Install-Package IronPdf
```

[https://www.nuget.org/packages/IronPdf](https://www.nuget.org/packages/IronPdf)

### Installation via DLL

You can also manually download and implement the IronPDF DLL within your project or the GAC from [https://ironpdf.com/packages/IronPdf.zip](https://ironpdf.com/packages/IronPdf.zip)

Ensure to include this directive at the beginning of any **cs** class file utilizing IronPDF:

```csharp
using IronPdf;
```

--------------------------------------------------------------------------------

## Step 2: Implement Your License Key

### Activate your IronPdf license key via code

Insert this line of code at the beginning of your application, prior to the utilization of IronPDF. This approach is universally applicable and straightforward.

Applicable for both .NET Core and .NET Framework applications.

```cs
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

Confirmation of a valid license can be conducted using either `IronPdf.License.IsValidLicense(string LicenseKey)` or the `IronPdf.License.IsLicensed` property.

### Configure your key using Web.Config or App.Config in .NET Framework Applications

To globally configure your application with a key using Web.Config or App.Config, introduce the following key within the `<appSettings>` element of your config file.

```xml
<configuration>
....
  <appSettings>
    <add key="IronPdf.LicenseKey" value="IRONPDF-MYLICENSE-KEY-1EF01"/>
  </appSettings>
....
</configuration>
```

There exists a noted licensing issue impacting IronPdf versions [2023.4.4](https://www.nuget.org/packages/IronPdf/2023.4.4) to [2024.3.3](https://www.nuget.org/packages/IronPdf/2024.3.3):

- **ASP.NET** projects
- **.NET Framework version >= 4.6.2**

The key embedded within a `Web.config` file isn’t being correctly utilized. Learn more in the '[Setting License Key in Web.config](https://ironpdf.com/troubleshooting/license-key-web.config/)' article.

Confirm via `IronPdf.License.IsLicensed` guaranteeing a `true` return to ensure setup.

### Applying your key with a .NET Core appsettings.json file

For global application in .NET Core:

- Add a JSON file named `appsettings.json` at the root of your project
- Include an 'IronPdf.LicenseKey' entry in your JSON config file with your license key as its value.
- Set the file property to _Copy to Output Directory: Copy always_
- Verify setup with `IronPdf.License.IsLicensed`, which should return `true`.

File: _appsettings.json_

```json
{
    "IronPdf.LicenseKey":"IRONPDF-MYLICENSE-KEY-1EF01"
}
```

### Activation in Azure Functions

#### Locally

Incorporate the license key in `local.settings.json`:

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

1. Log into your Azure portal. Use the search bar to locate your function app and select it.
2. Navigate to Settings and click on Configuration.
3. Go to Application settings and press New Application setting.
4. Input Name and Value as follows:

    ```txt
    Name - IronPdf.LicenseKey
    Value - YOUR-LICENSE-KEY
    ```

5. Ensure you save your changes.

--------------------------------------------------------------------------------

## Step 3: Verify Proper Installation of Your Key

```csharp
// Validates the correctness of a license key.
bool result = IronPdf.License.IsValidLicense("IRONPDF-MYLICENSE-KEY-1EF01");

// Establishes whether IronPDF is licensed effectively.
bool is_licensed = IronPdf.License.IsLicensed;
```

_Note:_ Always execute a clean and republish of your application after configuring a license to prevent discrepancies during deployment.

--------------------------------------------------------------------------------

## Step 4: Initiate Your Project

Embark on your journey with IronPDF by following our [getting started guide](https://ironpdf.com/docs/).

--------------------------------------------------------------------------------

## Questions?

Should inquiries arise, do not hesitate to contact <support@ironsoftware.com>