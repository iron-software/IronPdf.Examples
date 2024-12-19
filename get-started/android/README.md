# Implement IronPDF on Android with MAUI

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

IronPDF, capable of operating as a remote service, enhances ease, performance, and scalability. Numerous customers utilize this setup to deploy [IronPDF within a Docker environment](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) concurrently with their primary applications.

The [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) NuGet package facilitates the integration of IronPDF into cloud infrastructures, simplifying its use on any device, including mobile platforms!

Feel free to clone the GitHub repository mentioned on the right for quick access.

<h3>Getting Started with IronPDF</h3>

----------------

## Azure App Service Setup

1. Initialize a new Azure BLOB Storage Container.
2. Set up a new Azure App Service and an App Service Plan. We recommend choosing the Basic B2 plan or higher, but the Free F1 plan should also be adequate to commence.
3. In your Web app's Settings/Configuration area:
   1. `BLOB_STORAGE_CONNECTION`: Set up a connection string as per Microsoft's specifications.
   2. `BLOB_STORAGE_CONTAINER`: Simply the name of your container within the storage solution.
   3. `HTTP20_ONLY_PORT`: Should be configured to port 80.
4. Open the project `IronPdf.Android.Server.csproj` with Visual Studio under the example Azure App Service Linux Container.
5. Generate a new publish profile targeting your previously created Azure App Service.
6. Deploy your application!
7. After a few minutes, check the successful deployment of your app by visiting its URL via a browser, which will display a basic debug message.

## Android MAUI Client Setup

1. Start by opening the `IronPdf.Android.Client.csproj` MAUI Android example application in Visual Studio.
2. In `MainPage.xaml.cs`, either insert your license key or proceed without it to produce documents with watermarks.
3. Modify the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/"` line in `MainPage.xaml.cs` to point to your hosted IronPdf on Azure App Service.
4. Launch the application on an Android device supporting API level 21.0 or above.

NOTE: The initial document rendering might take longer as the Azure App Service boots up for the first time.