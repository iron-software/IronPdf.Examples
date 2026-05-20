# XAML to PDF Conversion in .NET MAUI

***Based on <https://ironpdf.com/how-to/xaml-to-pdf-maui/>***


.NET MAUI (Multi-platform App UI) serves as a versatile framework that supports building applications for devices across various platforms while maintaining a single codebase. As a direct successor to Xamarin.Forms, it is a vital component of the .NET 6 ecosystem. This framework allows developers to write universal application code supplemented with platform-specific enhancements when needed.

IronPdf equips you with the capability to produce PDF documents straight from your MAUI application interfaces. Although IronPdf is currently not compatible with mobile platforms, it excels in desktop and web environments.

## Quickstart Guide: Transforming XAML into PDF using IronPDF and .NET MAUI

Transform XAML into high-quality PDF files easily and efficiently with IronPDF within your .NET MAUI applications. This concise guide offers a simple example to help you quickly incorporate PDF generation into your applications, delivering an enhanced user experience.

```cs
:title=Single-step PDF Creation from MAUI XAML!
var pdf = new IronPdf.ChromePdfRenderer().RenderContentPageToPdf<MainPage,App>().SaveAs("output.pdf");
```

## Utilizing the IronPdf Extension Package

To extend the capabilities of the primary `IronPdf` library in MAUI, the `IronPdf.Extensions.Maui` package is required. This addition is essential for converting XAML content pages to PDF in a MAUI setup.

```shell
:InstallCmd Install-Package IronPdf.Extensions.Maui
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
<div class="products-download-section">
<div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
<div class="product-image">
<img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
</div>
<div class="product-info">
<h3>Install via <span>NuGet</span></h3>
</div>
<div class="js-open-modal-ignore copy-nuget-section" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Click to copy">
<div class="copy-nuget-row">
<pre class="install-script">Install-Package IronPdf.Extensions.Maui</pre>
<div class="copy-button">
<button class="btn btn-default copy-nuget-script" type="button" data-toggle="popover" data-placement="bottom" data-content="Copied." aria-label="Copy the Package Manager command" data-original-title="" title="">
<span class="far fa-copy"></span>
</button>
</div>
</div>
</div>
<div class="nuget-link">nuget.org/packages/IronPdf.Extensions.Maui/</div>
</div>
</div>


## Converting MAUI Pages to PDF

### Modifying the MainPage.xaml.cs File

Transition from using the `OnCounterClicked` to `PrintToPdf` function in the MainPage code. Leverage the `RenderContentPageToPdf` method from the `ChromePdfRenderer` class to obtain and manage a `PdfDocument` object. This method, although not yet supporting data binding, provides a range of features and customization through its `RenderingOptions`.

```csharp
using IronPdf.Extensions.Maui;

namespace mauiSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void PrintToPdf(object sender, EventArgs e)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Configuring HTML header for the PDF
        renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
        {
            HtmlFragment = "<h1>Custom Header</h1>",
        };

        // Generating PDF from the current MAUI page
        PdfDocument pdfDocument = renderer.RenderContentPageToPdf<MainPage, App>().Result;

        pdfDocument.SaveAs(@"C:\Path\To\Save\createdPDF.pdf");
    }
}
```

Unlock full capabilities for PDF customization like adding [HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [stamping images](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), and [adding page numbers](https://ironpdf.com/how-to/page-numbers/), by employing the `RenderingOptions`.

### Updating MainPage.xaml

Switch MainPage.xaml's `OnCounterClicked` to `PrintToPdf`. This change gears the button to activate PDF creation upon being clicked.

```xml
<Button
    x:Name="PrintToPdfBtn"
    Text="Convert to PDF"
    SemanticProperties.Hint="Initiates PDF conversion"
    Clicked="PrintToPdf"
    HorizontalOptions="Center" />
```

#### Displaying the Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/contentPageToPdf.pdf" width="100%" height="400px"></iframe>

Implement additions such as [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), or rotating pages prior to saving. Enhance the PDF further by including [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).

## Download the Full .NET MAUI App Project

Obtain the entire code for this tutorial as a zipped project file, ready to be unzipped and opened in Visual Studio as a .NET MAUI App.

[Download the Complete MAUI Sample Project](https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/MauiSample.zip)

Explore further possibilities with our detailed guide: [Explore PDF Conversion](https://ironpdf.com/tutorials/convert-pdf/)