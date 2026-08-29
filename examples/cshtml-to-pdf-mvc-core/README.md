> Full guide: [CSHTML to PDF MVC core](https://ironpdf.com/examples/cshtml-to-pdf-mvc-core/)

The following code sample illustrates how to transform Views into PDF files using IronPDF.

Employing the combination of `IronPdf.Extensions.Mvc.Core` and `IronPdf` allows for efficient PDF creation from Views. The `IronPdf.Extensions.Mvc.Core` package extends the functionalities of `IronPdf` to enable PDF rendering from Views.

To convert Views into PDFs, utilize the `RenderRazorViewToPdf` method. This method necessitates the use of an `IRazorViewRenderer`, a path to the ".cshtml" file, and the data needed for the ".cshtml" page. Detailed guidance can be found in the [How-to Convert View to PDF in ASP.NET Core MVC](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/) article.

In addition, this functionality grants access to a comprehensive suite of features through the **RenderingOptions** class. You can employ [page numbering](https://ironpdf.com/how-to/page-numbers/) in PDFs using IronPDF, insert [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), and alter the paper size in the PDF settings. The generated PDF can then be modified or exported as required.

Explore more about converting CSHTML Views to PDFs in ASP.NET MVC Core at [this link](https://ironpdf.com/how-to/cshtml-to-pdf-mvc-core/).