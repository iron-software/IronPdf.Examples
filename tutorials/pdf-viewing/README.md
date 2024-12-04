# Viewing PDFs in MAUI for C# .NET

***Based on <https://ironpdf.com/tutorials/pdf-viewing/>***


![IronPDF Viewer Banner](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/ironpdf_viewer_banner.png)

In today's world of cross-platform development, the ability to view PDF documents seamlessly within your application is essential. Utilizing the **IronPDF Viewer** allows for the integration of robust PDF viewing capabilities into your MAUI application.

In this tutorial, we'll demonstrate how to seamlessly incorporate the **IronPDF Viewer** into a MAUI application, enhancing it with functionalities like viewing, saving, and printing PDFs.

<hr class="separator">

<p class="main-content__segment-title">Overview</p>

<br>

## Download and Install the IronPDF Viewer Library

### Visual Studio - NuGet Package Manager

To begin, right-click on your project in the solution explorer within Visual Studio and choose `Manage NuGet Packages...`. Search for **IronPdf.Viewer.Maui** and install the latest version. Alternatively, access the NuGet Package Manager console by navigating to `Tools > NuGet Package Manager > Package Manager Console` and execute the following command:

```shell
:InstallCmd Install-Package IronPdf.Viewer.Maui
```

## Deploy IronPDF Viewer in a MAUI Application

Below, we outline the steps to integrate the IronPDF Viewer into a typical MAUI application.

### Setup

Ensure your MAUI project does not target iOS and Android platforms by right-clicking on the project file, selecting **Properties**, and unchecking **Target the iOS Platform** and **Target the Android platform** as illustrated below. Remember to save and restart Visual Studio after making changes.

![Properties Screen](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/properties_screen_underlined.png)

Proceed by opening your _MauiProgram.cs_ file and include the following initialization code:

```cs
using IronPdf.Viewer.Maui;
using IronPdf;
namespace ironpdf.PdfViewing
{
    public class Initialization
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFrameworks()
                .ConfigureIronPdfView(); // Initialize the PDF viewer

            return builder.Build();
        }
    }
}
```

To exclude the default banner from IronPDF Viewer, add your license key as follows:

```cs
.ConfigureIronPdfView("YOUR-LICENSE-KEY");
```

### Create a PDF Viewer Page

Let's look at how to set up a dedicated PDF Viewer page within your MAUI application, whether using XAML or C# `ContentPage`.

#### Steps

1. Right-click on your project and choose `Add > New Item...`
   ![Add New Item](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/additem.png)

2. Select the `.NET MAUI ContentPage (XAML)` to create a XAML-based page or `.NET MAUI ContentPage (C#)` for a C# page, and name your file _PdfViewerPage_. Then click `Add`.
   ![.NET MAUI `ContentPage`](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/mauipages.png)

3. Add the following XAML code to your newly created XAML file and save:
    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui">
        <ipv:IronPdfView x:Name="pdfView"/>
    </ContentPage>
    ```

For a C# ContentPage, use the following:
    ```cs
    using IronPdf.Viewer.Maui;
    using IronPdf;
    public class MainPage : ContentPage
    {
        private readonly IronPdfView pdfView;

        public MainPage()
        {
            InitializeComponent();

            this.pdfView = new IronPdfView
            {
                Options = IronPdfViewOptions.All
            };

            Content = this.pdfView;
        }
    }
    ```

4. Update your _AppShell.xaml_ to include:
    ```xml
    <?xml version="1.0" encoding="UTF-8" ?>
    <Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
        <TabBar x:Name="AppTabBar">
            <Tab Title="Home">
              <ShellContent ContentTemplate="{DataTemplate local:MainPage}" Route="MainPage"/>
            </Tab>
            <Tab Title="PDF Viewer">
              <ShellContent ContentTemplate="{DataTemplate local:PdfViewerPage}" Route="PDFViewer"/>
          </Tab>
        </TabBar>
    </Shell>
    ```

5. Build and run your project. You should see tabs in the top-left corner, and selecting the "PDF Viewer" tab will present the IronPDF Viewer.

![IronPDF Viewer Default](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/pdfviewer_default.png)

### Opening PDFs on Application Start-Up

IronPDF Viewer can be configured to load a PDF at the start of the application. This can be managed by specifying the file path, loading through a byte array, or reading through a stream.