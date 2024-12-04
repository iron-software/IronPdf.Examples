using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section18
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");
            
            TextStamper stamper1 = new TextStamper
            {
                Text = "Hello World! Stamp One Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 100,
                IsBold = true,
                IsItalic = true,
                VerticalAlignment = VerticalAlignment.Top
            };
            
            TextStamper stamper2 = new TextStamper()
            {
                Text = "Hello World! Stamp Two Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 30,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            Stamper[] stampersToApply = { stamper1, stamper2 };
            pdf.ApplyMultipleStamps(stampersToApply);
            pdf.ApplyStamp(stamper2);
        }
    }
}