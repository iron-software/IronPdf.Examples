# Converting XAML to PDF in MAUI Applications

***Based on <https://ironpdf.com/how-to/xaml-to-pdf-maui/>***


## Introduction to .NET MAUI

.NET MAUI, or Multi-platform App UI, is a versatile framework for crafting native applications across devices. As a successor to Xamarin.Forms, .NET MAUI is integrated within the .NET 6 environment, allowing developers to build apps across desktop, web, and mobile platforms using shared UI components while maintaining a single codebase. It also supports incorporating platform-specific features as needed.

IronPdf provides functionality to create PDF documents from MAUI applications, although support for mobile platforms is not available presently.

## Setting Up IronPdf in MAUI

The **IronPdf.Extensions.Maui** package augments the IronPdf library, facilitating the conversion of MAUI application content into PDF files. You'll need both the IronPdf core library and this extension to render a MAUI page into a PDF. Install the package using the Package Manager Console:

```shell
PM > Install-Package IronPdf.Extensions.Maui
```

### NuGet Installation Guide

You can easily install the package via NuGet. Below is an illustration and direct installation command:

![C# NuGet Library for PDF](https://ironpdf.com/img/nuget-logo.svg)

**Quick NuGet Command:**

```shell
Install-Package IronPdf.Extensions.Maui
```

Visit the full package details [here](https://ironpdf.com/nuget.org/packages/IronPdf.Extensions.Maui/).

## Converting MAUI Page to PDF

### Modify MainPage.xaml.cs

Switch from `MainPage.xaml` to its code-behind, `MainPage.xaml.cs`, and rename the `OnCounterClicked` method to `PrintToPdf`. Below is an example of how to use the `RenderContentPageToPdf` method with the `ChromePdfRenderer` class to convert a MAUI page into a PDF document. Note however, that the method does not yet support data binding.

```cs
using IronPdf.Extensions.Maui;

namespace mauiSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Method to convert the current page into PDF
    private void PrintToPdf(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Setting up the HTML header
        renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
        {
            HtmlFragment = "<h1>Page Header</h1>",
        };

        // Generation of PDF from MAUI page content
        PdfDocument pdf = renderer.RenderContentPageToPdf<MainPage, App>().Result;

        // Saving the PDF to disk
        pdf.SaveAs(@"C:\path_to_save\your_pdf_file.pdf");
    }
}
```

### Modifications in MainPage.xaml

In the `MainPage.xaml` file, bind the `PrintToPdf` method to a new button, enabling users to generate a PDF from the current UI.

```cs
<Button
x:Name="PrintToPdfBtn"
Text="Print to PDF"
SemanticProperties.Hint="Click to convert page to PDF"
Clicked="PrintToPdf"
HorizontalOptions="Center" />
```

### Enhancing the Generated PDF

Beyond simple PDF creation, IronPdf's `PdfDocument` enables further modifications, such as merging, splitting, or rotating pages. Features also include adding annotations, bookmarks, and more.

#### PDF Preview Frame

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/contentPageToPdf.pdf" width="100%" height="400px"></iframe>

## Obtain the Complete .NET MAUI Project

The full MAUI sample project is available for download, packaged as a zipped file that can be used in Visual Studio as a fully-configurable .NET MAUI App project.

[Download the Complete MAUI Sample Project](https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/MauiSample.zip)