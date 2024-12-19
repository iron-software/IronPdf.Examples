using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section23
    {
        public static void Run()
        {
            var pdf = new PdfDocument("/attachments/design.pdf");
            string html = "<h1> Example Title <h1/>";
            int rotation = 0;
            int watermarkOpacity = 30;
            
            pdf.ApplyWatermark(html, rotation, watermarkOpacity);
        }
    }
}