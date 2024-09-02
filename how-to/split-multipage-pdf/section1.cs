using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multiPage.pdf");

for (int idx = 0; idx < pdf.PageCount; idx++)
{
    // Create new document for each page
    PdfDocument outputDocument = pdf.CopyPage(idx);

    string fileName = @$"multiPage - Page {idx + 1}_tempfile.pdf";

    // Export to new file
    outputDocument.SaveAs(fileName);
}