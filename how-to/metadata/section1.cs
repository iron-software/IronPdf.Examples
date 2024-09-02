using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

// Access the MetaData class and set the pre-defined metadata properties.
pdf.MetaData.Author = "Iron Software";
pdf.MetaData.CreationDate = DateTime.Today;
pdf.MetaData.Creator = "IronPDF";
pdf.MetaData.Keywords = "ironsoftware,ironpdf,pdf";
pdf.MetaData.ModifiedDate = DateTime.Now;
pdf.MetaData.Producer = "IronPDF";
pdf.MetaData.Subject = "Metadata Tutorial";
pdf.MetaData.Title = "IronPDF Metadata Tutorial";

pdf.SaveAs("pdf-with-metadata.pdf");