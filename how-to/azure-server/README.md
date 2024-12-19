# Utilizing IronPDF on MAUI Android

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

IronPDF is capable of functioning as a remote service, delivering enhanced convenience, performance, and scalability. Numerous customers leverage this technology, operating [IronPDF within a Docker container](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine) alongside their core applications.

The [`IronPdf.Server.Azure`](https://www.nuget.org/packages/IronPdf.Server.Azure) NuGet package facilitates IronPDF operation in cloud environments, simplifying its application across various platforms, including mobile.

For ease of use, you're welcome to clone the [IronPDF MAUI Android repository on GitHub](https://github.com/IronSoftware/IronPDF.Android.Example).

<h3>Starting with IronPDF</h3>



----------------------------------



## Azure App Service Setup

1. Initialize a new Azure BLOB Storage Container.
2. Set up a new Azure App Service and corresponding Service Plan. While a Basic B2 plan is recommended, a Free F1 plan may suffice initially.
3. In your Web app's Settings/Configuration area, adjust the following settings:
   1. `BLOB_STORAGE_CONNECTION`: Input a connection string as per the Microsoft guidance.
   2. `BLOB_STORAGE_CONTAINER`: Simply the name of your chosen container.
   3. `HTTP20_ONLY_PORT`: Should be configured to 80.
4. In Visual Studio, open the `IronPdf.Android.Server.csproj`, an example of the Azure App Service Linux Container app.
5. Generate a new publishing profile targeting your previously created Azure App Service.
6. Proceed to publish your application.
7. Shortly after, access your application via its URL in a web browser, where a simple debug confirmation will appear, indicating successful deployment.

## MAUI Android Client Setup

1. Open the `IronPdf.Android.Client.csproj` MAUI Android example using Visual Studio.
2. Inside `MainPage.xaml.cs`, either enter your license key or omit this line if you wish to produce documents with a watermark.
3. Modify the `Host = "https://YOUR-APP-SERVICE.azurewebsites.net/"` line to reflect your hosted Azure App Service's actual URL.
4. Execute the application on an Android device compatible with API 21.0 or above.

NOTE: Bear in mind that the initial document rendering might delay slightly as the Azure App Service boots up for the first time.