# IronPdf Azure App Service & Android Demo
IronPdf is equipped to run as a remote service, for improved convenience, performance, and deployabillity. Many customers are already using this technology to [run IronPdf in a Docker container](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) alongside their main application.

The IronPdf.Server.Azure NuGet package now enables running IronPdf in the cloud, enabling easy use of IronPdf across any platform, including mobile!
### Azure App Service Host
1. Create a new Azure BLOB Storage Container
2. Create a new Azure App Service and App Service Plan. We suggest *Basic B2* plan or greater, but *Free F1* should be sufficient to get started.
3. Navigate to the **Settings/Configuration** section of your Web app and set the following values:
- BLOB_STORAGE_CONNECTION: You can configure a connection string according to the [format outlined by Microsoft](https://learn.microsoft.com/en-us/azure/storage/common/storage-configure-connection-string)
- BLOB_STORAGE_CONTAINER: This is just the name of the container within the storage account
- HTTP20_ONLY_PORT: Must be set to 80
4. Using Visual Studio, open the example Azure App Service Linux Container app, *IronPdf.Android.Server.csproj*
5. Create a new publish profile which targets the Azure App Service you created in step 2.
6. Publish your app!
7. After several minutes, you should be able to verify your app is successfully publish by navigating to the URL in a browser, which will print a simple debug string.
### Android MAUI Client
1. Using Visual Studio, open the example MAUI Android application, *IronPdf.Android.Client.csproj*
2. Within **MainPage.xaml.cs**, set your license key or remove this line to generate watermarked documents
3. Within **MainPage.xaml.cs**, change the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/",` line to your Azure App Service which is hosting IronPdf.
4. Run the demo on an Android device which supports API 21.0 or higher.
5. NOTE: Depending on your plan settings, the first render may take awhile as your Azure App Service is started for the first time.
