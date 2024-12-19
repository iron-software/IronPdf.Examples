using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section4
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");
            
            // Remove all annotaions on a specified page
            pdf.Annotations.RemoveAllAnnotationsForPage(0);
            
            // Remove all annotaions on the document
            pdf.Annotations.Clear();
            
            pdf.SaveAs("removeAllAnnotation.pdf");
        }
    }
}