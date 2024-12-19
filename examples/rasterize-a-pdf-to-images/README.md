***Based on <https://ironpdf.com/examples/rasterize-a-pdf-to-images/>***

Leverage IronPDF to transform PDF documents into images with your preferred file format, size, and DPI settings.

To perform this conversion, use the `RasterizeToImageFiles` method on a `PdfDocument` object. You can load a PDF document either by employing the `PdfDocument.FromFile` method or by utilizing one of the [PDF creation methods for .NET Core](https://ironpdf.com/tutorials/dotnet-core-pdf-generating/).

***

`RasterizeToImageFiles` processes each PDF page into a raster image. The first parameter determines the naming convention for each output image. Additionally, there are optional parameters available that allow for the customization of image quality and dimensions. It is also possible to specify a subset of pages to be converted into images.

In Line 24 of our code sample, the `ToBitMap` method is shown. This method can be invoked on any `PdfDocument` object to swiftly convert a PDF into `AnyBitmap` objects. These objects can then be either saved as files or further modified as required.

* * *