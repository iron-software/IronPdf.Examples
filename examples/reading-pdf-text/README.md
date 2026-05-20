***Based on <https://ironpdf.com/examples/reading-pdf-text/>***

The `PdfDocument.ExtractAllText` function within the IronPDF C# PDF library is ideally suited for straightforward PDF text extraction tasks. It effortlessly manages any discrepancies in whitespace and encoding found in the source PDFs.

`PdfDocument.ExtractTextFromPage` enables text extraction from specified pages within a PDF document. In the provided example, this function is applied in a loop to extract text from a defined range of pages.

IronPDF is also capable of extracting images directly from PDF documents. The following methods from the `PdfDocument` class are used for this purpose:

* **`ExtractAllImages`**: This method fetches all images embedded in a PDF and returns them as `IronSoftware.Drawing.AnyBitmap` objects.
* **`ExtractAllRawImages`**: This captures all embedded images as a collection of raw bytes (`byte[]`).
* **`ExtractImagesFromPage`**: Specifically extracts the images from a page identified by its index.
* **`ExtractImagesFromPages`**: Similar to `ExtractImagesFromPage`, but applies to a range of pages or a specified list of pages.
* **`ExtractRawImagesFromPage`** and **`ExtractRawImagesFromPages`**: These function in the same manner as the preceding two methods, but they return the extracted images as byte arrays, instead of as `IronSoftware.Drawing.AnyBitmap` objects.

____

[Learn more about the ExtractTextFromPage Method](https://ironpdf.com/object-reference/api/IronPdf.PdfDocument.html#IronPdf_PdfDocument_ExtractTextFromPage_System_Int32_){.code_content__related-link__doc-cta-link}