using IronPdf;
namespace ironpdf.PageNumbers
{
    public class Section1
    {
        public void Run()
        {
            // Create text header
            TextHeaderFooter textHeader = new TextHeaderFooter()
            {
                CenterText = "{page} of {total-pages}"
            };
            
            // Create html footer
            HtmlHeaderFooter htmlFooter = new HtmlHeaderFooter()
            {
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>"
            };
            
            // Render a new PDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");
            
            // Add header and footer
            pdf.AddTextHeaders(textHeader);
            pdf.AddHtmlFooters(htmlFooter);
            
            pdf.SaveAs("pdfWithPageNumber.pdf");
        }
    }
}