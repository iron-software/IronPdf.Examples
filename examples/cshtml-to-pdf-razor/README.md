> Full guide: [CSHTML to PDF razor](https://ironpdf.com/examples/cshtml-to-pdf-razor/)

The following code illustration explains how to transform a Razor page into a PDF document.

For this conversion within an ASP.NET Core Web Application, two essential packages, IronPdf.Extensions.Razor and IronPdf, are required. These two work in tandem to facilitate the conversion of Razor pages into PDF files.

When converting from Razor pages, the **RenderingOptions** class offers a comprehensive set of features that are usable. The produced PDF can be edited further or exported as necessary.

In the given example, the content of a Razor page is converted into PDF through the use of IronPdf's `ChromePdfRenderer`. Rendering features like paper size and title can be specified using `RenderingOptions`. The created PDF can be stored as a file or delivered directly as content for browser viewing. Additionally, response headers can be modified to support either inline display or file download.

[Learn to Convert Razor Pages to PDFs with IronPDF](https://ironpdf.com/how-to/cshtml-to-pdf-razor/)