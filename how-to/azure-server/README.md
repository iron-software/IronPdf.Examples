# Using IronPDF in a MAUI Android Environment

***Based on <https://ironpdf.com/how-to/azure-server/>***


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

IronPDF operates seamlessly as a remote service, allowing for enhanced convenience, improved performance, and simplified deployment. A growing number of clients have incorporated this solution to [deploy IronPDF within a Docker container alongside their primary applications](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine).

Utilizing the [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) NuGet package, you can effectively operate IronPDF in a cloud environment, ensuring compatibility across all platforms, including mobile!

To start with IronPDF on MAUI Android quickly, you can fork a [GitHub repository dedicated to this configuration](https://github.com/IronSoftware/IronPDF.Android.Example).

## Configuring Azure App Service

1. Set up a new Azure BLOB Storage Container.
2. Establish a new Azure App Service and App Service Plan. While a Basic B2 plan is recommended, the Free F1 plan might be adequate for initial setups.
3. Go to the Settings/Configuration area of your Web App and establish the following:
   1. `BLOB_STORAGE_CONNECTION`: Implement a connection string following the specifications provided by Microsoft.
   2. `BLOB_STORAGE_CONTAINER`: Designate your container's name located in the storage account.
   3. `HTTP20_ONLY_PORT`: Ensure this is set at 80.
4. In Visual Studio, load the `IronPdf.Android.Server.csproj` from the example Azure App Service Linux Container project.
5. Generate a new publishing profile targeting the Azure App Service established in step 2.
6. Execute the publication of your application.
7. After a few minutes, confirm your application's successful deployment by visiting its URL in a web browser, which shall display a basic debug string.

## Setting up the Android MAUI Client

1. In Visual Studio, load the `IronPdf.Android.Client.csproj` from the sample MAUI Android project.
2. In `MainPage.xaml.cs`, either set your license key or omit this line to allow the creation of watermarked documents.
3. Modify the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/"` line in `MainPage.xaml.cs` to reflect your Azure App Service hosting IronPdf.
4. Launch the demonstration on an Android device supporting API 21.0 or above.

NOTE: The initial rendering may take additional time if your Azure App Service is activating for the first time based on your selected plan settings.