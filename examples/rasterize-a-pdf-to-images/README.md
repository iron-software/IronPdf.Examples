***Based on <https://ironpdf.com/examples/rasterize-a-pdf-to-images/>***

To transform a PDF file into images, utilize the `RasterizeToImageFiles` function from IronPDF on a `PdfDocument` instance. Load a PDF either by invoking `PdfDocument.FromFile` or via any of the [PDF generation techniques designed for .NET Core](https://ironpdf.com/tutorials/dotnet-core-pdf-generating/).

The `RasterizeToImageFiles` method processes each PDF page into a raster image. The primary parameter sets the filename pattern for each resultant image. There are additional options to tailor the image quality and size. Also, you can selectively rasterize specific PDF pages if needed.

In our code snippet example on line 24, the `ToBitMap` method is highlighted. Apply this method to any `PdfDocument` object to swiftly convert the document into `AnyBitmap` objects, which can then be either saved as files or further modified.

---

[Discover How to Convert PDFs into Images with IronPDF](https://ironpdf.com/how-to/rasterize-pdf-to-images/)