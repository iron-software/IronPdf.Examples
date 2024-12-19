using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section6
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            List<PdfDocument> PDFs = new List<PdfDocument>();
            PDFs.Add(PdfDocument.FromFile("1.pdf"));
            PDFs.Add(PdfDocument.FromFile("2.pdf"));
            PDFs.Add(PdfDocument.FromFile("3.pdf"));
            using PdfDocument PDF = PdfDocument.Merge(PDFs);
            PDF.SaveAs("mergedFile.pdf");
            foreach (PdfDocument pdf in PDFs)
            {
                pdf.Dispose();
            }
        }
    }
}