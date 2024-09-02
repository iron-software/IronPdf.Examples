// Skip the first page and start numbering the second page as page 1
var skipFirstPageAndDontCountIt = allPageIndices.Skip(1);

pdf.AddHtmlHeaders(header, 0, skipFirstPageAndDontCountIt);
pdf.SaveAs("SkipFirstPageAndDontCountIt.pdf");