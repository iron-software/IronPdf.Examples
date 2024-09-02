The method `PdfDocument.ExtractAllText` from the IronPDF C# PDF library is highly effective for straightforward text reading tasks in PDFs. It efficiently manages any whitespace and encoding variations found within the PDF documents.

For extracting text from specific pages within a PDF, the `PdfDocument.ExtractTextFromPage` method is used. As demonstrated in the previous example, this method can be employed in a loop to gather text from a designated range of pages.

IronPDF also facilitates the extraction of raw images from PDF documents. Below are the methods available within the `PdfDocument` class for this purpose:

* **`ExtractAllImages`**: This method fetches all images embedded in a PDF and returns them as `IronSoftware.Drawing.AnyBitmap` objects.
* **`ExtractAllRawImages`**: It pulls every embedded image as a collection of raw byte arrays (`byte[]`).
* **`ExtractImagesFromPage`**: This extracts images from a specified page.
* **`ExtractImagesFromPages`**: Similar to `ExtractImagesFromPage`, but applicable to a defined range of pages or a selection of individual pages.
* **`ExtractRawImagesFromPage`** and **`ExtractRawImagesFromPages`**: These methods function akin to the aforementioned image extraction methods but return the images as byte arrays instead of `IronSoftware.Drawing.AnyBitmap` objects.

____