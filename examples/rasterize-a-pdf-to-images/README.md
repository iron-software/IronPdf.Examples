***Based on <https://ironpdf.com/examples/rasterize-a-pdf-to-images/>***

Utilize IronPDF to transform a PDF into images, tailored to your specific requirements for file type, dimensions, and DPI settings.

To perform this conversion, utilize the `RasterizeToImageFiles` method on a `PdfDocument` instance. A `PdfDocument` can be loaded via the `PdfDocument.FromFile` method or through any of the [PDF creation methods available for .NET Core](https://ironpdf.com/tutorials/dotnet-core-pdf-generating/).

---

---

The method `RasterizeToImageFiles` processes each page of the PDF, turning them into rasterized images. The first parameter designates the naming pattern for each resultant image. There are also optional parameters available that let you adjust the quality and size of each image. Additionally, the method provides an option to select specific pages of the PDF to be converted into images.

In the provided code example, line 24 showcases the use of the `ToBitmap` method. You can invoke this method on any `PdfDocument` instance to swiftly convert the PDF into `AnyBitmap` objects, which can then be either saved as files or further manipulated as desired.

* * *