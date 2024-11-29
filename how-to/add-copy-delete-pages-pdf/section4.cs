using System.Collections.Generic;
using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section4
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("full_report.pdf");
            
            // Remove a single page
            pdf.RemovePage(0);
            
            // Remove multiple pages
            pdf.RemovePages(new List<int> { 2, 3 });
        }
    }
}