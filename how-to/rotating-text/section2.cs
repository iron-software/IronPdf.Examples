using IronPdf;
namespace ironpdf.RotatingText
{
    public class Section2
    {
        public void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            
            var pdf = renderer.RenderHtmlAsPdf(@"
            <html>
            <head>
             <style>
              .rotated{
              -webkit-transform: rotate(-180deg);
              width:400;
              height:400;
              }
            </style>
            </head>
            <body>
            <p class='rotated'>Rotated Text</p>
            </body>
            </html>
            ");
            
            pdf.SaveAs("rotated.pdf");
        }
    }
}