using IronPdf.Annotations;
using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation</h1>");
            
            // Create a PDF annotation object on a specified page index
            TextAnnotation annotation = new TextAnnotation(0)
            {
                Title = "This is the title",
                Contents = "This is the long 'sticky note' comment content...",
                X = 50,
                Y = 700,
            };
            
            // Add the annotation
            pdf.Annotations.Add(annotation);
            pdf.SaveAs("annotation.pdf");
        }
    }
}