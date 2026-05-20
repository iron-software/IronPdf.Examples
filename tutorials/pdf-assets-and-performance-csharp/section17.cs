using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section17
    {
        public static void Run()
        {
            // Select the desired PDF File
            PdfDocument pdf = PdfDocument.FromFile("before.pdf");
            
            // Flatten the pdf
            pdf.Flatten();
            
            // Save as a new file
            pdf.SaveAs("after_flatten.pdf");
        }
    }
}