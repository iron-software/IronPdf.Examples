using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section16
    {
        public void Run()
        {
            // create a new PDF or load and edit an existing document.
            var pdf = PdfDocument.FromFile("existing.pdf");
            
            // Create a PDF annotation object
            var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
            {
                Title = "This is the major title",
                Contents = "This is the long 'sticky note' comment content...",
                Subject = "This is a subtitle",
                Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
                Opacity = 0.9,
                Printable = false,
                Hidden = false,
                OpenByDefault = true,
                ReadOnly = false,
                Rotatable = true,
            };
            
            // Add the annotation "sticky note" to a specific page and location within any new or existing PDF.
            pdf.Annotations.Add(textAnnotation);
            
            pdf.SaveAs("existing.pdf");
        }
    }
}