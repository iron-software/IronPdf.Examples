using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("A.pdf");

// Get all text
string allText = pdf.ExtractAllText();

// Get all Images
var allImages = pdf.ExtractAllImages();

// Or even find the images and text by page
for (var index = 0 ; index < pdf.PageCount ; index++)
{
    int pageNumber = index + 1;
    string pageText = pdf.ExtractTextFromPage(index);
    var pageImages = pdf.ExtractImagesFromPage(index);
}