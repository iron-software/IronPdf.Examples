using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section9
    {
        public static void Run()
        {
            // Create a PDF from an existing HTML
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    MarginTop = 50, //millimeters
                    MarginBottom = 50,
                    CssMediaType = IronPdf.Rendering.PdfCssMediaType.Print,
                    TextHeader = new TextHeaderFooter
                    {
                        CenterText = "{pdf-title}",
                        DrawDividerLine = true,
                        FontSize = 16
                    },
                    TextFooter = new TextHeaderFooter
                    {
                        LeftText = "{date} {time}",
                        RightText = "Page {page} of {total-pages}",
                        DrawDividerLine = true,
                        FontSize = 14
                    }
                }
            };
            
            var pdf = renderer.RenderHtmlFileAsPdf("assets/TestInvoice1.html");
            pdf.SaveAs("Invoice.pdf");
            
            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start("Invoice.pdf");
        }
    }
}