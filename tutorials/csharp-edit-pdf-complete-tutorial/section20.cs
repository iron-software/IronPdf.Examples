using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section20
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<p>Hello World, example HTML body.</p>");
            
            HtmlStamper stamper = new HtmlStamper($"<p>Example HTML Stamped</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
            {
                HorizontalOffset = new Length(-3, MeasurementUnit.Inch),
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            pdf.ApplyStamp(stamper);
        }
    }
}