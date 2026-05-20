***Based on <https://ironpdf.com/examples/split-pdf-pages-csharp/>***

IronPDF streamlines the process of editing PDF document layouts through capabilities such as page splitting and extraction. With IronPDF, you can effortlessly pull out individual or multiple pages into new `PdfDocument` objects for further modifications or storage. This functionality is primarily executed using the `PdfDocument.CopyPage` method.

Before diving into the mechanics of splitting PDF files, an HTML string must be created which will serve as the basis for our sample PDF. The `ChromePdfRenderer` class takes this HTML string and transforms it into a PDF document using the `RenderHtmlAsPdf` method. The new PDF is then stored in the `PdfDocument` object.

Moving on to the PDF splitting process, we begin by utilizing the `CopyPage(0)` method to duplicate the initial page of the PDF into the `page1Doc` variable. This straightforward method call efficiently extracts the specified page from the PDF. Subsequently, we employ the `SaveAs` method to commit the extracted page as a standalone PDF file.

For extracting a range of pages, the `CopyPages` method comes into play to pull the specified range from the original PDF document. Given that page indexing starts at zero, specifying 1 and 2 targets the second and third pages, respectively. The fetched pages are then held in the `page23Doc` variable. From this point, you can either edit these pages further or use the `SaveAs` method again to save these pages as a separate PDF document.

[Learn to Split Multi-Page PDFs with IronPDF Now](https://ironpdf.com/how-to/split-multipage-pdf/)