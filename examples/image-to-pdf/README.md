***Based on <https://ironpdf.com/examples/image-to-pdf/>***

Create a PDF using images with the `IronPdf.ImageToPdfConverter` class.

## Transform an Image into a PDF in C#

To convert a specific image on your computer, such as the one at `C:\images\example.png`, into a PDF document, use the `IronPdf.ImageToPdfConverter.ImageToPdf` method with the image's file path:

```cs
IronPdf.ImageToPdfConverter.ImageToPdf(@"C:\images\example.png").SaveAs("converted-example.pdf");
```

## Merge Several Images into One PDF Document

To consolidate multiple images into a single PDF file, utilize `System.IO.Directory.EnumerateFiles` in conjunction with `ImageToPdfConverter.ImageToPdf`:

```cs
string sourceDirectory = @"D:\web\assets";
string destinationFile = "CombinedImages.pdf";
var imageFiles = Directory.EnumerateFiles(sourceDirectory, "*.jpg");
ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs(destinationFile);
```

Learn more about [transforming images into PDFs with IronPDF](https://ironpdf.com/how-to/image-to-pdf/) to improve your applications, or visit the [Iron Software website](https://ironsoftware.com) to explore the full range of development tools available, including IronBarcode, IronOCR, and more.