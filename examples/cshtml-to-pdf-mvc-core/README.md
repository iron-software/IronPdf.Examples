***Based on <https://ironpdf.com/examples/cshtml-to-pdf-mvc-core/>***

The following code example illustrates how to transform Views into PDF documents.

The `IronPdf.Extensions.Mvc.Core` and `IronPdf` packages collaboratively facilitate the conversion of Views into PDFs. The `IronPdf.Extensions.Mvc.Core` package enhances IronPdf by providing the capability to convert Views into PDF documents.

To perform this conversion, utilize the `RenderRazorViewToPdf` method. This method demands an `IRazorViewRenderer`, the path to your ".cshtml" file, and the necessary data to populate the ".cshtml" file. For a detailed guide, refer to the [How to Convert View to PDF in ASP.NET Core MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/) article.

Additionally, this process allows you to leverage the extensive features of the **RenderingOptions** class. This includes incorporating [page numbers in PDFs with IronPDF](https://ironpdf.com/how-to/add-page-numbers-to-existing-pdf/), embedding [text and HTML headers and footers with IronPDF](https://ironpdf.com/how-to/add-headers-and-footers-using-html-in-csharp/), and adjusting the PDF paper size as per your requirements. The final PDF file can be edited or exported according to your needs.