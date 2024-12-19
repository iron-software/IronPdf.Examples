***Based on <https://ironpdf.com/examples/cshtml-to-pdf-mvc-core/>***

This code snippet illustrates how to transform MVC Views into PDF documents using Iron Software tools.

The packages `IronPdf.Extensions.Mvc.Core` and `IronPdf` collaboratively facilitate the conversion of Views into PDFs. The `IronPdf.Extensions.Mvc.Core` package extends the capabilities of `IronPdf` to encompass the rendering of Views into PDF format.

To undertake this conversion, utilize the `RenderRazorViewToPdf` method. This method demands an `IRazorViewRenderer`, the path to your ".cshtml" file, and the necessary data for the ".cshtml" file rendering. For a more detailed guide, check out the [How to Convert View to PDF in ASP.NET Core MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/) article.

Additionally, this functionality allows you to leverage the extensive features available in the **RenderingOptions** class. This includes inserting [page numbers in PDFs with IronPDF](https://ironpdf.com/how-to/add-page-numbers-to-existing-pdf/), embedding [text and HTML headers and footers with IronPDF](https://ironpdf.com/how-to/add-headers-and-footers-using-html-in-csharp/), and specifying custom paper sizes for PDFs. Once created, the PDF document can be edited or exported as required.