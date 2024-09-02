# Transforming XAML to PDF with .NET MAUI

.NET MAUI (Multi-platform App UI) serves as a versatile framework for constructing applications that run natively across multiple platforms. Building upon the foundations of Xamarin.Forms within the expansive .NET 6 environment, .NET MAUI facilitates the development of applications for desktop, web, and mobile platforms utilizing shared UI elements and a unified codebase. Additionally, it provides the flexibility to incorporate platform-specific code and assets where required.

IronPdf is a powerful tool that empowers .NET application developers to create PDFs from MAUI pages, thereby enabling PDF generation within these applications. However, it's important to note that IronPdf does not currently support mobile platforms.

## IronPdf Extensions for MAUI

To utilize IronPdf within a MAUI application, the **IronPdf.Extensions.Maui** package is required in addition to the main IronPdf library. This package extends the capabilities of IronPdf, allowing for the conversion of MAUI application content pages into PDFs.

```shell
PM > Install-Package IronPdf.Extensions.Maui
```

<div class="products-download-section">
	<div class="js-modal-open product-item nuget" style="width: fit-content; margin-left: auto; margin-right: auto;" data-modal-id="trial-license-after-download">
		<div class="product-image">
			<img class="img-responsive add-shadow" alt="C# NuGet Library for PDF" src="https://ironpdf.com/img/nuget-logo.svg">
		</div>
		<div class="product-info">
			<h3>Install using <span>NuGet</span></h3>
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

## PDF Generation from MAUI Pages

### Update MainPage.xaml.cs

- Redirect from MainPage.xaml to its counterpart code file, MainPage.xaml.cs.
- Rename the function **OnCounterClicked** to **PrintToPdf** and apply the following code.

The `RenderContentPageToPdf` method, provided by the **ChromePdfRenderer** class, has been designed to convert your MAUI page into a **PdfDocument** object that can be saved or displayed using methods like `SaveAs` or through a PDF viewing tool as detailed in [Viewing PDFs in MAUI](https://ironpdf.com/tutorials/pdf-viewing/).

Note that data binding support is not available yet with the `RenderContentPageToPdf` method.

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
        renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
        {
            HtmlFragment = "<h1>Document Header</h1>",
        };

        PdfDocument pdf = renderer.RenderContentPageToPdf<MainPage, App>().Result;
        pdf.SaveAs(@"C:\Users\lyty1\Downloads\MyMauiPdf.pdf");
    }
}
```

Additionally, converting from XAML not only generates the document but also grants access to the comprehensive **RenderingOptions**. This enables the use of advanced features such as adding text, setting up HTML headers and footers, stamping images, and incorporating page numbers which enhance the document layout and functionality.

### Modify MainPage.xaml

Adjust the MainPage.xaml by replacing the **OnCounterClicked** function with **PrintToPdf**. Activating this function will execute the `PrintToPdf` method to generate the PDF.

```cs
<Button
x:Name="PrintToPdfBtn"
Text="Create PDF"
SemanticProperties.Hint="Tap to generate PDF"
Clicked="PrintToPdf"
HorizontalOptions="Center" />
```

#### Displaying the PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/contentPageToPdf.pdf" width="100%" height="400px">
</iframe>

Prior to finalizing your PDF, additional modifications are possible such as merging and splitting the pages, rotating them, or embellishing them with annotations and bookmarks.

## Acquiring the Complete .NET MAUI Project

Download the full project code packaged as a zip file, which can be opened and executed within Visual Studio as a .NET MAUI App project.

[Download the project here.](https://ironpdf.com/static-assets/pdf/how-to/xaml-to-pdf-maui/MauiSample.zip)