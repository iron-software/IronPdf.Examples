# How to Implement IronPDF on Android MAUI

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

IronPDF is now capable of operating as a remote service, providing elevated levels of convenience, efficiency, and deployability for its users. This solution is already popular among those who deploy [IronPDF inside a Docker container](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) to work seamlessly with their main applications.

The [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) NuGet package facilitates the deployment of IronPDF on the cloud, simplifying its usage across numerous platforms, including mobile environments!

If you need any example projects or further resources, feel free to explore our GitHub repository on the right.

## Set Up Azure App Service

1. Set up a new Azure BLOB Storage Container.
2. Establish a new Azure App Service and a corresponding App Service Plan. We recommend choosing the Basic B2 plan or higher; however, the Free F1 plan might be adequate for initial experiments.
3. In the configuration section of your App Service, adjust these settings:
   - `BLOB_STORAGE_CONNECTION`: Configure this connection string following Microsoft’s specified format.
   - `BLOB_STORAGE_CONTAINER`: Name your storage container.
   - `HTTP20_ONLY_PORT`: This should be configured to 80.
4. Open the provided Azure App Service Linux Container project, `IronPdf.Android.Server.csproj`, in Visual Studio.
5. Generate a new publish profile targeting the Azure App Service you prepared earlier.
6. Execute the publish command.
7. Within a few minutes, you can confirm your application's deployment by accessing the provided URL with a browser, which will display a basic debug message.

## Configure Android MAUI Client

1. Launch the example MAUI Android application, `IronPdf.Android.Client.csproj`, using Visual Studio.
2. In the`MainPage.xaml.cs` file, input your license key or opt to leave it empty to produce watermarked outputs.
3. Update the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/"` line in `MainPage.xaml.cs` to point to your Azure App Service hosting the IronPdf.
4. Run the demo on an Android device that supports API level 21.0 or above.

**Note**: The initial rendering might take extra time if it's the first activation of your Azure App Service after setting it up.