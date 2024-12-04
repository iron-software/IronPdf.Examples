using IronPdf;
namespace ironpdf.PdfCompression
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("table.pdf");
            
            // Compress tree structure in PDF
            pdf.CompressStructTree();
            
            pdf.SaveAs("compressedTable.pdf");
        }
    }
}