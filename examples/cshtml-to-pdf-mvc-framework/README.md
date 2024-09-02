This example demonstrates converting Views into PDF documents using specific .NET libraries.

For this process, the packages `IronPdf.Extensions.Mvc.Framework` and `IronPdf` are essential. The `IronPdf.Extensions.Mvc.Framework` is designed to enhance the functionalities of `IronPdf` by enabling the conversion of Views into PDF files.

To convert a view to a PDF, the `RenderView` method is employed. This method requires several important parameters: a `HttpContext`, the path to the `.cshtml` file, and the data needed for the `.cshtml` template. By calling the `Persons` action, the current View can be efficiently converted into a PDF document.

Moreover, the **RenderingOptions** class provides an extensive array of features. These features allow you to append [page numbers](https://ironpdf.com/how-to/page-numbers), include [text and HTML headers and footers](https://ironpdf.com/how-to/headers-and-footers/), and tailor the paper size of the PDF to meet specific needs. This gives you the liberty to further edit or export your PDF document as required.