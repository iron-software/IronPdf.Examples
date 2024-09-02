using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

// Add custom property to be deleted
pdf.MetaData.CustomProperties.Add("willBeDeleted", "value");

// Remove custom property _ two ways
pdf.MetaData.RemoveMetaDataKey("willBeDeleted");
pdf.MetaData.CustomProperties.Remove("willBeDeleted");