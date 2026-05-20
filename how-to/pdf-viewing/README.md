# PDF Viewing in MAUI for C# .NET

***Based on <https://ironpdf.com/how-to/pdf-viewing/>***


![IronPDF Viewer Banner](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/ironpdf_viewer_banner.png)

In today’s landscape of software development, enabling users to view PDF documents within your application has become essential. Utilize the **IronPDF Viewer** to seamlessly integrate PDF functionality into your MAUI apps.

This guide will demonstrate the integration of **IronPDF Viewer** within a MAUI application, enabling functions like viewing, saving, and printing PDF files.

*as-heading:2(Quickstart: Implement PDF Viewing in MAUI using IronPDF)*

Easily add IronPDF to your MAUI app and start displaying PDFs right away. This straightforward example shows how to initialize the IronPDF PdfViewer and load a PDF file for immediate display, perfect for developers wanting to boost their application’s PDF capabilities.

```cs
:title=Embed a full-featured PDF viewer with a single line of code!
new IronPdf.Viewer.Maui.PdfViewer { Source = "document.pdf" };
```



<br>

## Install the IronPDF Viewer Library

!!!--LIBRARY_START_TRIAL_BLOCK--!!!

### Installation via Visual Studio - NuGet Package Manager

Right-click on your project in the Solution Explorer within Visual Studio and select `Manage NuGet Packages...`. Search for **IronPdf.Viewer.Maui** and install the latest version to your project. Alternatively, access the NuGet Package Manager console via `Tools > NuGet Package Manager > Package Manager Console` and run this command:

```shell
:InstallCmd Install-Package IronPdf.Viewer.Maui
```

## How to Embed IronPDF Viewer in a MAUI App

The upcoming sections outline how to incorporate the IronPDF Viewer into a standard MAUI application.

### Initial Setup

Before proceeding with the integration of IronPDF Viewer, confirm that your project is not targeting iOS and Android platforms. This can be checked by opening the project properties (right-click on the project file, then select **Properties**), and ensuring the **Target the iOS Platform** and **Target the Android platform** checkboxes are not selected. Remember to save and restart Visual Studio after making these changes.

![Properties Screen](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/properties_screen_underlined.png)

Once you have untargeted the specific platforms, add the following code in your _MauiProgram.cs_ file to initialize the viewer:

```csharp
using IronPdf.Viewer.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // other configuration settings ...
            .ConfigureIronPdfView(); // initialize the viewer on app launch

        return builder.Build();
    }
}
```

To remove the default banner at the bottom-right of the view, supply your IronPDF license key to the `ConfigureIronPdfViewer` method:

```csharp
.ConfigureIronPdfView("YOUR-LICENSE-KEY");
```

### Creating a PDF Viewer Page

Follow these steps to create a dedicated PDF Viewer page and incorporate IronPDF Viewer into a MAUI application using either XAML or C# `ContentPage`.

#### Steps

1. Add a new page by right-clicking on your project, and navigate to `Add > New Item...` 
   ![Add New Item](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/additem.png)

2. In the `.NET MAUI` section, choose `.NET MAUI ContentPage (XAML)` for a XAML page or `.NET MAUI ContentPage (C#)` for a C# page. Name it _PdfViewerPage_ and click `Add`. 
   ![.NET MAUI `ContentPage`](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/mauipages.png)

3. For a XAML file, add the following and save:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage ...
    xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
    ...>
    <ipv:IronPdfView x:Name="pdfView"/>
</ContentPage>
```

If using C#, include the following in the `ContentPage` code and save:

```csharp
using IronPdf.Viewer.Maui;

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

4. Update your _AppShell.xaml_ with the following:

```xml
<?xml version="1.0" encoding="UTF-8" ?>
<Shell ...
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    ...>
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

5. Save, build, and run your project. Tabs appear in the top-left corner, and the "PDF Viewer" tab opens the IronPDF Viewer.

![IronPDF Viewer Default](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/pdfviewer_default.png)

### Loading a PDF at Start-Up

At application start, IronPDF Viewer can prompt users to open a PDF by default or load a PDF automatically. Here are three methods for loading a PDF at start:

#### Load by Filename

Specify the source in the `IronPdfView` tag in the XAML file, as shown:

```xml
<?xml version="1.0".encoding="utf-8" ?>
<ContentPage ...
    xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
    ...>
    <ipv:IronPdfView Source="C:/path/to/my/example.pdf" />
</ContentPage>
```

For a C# `ContentPage`, use the `IronPdfViewSource.FromFile` method:

```csharp
// Assuming an IronPdfView instance named pdfView was created earlier
pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
```

#### Load Through Byte Array

In C#, load a PDF from a byte array using the `IronPdfViewSource.FromBytes` method as follows:

```csharp
pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
```

#### Load Through Stream

Loading a PDF through a stream, which is not possible from XAML but can be done in C#, is achieved with the `IronPdfViewSource.FromStream` method as depicted:

```csharp
pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
```

## Configuring the Toolbar

IronPDF Viewer allows customization of the displayed toolbar options. The default and available toolbar features include zoom, thumbnail view, text search, and more.

By default, the viewer displays a toolbar with limited options:

![Default Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_all.png)

To enable all features, set the `Option` parameter in the `IronPdfView` tag in XAML to `All`:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage ...
    xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui"
    ...>
    <ipv:IronPdfView x:Name="pdfView" Options="All"/>
</ContentPage>
```

Alternatively, in C#:

```csharp
pdfView.Options = IronPdfViewOptions.All;
```

This will present the toolbar as shown:

![All Toolbar](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_all.png)

To display specific options only, such as thumbnails and open file, adjust the `Options` parameter accordingly:

In XAML:

```xml
<ipv:IronPdfView x:Name="pdfView" Options="Thumbs, Open"/>
```

In C#, combine the desired options:

```csharp
pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
```

Which results in:

![Toolbar with thumbnail and open file options](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_thumbsopen.png)

## Conclusion

This tutorial provided a comprehensive walkthrough for integrating IronPDF Viewer into a MAUI application and customizing the toolbar to meet your specific needs.

IronPDF Viewer is part of our IronPDF product suite. For feature requests or queries regarding IronPDF Viewer (or IronPDF), please [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are here to help you succeed!