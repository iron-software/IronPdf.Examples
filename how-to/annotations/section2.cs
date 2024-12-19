using System.Linq;
using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section2
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("annotation.pdf");
            
            // Retrieve annotation collection
            PdfAnnotationCollection annotationCollection = pdf.Annotations;
            
            // Select the first annotation
            TextAnnotation annotation = (TextAnnotation)annotationCollection.First();
            
            // Edit annotation
            annotation.Title = "New title";
            annotation.Contents = "New content...";
            annotation.X = 150;
            annotation.Y = 800;
            
            pdf.SaveAs("editedAnnotation.pdf");
        }
    }
}