// Skip the first page
var skipFirstPage = allPageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 1, skipFirstPage);
pdf.SaveAs("SkipFirstPage.pdf");