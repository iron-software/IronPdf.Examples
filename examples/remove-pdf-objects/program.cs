using IronPdf;
using IronSoftware.Pdfium.Dom;
using System.Linq;

// Load a PDF file
PdfDocument pdf = PdfDocument.FromFile("sampleObjectsWithImages.pdf");

// Access DOM Objects
IPdfPageObjectModel objects = pdf.Pages.First().ObjectModel;

// Remove first image
objects.ImageObjects.RemoveAt(0);

// Save the modified PDF
pdf.SaveAs("removed.pdf");
