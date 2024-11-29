using IronPdf;
namespace ironpdf.PdfImageFlattenCsharp
{
    public class Section1
    {
        public void Run()
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