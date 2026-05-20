***Based on <https://ironpdf.com/examples/xaml-to-pdf-maui/>***

The following example illustrates how a MAUI page can be transformed into a PDF document.

The `IronPdf.Extensions.Maui` package extends the core IronPdf library. Both the `IronPdf.Extensions.Maui` and `IronPdf` packages are necessary to convert a content page from a MAUI application into a PDF file.

Converting a MAUI page allows you to leverage all the capabilities of the `RenderingOptions` class. The generated PDF can either be saved as a file or displayed using a [MAUI PDF viewer](https://ironpdf.com/tutorials/pdf-viewing/).

<div class="hsg-featured-snippet examples__featured-snippet">
    <h2>Converting XAML Files to PDFs in MAUI</h2>
    <ol>
        <li><a class="js-modal-open" data-modal-id="trial-license-after-download" href="https://nuget.org/packages/IronPdf">Download and Install the IronPDF Library for XAML to PDF Conversion</a></li>
        <li>Create an instance of the **ChromePdfRenderer** class</li>
        <li>Utilize the **RenderingOptions** class to implement text and HTML headers and footers</li>
        <li>Apply the `RenderContentPageToPdf` method to convert XAML files into PDF</li>
        <li>Save the converted PDF document locally on your desktop</li>
    </ol>
</div>

Here's a code example that demonstrates this transformation process:


- **ChromePdfRenderer**: This class is designed to convert web content into PDFs using the Chrome rendering engine.
- **RenderingOptions**: This attribute facilitates customization of the PDF, including the addition of headers and footers, and adjusting page dimensions and margins.
- **RenderContentPageToPdf**: This method, part of the IronPdf.Extensions.Maui package, helps in converting a MAUI `ContentPage` into a PDF file.
- **SaveAs**: This function stores the created PDF at a designated location.

Discover how to convert XAML to PDF in MAUI with IronPDF through this in-depth guide: [Learn to Convert XAML to PDF in MAUI with IronPDF](https://ironpdf.com/how-to/xaml-to-pdf-maui/).