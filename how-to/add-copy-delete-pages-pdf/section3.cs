using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.AddCopyDeletePagesPdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Copy a single page into a new PDF object
            PdfDocument myReport = PdfDocument.FromFile("report_final.pdf");
            PdfDocument copyOfPageOne = myReport.CopyPage(0);
            
            // Copy multiple pages into a new PDF object
            PdfDocument copyOfFirstThreePages = myReport.CopyPages(new List<int> { 0, 1, 2 });
        }
    }
}