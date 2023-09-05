using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class Annotations : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf

            // create a new PDF or edit an existing document.
            PdfDocument Pdf = PdfDocument.FromFile(@"Inputs\PDFToImages.pdf");
            // Create a PDF annotation object
            var Annotation = new IronPdf.PdfDocument.TextAnnotation()
            {
                Title = "This is the major title",
                Subject = "This is a subtitle",
                Contents = "This is the long 'sticky note' comment content...",
                Icon = PdfDocument.TextAnnotation.AnnotationIcon.Help,
                Opacity = 0.9,
                Printable = false,
                Hidden = false,
                OpenByDefault = true,
                ReadOnly = false,
                Rotateable = true
            };
            // Add the annotation "sticky note" to a specific page and location within any new or existing PDF.
            Pdf.AddTextAnnotation(Annotation, 1, 150, 250);
            Pdf.SaveAs($@"{OutputPath}\Annotations.pdf");
        }
    }
}
