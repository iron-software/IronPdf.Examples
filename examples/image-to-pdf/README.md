Generate a PDF document from one or several image files utilizing the `IronPdf.ImageToPdfConverter` class.

## How to Convert an Image to a PDF in C#

For example, to convert a single image found at `C:\images\example.png` to a PDF document, you can utilize the `IronPdf.ImageToPdfConverter.ImageToPdf` method by providing the path to the image:

```cs
IronPdf.ImageToPdfConverter.ImageToPdf(@"C:\images\example.png").SaveAs("example.pdf");
```

## Combine Multiple Images into One PDF Document

It's also possible to combine several images into one PDF using `System.IO.Directory.EnumerateFiles`, in conjunction with `ImageToPdfConverter.ImageToPdf`:

```cs
string sourceDirectory = @"D:\web\assets";
string destinationFile = "JpgToPDF.pdf";
var imageFiles = Directory.EnumerateFiles(sourceDirectory, "*.jpg");
ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs(destinationFile);
```