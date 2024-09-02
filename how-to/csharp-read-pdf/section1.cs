using IronPdf;
using IronSoftware.Drawing;
using System.Collections.Generic;

// Select the desired PDF File
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract all text from an pdf
string allText = pdf.ExtractAllText();

// Get all Images
IEnumerable<AnyBitmap> AllImages = pdf.ExtractAllImages();

// Else combine above both functionality using PageCount
for (var index = 0; index < pdf.PageCount; index++)
{
    string Text = pdf.ExtractTextFromPage(index);
    IEnumerable<AnyBitmap> Images = pdf.ExtractImagesFromPage(index);
}