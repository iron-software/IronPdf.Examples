using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section3
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            
            // Remove the last page from the PDF and save again
            pdf.RemovePage(pdf.PageCount - 1);
            pdf.SaveAs("report_minus_one_page.pdf");
        }
    }
}