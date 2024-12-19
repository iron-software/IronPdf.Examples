# Viewing PDFs in MAUI for C# .NET

***Based on <https://ironpdf.com/tutorials/pdf-viewing/>***


![IronPDF Viewer Banner](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/ironpdf_viewer_banner.png)

The demand for cross-platform development capabilities increases daily, with PDF document viewing becoming a standard utility in modern applications. Utilizing the **IronPDF Viewer**, developers can seamlessly integrate PDF viewing functions into their MAUI apps.

This guide will explore the steps necessary to implement the **IronPDF Viewer** within a MAUI application, enabling functionalities like viewing, saving, and printing PDFs.

<hr class="separator">

<p class="main-content__segment-title">Overview</p>

<br>

## Download and Install the IronPDF Viewer Library

### Visual Studio - NuGet Package Manager

Within Visual Studio, go to your project in the solution explorer, right-click, and choose `Manage NuGet Packages...`. Search for **IronPdf.Viewer.Maui** and install the latest version. Alternatively, access the NuGet Package Manager console via `Tools > NuGet Packet Manager > Package Manager Console` and run:

```shell
Install-Package IronPdf.Viewer.Maui
```

## Integrate IronPDF Viewer into a MAUI Application

### Setup

Before integrating the IronPDF Viewer, ensure your MAUI project does not target iOS and Android platforms. Check this by right-clicking the project file, selecting **Properties**, and ensuring both **Target the iOS Platform** and **Target the Android platform** checkboxes are unchecked. After these adjustments, save and restart Visual Studio for changes to take effect.

![Properties Screen](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/properties_screen_underlined.png)

Next, modify your _MauiProgram.cs_ file to include the viewer initialization:

```cs
using IronPdf.Viewer.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // additional configuration options ...
            .ConfigureIronPdfView(); // Initialize the viewer

        return builder.Build();
    }
}
```

To deactivate the default banner, enter your license key in `ConfigureIronPdfView`:

```cs
.ConfigureIronPdfView("YOUR-LICENSE-KEY");
```

### Add a PDF Viewer Page

#### Steps
1. To add a new page, right-click on your project, select `Add > New Item...` and navigate to the `.NET MAUI` section. Choose `.NET MAUI ContentPage (XAML)` for XAML or `.NET MAUI ContentPage (C#)` for C# and name your file _PdfViewerPage_.
   
![Add New Item](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/additem.png)

2. For a XAML-based page, insert the following code and save:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui">
    <ipv:IronPdfView x:Name="pdfView"/>
</ContentPage>
```

For a C# page:

```cs
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

3. Update your _AppShell.xaml_ file:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">
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

4. Build and run your project. You will see a tabbed interface with the "PDF Viewer" tab opening the IronPDF Viewer:

![IronPDF Viewer Default](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/pdfviewer_default.png)

### Loading a PDF at Startup

Enable IronPDF Viewer to load a PDF file on startup by implementing one of the following methods:

#### Load by Filename

Directly specify the PDF source in the XAML tag or use `IronPdfViewSource.FromFile` in C#:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns:ipv="clr-namespace:IronPdf.Viewer.Maui;assembly=IronPdf.Viewer.Maui">
    <ipv:IronPdfView Source="C:/path/to/my/example.pdf" />
</ContentPage>
```

Or:

```cs
pdfView.Source = IronPdfViewSource.FromFile("C:/path/to/my/example.pdf");
```

#### Load Through Byte Array or Stream

Using C#, load a PDF from a byte array or stream, respectively:

```cs
pdfView.Source = IronPdfViewSource.FromBytes(File.ReadAllBytes("~/Downloads/example.pdf"));
```

Or:

```cs
pdfView.Source = IronPdfViewSource.FromStream(File.OpenRead("~/Downloads/example.pdf"));
```

## Configure the Toolbar

Customize IronPDF Viewer's toolbar by setting the `Options` parameter. For instance, to enable all features:

```xml
<ipv:IronPdfView x:Name="pdfView" Options="All"/>
```

Or, to display only thumbnails and the open file option:

```cs
pdfView.Options = IronPdfViewOptions.Thumbs | IronPdfViewOptions.Open;
```

Which results in:

![Toolbar with thumbnail and open file options](https://ironpdf.com/static-assets/pdf/tutorials/pdf-viewing/toolbar_thumbsopen.png)

## Conclusion

This tutorial walked through the integration of IronPDF Viewer into a MAUI application and how to tailor its features for optimal usability.

Should you have any inquiries or requests related to IronPDF Viewer or any other product, please [contact our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are eager to help.