# Implementing IronPDF in Android MAUI Apps

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

IronPDF offers remote service capabilities, providing enhanced ease of use, efficiency, and deployment options. Numerous clients have successfully integrated this functionality, executing [IronPDF within a Docker setup](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) alongside their primary software systems.

The [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) package makes it possible to deploy IronPDF in the cloud, facilitating its use on any platform, including mobile environments!

If you wish, there is a GitHub repository available for cloning on the right-hand side.


## Hosting with Azure App Service

1. Set up a new Azure BLOB Storage Container.
2. Launch a new Azure App Service and a corresponding App Service Plan. We recommend selecting the Basic B2 plan or higher, although the Free F1 plan may also be adequate to start.
3. In the "Settings/Configuration" area of your Web application, assign the following parameters:
   - `BLOB_STORAGE_CONNECTION`: Define a connection string as specified by Microsoft guidelines.
   - `BLOB_STORAGE_CONTAINER`: Simply the name of your storage container.
   - `HTTP20_ONLY_PORT`: This should be set to 80.
4. Open the sample Azure App Service Linux Container application, `IronPdf.Android.Server.csproj`, using Visual Studio.
5. Create and configure a new publish profile that targets the Azure App Service set up in step 2.
6. Deploy your application.
7. Shortly after, you can confirm the successful deployment of your app by visiting the provided URL, which will display a straightforward debug message.

## Android MAUI Client Setup

1. Launch the example MAUI Android app, `IronPdf.Android.Client.csproj`, with Visual Studio.
2. In MainPage.xaml.cs, either input your license key or omit this step to produce watermarked documents.
3. Modify the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/"` line in MainPage.xaml.cs to point to your web app hosting IronPdf.
4. Execute the demo on an Android device supporting API level 21.0 or newer.

Please be aware that initial document rendering might take longer if your Azure App Service is being booted up for the first time.