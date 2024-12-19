***Based on <https://ironpdf.com/examples/image-to-pdf/>***

Create a PDF using Image Files with `IronPdf.ImageToPdfConverter`

## Convert an Image to a PDF in C&#35;

If you have an image stored locally, such as `C:\images\example.png`, you can easily transform it into a PDF document. This is accomplished by utilizing the `IronPdf.ImageToPdfConverter.ImageToPdf` method with the image's file path:

```cs
IronPdf.ImageToPdfConverter.ImageToPdf(@"C:\images\example.png").SaveAs("example.pdf");
```

## Merge Multiple Images into One PDF Document

For batch conversion of multiple images into a single PDF, you can combine the usage of `System.IO.Directory.EnumerateFiles` with `ImageToPdfConverter.ImageToPdf`:

```cs
string sourceDirectory = @"D:\web\assets";
string destinationFile = "JpgToPDF.pdf";
var imageFiles = Directory.EnumerateFiles(sourceDirectory, "*.jpg");
ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs(destinationFile);
```

Discover further insights on [transforming images into PDFs using IronPDF](https://ironpdf.com/how-to/image-to-pdf/) to enhance your software solutions, or visit the [Iron Software website](https://ironsoftware.com) to explore the full range of developer tools available, including IronBarcode, IronOCR, and others.