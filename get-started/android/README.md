# Integrating IronPDF with MAUI on Android

***Based on <https://ironpdf.com/get-started/android/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/platforms/h74/azure.svg">
        </div>
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/platforms/h74/android.svg">
        </div>
    </div>
</div>

IronPDF now supports operation via remote services, enhancing ease of use, performance, and deployment options. Numerous enterprises currently deploy [IronPDF inside Docker containers](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) to complement their primary applications.

The [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) package facilitates the deployment of IronPDF on cloud architectures, streamlining its usage across various platforms, including mobile environments!

For your project setup, feel free to fork a GitHub repository from the suggested links.

### Getting Started with IronPDF

```xml
<Project>
  <ItemGroup>
    <PackageReference Include="IronPdf" Version="2023.*" />
  </ItemGroup>
</Project>
```

## Hosting With Azure App Service

1. Initiate a new Azure BLOB Storage Container.
2. Set up a new Azure App Service and corresponding App Service Plan. We recommend choosing at least the Basic B2 plan, although the Free F1 plan might suffice for initial trials.
3. Go to your Web app's Settings/Configuration area and assign values as follows:
   - `BLOB_STORAGE_CONNECTION`: Configure using the format specified by Microsoft.
   - `BLOB_STORAGE_CONTAINER`: Name your storage container.
   - `HTTP20_ONLY_PORT`: This should be set to 80.
4. In Visual Studio, load the `IronPdf.Android.Server.csproj` which is an example of an Azure App Service Linux Container app.
5. Configure a new publish profile targeting the Azure App Service created in step 2.
6. Deploy your application.
7. The application should be up and running on the provided URL within a few minutes, displaying a basic debug message when accessed via a browser.

## Configuring the Android MAUI Client

1. Open the `IronPdf.Android.Client.csproj` MAUI Android example using Visual Studio.
2. In `MainPage.xaml.cs`, ensure your license key is set, or opt to test with the default watermarked documents configuration.
3. Update the `Host` string in `MainPage.xaml.cs` to point to your hosted Azure App Service where IronPdf is operational.
4. Execute the demo on an Android device supporting API level 21.0 or higher.

```csharp
// MainPage.xaml.cs Example Code
using System;  // Required namespaces

namespace IronPdf.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Specify your Azure App Service URL where IronPDF is running
            var pdfServiceUrl = "https://YOUR-APP-SERVICE.azurewebsites.net/";

            // Implement your PDF operations here
        }
    }
}
```

**IMPORTANT:** The initial rendering might take some time as your Azure App Service boots up for the first time.