***Based on <https://ironpdf.com/examples/reading-pdf-text/>***

The `PdfDocument.ExtractAllText` function of the IronPDF C# PDF library is ideal for straightforward PDF text extraction operations. It effectively manages whitespace and encoding differences found within source PDF documents.

The method `PdfDocument.ExtractTextFromPage` is employed to extract text from designated pages of a PDF. In the prior example, this function is utilized through a loop to pull text from a certain page range.

IronPDF is also capable of extracting images directly from PDFs. For this task, you can use any of the following methods available in the `PdfDocument` class:

* **`ExtractAllImages`**: This method fetches all images embedded within a PDF and returns them as `IronSoftware.Drawing.AnyBitmap` objects.
* **`ExtractAllRawImages`**: This retrieves all images embedded in the document as a collection of raw byte arrays (`byte[]`).
* **`ExtractImagesFromPage`**: This function pulls images from a specified page.
* **`ExtractImagesFromPages`**: Similar to `ExtractImagesFromPage`, except it operates over a range of pages or a specified list of pages.
* **`ExtractRawImagesFromPage`** and **`ExtractRawImagesFromPages`**: These methods function akin to the prior image extraction methods, but deliver the extracted images in the form of byte arrays instead of as `IronSoftware.Drawing.AnyBitmap` objects.

____