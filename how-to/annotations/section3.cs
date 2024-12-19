using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");
            
            // Remove a single annotation with specified index
            pdf.Annotations.RemoveAt(1);
            
            pdf.SaveAs("removeSingleAnnotation.pdf");
        }
    }
}