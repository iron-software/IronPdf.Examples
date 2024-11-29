using IronPdf;
using IronSoftware.Drawing;
using System.Collections.Generic;

// Extracting Image and Text content from Pdf Documents

// open a 128 bit encrypted PDF
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Get all text to put in a search index
string text = pdf.ExtractAllText();

// Get all Images
var allImages = pdf.ExtractAllImages();

// Or even find the precise text and images for each page in the document
for (var index = 0 ; index < pdf.PageCount ; index++)
{
    int pageNumber = index + 1;
    text = pdf.ExtractTextFromPage(index);
    List<AnyBitmap> images = pdf.ExtractBitmapsFromPage(index);
    //...
}
