using IronPdf;
namespace IronPdf.Examples.HowTo.PdfImageFlattenCsharp
{
    public static class Section1
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