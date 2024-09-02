using IronPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Retrieve all JPG and JPEG image paths in the 'images' folder.
IEnumerable<String> imagePaths = Directory.EnumerateFiles("images").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));

// Convert images to a PDF
PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePaths);

// Export the PDF
pdf.SaveAs("imagesToPdf.pdf");