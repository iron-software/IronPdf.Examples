using IronPdf;
namespace IronPdf.Examples.HowTo.VbNetPdf
{
    public static class Section10
    {
        public static void Run()
        {
            Dim pdfs = New List(Of PdfDocument)
            pdfs.Add(PdfDocument.FromFile("A.pdf"))
            pdfs.Add(PdfDocument.FromFile("B.pdf"))
            pdfs.Add(PdfDocument.FromFile("C.pdf"))
            Dim mergedPdf As PdfDocument = PdfDocument.Merge(pdfs)
            mergedPdf.SaveAs("merged.pdf")
            mergedPdf.Dispose()
            For Each pdf As PdfDocument In pdfs
                pdf.Dispose()
            Next
        }
    }
}