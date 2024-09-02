using IronPdf;
using System.IO;
using System.Linq;

// One or more images as IEnumerable. This example selects all JPEG images in a specific 'assets' folder.
var imageFiles = Directory.EnumerateFiles("assets").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));

// Converts the images to a PDF and save it.
ImageToPdfConverter.ImageToPdf(imageFiles).SaveAs("composite.pdf");

// Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails
