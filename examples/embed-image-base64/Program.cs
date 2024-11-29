using IronPdf;
using IronSoftware.Drawing;
using System;
using System.IO;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Import image file as byte
byte[] pngBinaryData = File.ReadAllBytes("use your image here");
byte[] base64Bytes = new byte[3]; // Use your own here

// Convert byte to base64
string imgDataUri = @"data:image/png;base64," + Convert.ToBase64String(base64Bytes);
string imgHtml = $"<img src='{imgDataUri}'>";

PdfDocument pdf = renderer.RenderHtmlAsPdf(imgHtml);
pdf.SaveAs("embedded_example_1.pdf");
