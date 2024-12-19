# Converting XAML to PDF with .NET MAUI

***Based on <https://ironpdf.com/how-to/xaml-to-pdf-maui/>***


.NET MAUI (Multi-platform App UI) provides a robust framework for building native applications across multiple platforms. As an evolution of Xamarin.Forms, it is incorporated into the .NET 6 ecosystem. It lets developers design applications for desktop, web, and mobile from a single shared codebase, with the flexibility to include platform-specific code and assets as required.

IronPdf enables the conversion of MAUI application pages into PDFs, although it is not yet capable of supporting mobile platforms.

## IronPdf.Extensions.Maui Package

The **IronPdf.Extensions.Maui package** builds upon the primary **IronPdf** library, which is necessary to convert a MAUI application's content page into a PDF document.

```shell
PM > Install-Package IronPdf.Extensions.Maui
```

<link rel="stylesheet" type="text/css" href="https://ironpdf.com/front/css/content__install-components__extended.css" media="print" onload="this.media='all'; this.onload=null;">
<div class="products-download-section">
	<div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
		<div class="product-image">
			<img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
		</div>
		<div class="product-info">
			<h3>Install with <span>NuGet</span></h3>
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

## From MAUI Page to PDF

### Modify MainPage.xaml.cs

- Transition from the MainPage.xaml to its code counterpart, MainPage.xaml.cs.
- Replace the **OnCounterClicked** function with **PrintToPdf**, utilizing the forerunning code sample.

For transforming a MAUI page into a PDF, instantiate the **ChromePdfRenderer** class and call its `RenderContentPageToPdf` method. This yields a **PdfDocument** that you can either save directly or display using methods like `SaveAs` or through a PDF viewer detailed in [Viewing PDFs in MAUI](https://ironpdf.com/tutorials/pdf-viewing/).

Note, the `RenderContentPageToPdf` method is not yet capable of handling data binding.

```cs
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

        // Set HTML header
        renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
        {
            HtmlFragment = "<h1>Header</h1>",
        };

        // Generate PDF from Maui Page
        PdfDocument pdf = renderer.RenderContentPageToPdf<MainPage, App>().Result;

        // Save the generated PDF
        pdf.SaveAs(@"C:\Users\lyty1\Downloads\contentPageToPdf.pdf");
    }
}
```

Moreover, using the XAML rendering path offers limitless access to **RenderingOptions** features including adding [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), [stamping images](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/#stamper-abstract-class), customizing page numbers and sizes through [page number settings](https://ironpdf.com/how-to/page-numbers/), and page layout adjustments.

### Update MainPage.xaml File

In MainPage.xaml, substitute the default **OnCounterClicked** function with **PrintToPdf**. Triggering this button will activate the **PrintToPdf** method and generate the PDF.

```cs
<Button
x:Name="PrintToPdfBtn"
Text="Print to pdf"
SemanticProperties.Hint="Click to print page as PDF"
Clicked="PrintToPdf"
HorizontalOptions="Center" />
```

#### Preview PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/contentPageToPdf.pdf" width="100%" height="400px">
</iframe>

Before finalizing your PDF, consider enhancing it with manipulations such as [merging, splitting pages](https://ironpdf.com/how-to/merge-or-split-pdfs/), or [adding rotations, annotations, and bookmarks](https://ironpdf.com/how-to/bookmarks/) to enrich the document.

## Obtain .NET MAUI Project Code

Download the full code for this project in a zipped file ready to be opened in Visual Studio as a .NET MAUI project.

[Download Complete MAUI Sample Project](https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/MauiSample.zip)