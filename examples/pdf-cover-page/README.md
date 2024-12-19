***Based on <https://ironpdf.com/examples/pdf-cover-page/>***

Including a cover page in your PDF not only enhances its visual appeal but also boosts its brand recognition. IronPDF offers a straightforward method for incorporating cover pages into your PDF projects without needing any additional software. This can be achieved with just a couple of lines of code.

Here, we detail the process of effortlessly adding a cover page to your PDF using IronPDF.

The method `IronPdf.PdfDocument.Merge` in C# enables the inclusion of a cover page into a PDF. It allows the cover to be either rendered independently or combined seamlessly with the remainder of the document.

Begin by creating a cover page utilizing the `ChromePdfRenderer` class. Subsequently, employ the `Merge` function to combine this cover page with another PDF, resulting in a unified document. For a comprehensive step-by-step guide on this process, please visit [this tutorial](https://ironpdf.com/how-to/edit-add-cover-page-csharp/).

Moreover, managing page numbering is made simple with `Renderer.RenderingOptions.FirstPageNumber`, ensuring the pagination is accurate and does not include numbering on the cover page.