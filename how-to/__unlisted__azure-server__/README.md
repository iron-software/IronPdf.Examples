# IronPDF Integration on MAUI Android

***Based on <https://ironpdf.com/how-to/__unlisted__azure-server__/>***


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

Explore the benefits of remote service capabilities with IronPDF, optimal for increased convenience, performance, and scalability. A significant user base has embraced [deploying IronPDF within a Docker container parallel to their main apps](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine).

Utilize the [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) NuGet package to facilitate running IronPDF in cloud environments, thereby enhancing accessibility across different platforms, including mobile devices.

To simplify your start, a [GitHub repository dedicated to using IronPDF with MAUI Android is available for cloning](https://github.com/IronSoftware/IronPDF.Android.Example).

<h3>Starting with IronPDF</h3>

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

---

## Hosting on Azure App Service

1. Set up a new Azure BLOB Storage Container.
2. Establish a new Azure App Service and corresponding App Service Plan. A Basic B2 plan is recommended for optimal performance; however, a Free F1 plan could suffice initially.
3. In your Web app's Settings/Configuration area, enter your configurations:
   - `BLOB_STORAGE_CONNECTION`: Follow Microsoft's guidelines for setting up your connection string.
   - `BLOB_STORAGE_CONTAINER`: This specifies the name of your container in the storage account.
   - `HTTP20_ONLY_PORT`: Should be configured to port 80.
4. Open the `IronPdf.Android.Server.csproj`, which is the sample Azure App Service Linux Container app via Visual Studio.
5. Generate a new publishing profile targeting the Azure App Service setup in step 2.
6. Proceed to publish your application.
7. Within a few minutes, the successful publication of your app can be checked by visiting its URL in a web browser, where a simple debug string will be displayed.

## Android MAUI Client Setup

1. Start Visual Studio and launch the `IronPdf.Android.Client.csproj`, which is the example MAUI Android project.
2. Inside `MainPage.xaml.cs`, either set your IronPDF license key or leave it as default to create watermarked PDFs.
3. Modify the `Host` variable in `MainPage.xaml.cs` to point to your Azure App Service's URL, which will serve your IronPDF instance.
4. Execute the demo on an Android device capable of supporting API level 21.0 or newer.

```csharp
// MainPage.xaml.cs
public partial class MainPage : ContentPage
{
    // Define your license key if available
    private const string LicenseKey = "YOUR_LICENSE_KEY";
    
    // Specify the URL of your Azure App Service
    private const string Host = "https://YOUR-APP-SERVICE.azurewebsites.net/";

    public MainPage()
    {
        InitializeComponent();
        // Optional: Configure the license key
        IronPdf.License.LicenseKey = LicenseKey;
    }

    // Here, you can add your methods to handle interactions with the IronPDF service
}
```

Be patient during the initial rendering, as it might take some time for your Azure App Service to boot up for the first time.