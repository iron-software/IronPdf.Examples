This sample code outlines how to convert Views into PDF documents.

Two essential libraries, `IronPdf.Extensions.Mvc.Core` and `IronPdf`, are utilized collectively to convert Views into PDFs. The `IronPdf.Extensions.Mvc.Core` library extends `IronPdf` by facilitating the rendering of Views into PDF format.

To convert a View to a PDF, employ the `RenderRazorViewToPdf` method. This method necessitates an `IRazorViewRenderer`, the path to the `.cshtml` file, and the data to be displayed in the `.cshtml` file. For more details, please review the guide on [How to Convert View to PDF in ASP.NET Core MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/).

Moreover, this functionality provides access to the comprehensive set of options available through the `RenderingOptions` class. These options include inserting [page numbers](https://ironpdf.com/how-to/page-numbers), appending [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), and customizing the paper size of the PDF. The generated PDF file can then be further modified or exported as per requirements.