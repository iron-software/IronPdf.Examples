using IronPdf;
using IronSoftware;
using System.Linq;

// Create a PDF from a URL using a PNG image
string html = @"<img src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi8LuOR6_A98euPLs-JRwoLU7Nc31nVP15rw&s'>";
ChromePdfRenderer renderer = new ChromePdfRenderer();
// Render HTML to PDF
PdfDocument pdf = renderer.RenderHtmlAsPdf(html);

// Access the first image object on the first page
ImageObject image = pdf.Pages.First().ObjectModel.ImageObjects.First();

// To scale the image to 70% of its original size uniformly
image.Scale = new System.Drawing.PointF(0.7f, 0.7f);

// Save the PDF with the scaled image
pdf.SaveAs("scaled_image.pdf");
