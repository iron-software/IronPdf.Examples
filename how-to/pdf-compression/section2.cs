using IronPdf;
namespace IronPdf.Examples.HowTo.PdfCompression
{
    public static class Section2
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("table.pdf");
            
            // Compress tree structure in PDF
            pdf.CompressStructTree();
            
            pdf.SaveAs("compressedTable.pdf");
        }
    }
}