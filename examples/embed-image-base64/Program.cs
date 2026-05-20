using IronPdf;
using IronSoftware.Drawing;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Import image file as byte
byte[] binaryData = File.ReadAllBytes("sample.jpg");

// Convert byte to base64
string imgDataUri = @"data:image/jpg;base64," + Convert.ToBase64String(binaryData);
string imgHtml = $"<img src='{imgDataUri}'>";

PdfDocument pdf = renderer.RenderHtmlAsPdf(imgHtml);
pdf.SaveAs("embedded_example_1.pdf");
