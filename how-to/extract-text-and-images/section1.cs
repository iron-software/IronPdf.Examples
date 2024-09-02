using IronPdf;
using System.IO;

PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Extract text
string text = pdf.ExtractAllText();

// Export the extracted text to a text file
File.WriteAllText("extractedText.txt", text);