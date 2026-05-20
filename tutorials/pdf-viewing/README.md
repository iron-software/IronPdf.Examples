# Viewing PDF Documents in MAUI for C# .NET

***Based on <https://ironpdf.com/tutorials/pdf-viewing/>***


![IronPDF Viewer Banner](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/ironpdf_viewer_banner.png)

In today's cross-platform development landscape, the ability to view PDF files within an application is a critical feature. The **IronPDF Viewer** offers a robust solution by incorporating PDF viewing capabilities directly into your MAUI app.

This guide will cover how to incorporate **IronPDF Viewer** into a MAUI application, enabling features such as viewing, saving, and printing PDF documents.

### Quickstart: Setting Up IronPDF Viewer in MAUI

Quickly integrate the IronPDF Viewer into your MAUI application using a few simple lines of code. This quickstart guide will show you how to efficiently load a PDF file using the formidable IronPDF library, ideal for developers looking to enrich their applications with smooth PDF viewing capabilities. Start by initializing the IronPDF Viewer and loading your PDF for streamlined in-app PDF viewing.

```cs
// Instantly embed the PDF viewer and load a file
var viewer = new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };  
```

## Installing the IronPDF Viewer Library

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

### Setup via Visual Studio's NuGet Package Manager

From within Visual Studio, right-click your project in the solution explorer and choose `Manage NuGet Packages...`. Here, search for **IronPdf.Viewer.Maui** and install the latest release. Alternatively, access the NuGet Package Manager console by navigating to `Tools > NuGet Package Manager > Package Manager Console`, and execute the following command:

```shell
Install-Package IronPdf.Viewer.Maui
```

## Implementing IronPDF Viewer in a MAUI Application

Below, we describe the steps involved in integrating the IronPDF Viewer into a basic MAUI application.

### Configuration

First, make sure your MAUI project does not target iOS and Android platforms. This can be verified by right-clicking on the project file and selecting **Properties**. If necessary, uncheck **Target the iOS Platform** and **Target the Android Platform**, save your changes, and restart Visual Studio.

![Properties Screen](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/properties_screen_underlined.png)

Next, add the following code in your _MauiProgram.cs_ file to initialize the viewer:

```csharp
using IronPdf.Viewer.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // additional configuration options ...
            .ConfigureIronPdfView(); // instantiate the viewer during app start-up

        return builder.Build();
    }
}
```

If you have an IronPDF license key, incorporate it into the configuration to remove the default banner:

```csharp
.ConfigureIronPdfView("YOUR-LICENSE-KEY");
```

### Creating a PDF Viewer Page

Learn how to create a dedicated PDF Viewer page in your MAUI application with the following steps:. 

#### Procedure

1. Right-click on your project, navigate to `Add > New Item...`
   ![Add New Item](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/additem.png)

2. Choose `.NET MAUI` and depending on your preference, select either `.NET MAUI ContentPage (XAML)` for a XAML page or `.NET MAUI ContentPage (C#)` for a C# page. Name the file _PdfViewerPage_ and click `Add`.
   ![.NET MAUI `ContentPage`](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/mauipages.png)

3. For a XAML page, add:
```xml
<ipv:IronPdfView x:Name="pdfView"/>
```
For a C# page, add:
```csharp
public class MainPage : ContentPage
{
    private readonly IronPdfView pdfView;

    public MainPage()
    {
        InitializeComponent();
        this.pdfView = new IronPdfView { Options = IronPdfViewOptions.All };
        Content = this.pdfView;
    }
}
```

4. Include the new page into the application's navigation by modifying the _AppShell.xaml_ file:
```xml
<TabBar x:Name="AppTabBar">
    <Tab Title="Home">
        <ShellContent ContentTemplate="{DataTemplate local:MainPage}" Route="MainPage"/>
    </Tab>
    <Tab Title="PDF Viewer">
        <ShellContent ContentTemplate="{DataTemplate local:PdfViewerPage}" Route="PDFViewer"/>
    </Tab>
</TabBar>
```

5. Build and run your project to see the tabs in the application, and navigating to the "PDF Viewer" tab will present the IronPDF Viewer.

![IronPDF Viewer Default](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/pdfviewer_default.png)

### Initializing PDF on Start-Up

You can preload a PDF in the viewer by specifying the source in various ways:

#### From a Local File

In your XAML:
```xml
<ipv:IronPdfView Source="C:/path/to/my/example.pdf" />
```
Or in C#:
```csharp
pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
```

#### From a Byte Array or Stream (C# Only)

```csharp
pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
```

## Customizing the Toolbar

Configure the IronPDF Viewer's toolbar to contain elements such as thumbnails, page navigation, zoom controls, file interactions, and more.

By default, here is the toolbar:
![Default Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_all.png)

To enable all features:
```xml
<ipv:IronPdfView x:Name="pdfView" Options="All"/>
```
Or, in C#, for a specific arrangement:
```csharp
pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
```
Which would look like this:
![Toolbar with thumbnail and open file options](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_thumbsopen.png)

## Final Thoughts

This tutorial demonstrated integrating and customizing the IronPDF Viewer for a MAUI application, equipping developers with the tools to enhance app functionality efficiently.

For additional features or questions regarding IronPDF Viewer, please [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We're here to assist you further!