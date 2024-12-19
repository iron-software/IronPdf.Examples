using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section4
    {
        public static void Run()
        {
            XslCompiledTransform transform = new XslCompiledTransform();
            
            using (XmlReader reader = XmlReader.Create(new StringReader(xslt)))
            {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                transform.Transform(reader, null, results);
            }
            
            IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
            
            // Options, headers, and footers may be set there
            // Render our report as a PDF
            renderer.RenderHtmlFileAsPdf(results.ToString()).SaveAs("Report.pdf");
        }
    }
}