using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
renderer.RenderingOptions.FirstPageNumber = 1;

// Header options
renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Helvetica;
renderer.RenderingOptions.TextHeader.FontSize = 12;

// Footer options
renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Arial;
renderer.RenderingOptions.TextFooter.FontSize = 10;
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World<h1>");
pdf.SaveAs("html-string.pdf");