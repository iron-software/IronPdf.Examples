***Based on <https://ironpdf.com/examples/reading-pdf-text/>***

The `PdfDocument.ExtractAllText` functionality of the IronPDF C# PDF library excels in straightforward PDF text extraction operations. It effectively manages inconsistencies in whitespace and encoding found in the original PDF documents.

The `PdfDocument.ExtractTextFromPage` function is specifically designed to extract text from designated pages of a PDF document. In the earlier demonstration, this method was repeatedly employed to obtain text from a certain range of pages.

Furthermore, IronPDF offers capabilities to extract images from PDF files. Utilize the methods listed below from the `PdfDocument` class:

* **`ExtractAllImages`**: This method fetches all images embedded within a PDF, returning them as `IronSoftware.Drawing.AnyBitmap` objects.
* **`ExtractAllRawImages`**: This extracts all images embedded in the PDF as a collection of raw bytes (`byte []`).
* **`ExtractImagesFromPage`**: This extracts images from a specified indexed page within the PDF.
* **`ExtractImagesFromPages`**: This is akin to `ExtractImagesFromPage`, but allows for image extraction from a defined page range or a sequence of specified pages.
* **`ExtractRawImagesFromPage`** and **`ExtractRawImagesFromPages`**: These functions operate similarly to the aforementioned image extraction methods, but they return the images as byte arrays, instead of as `IronSoftware.Drawing.AnyBitmap` objects.

____