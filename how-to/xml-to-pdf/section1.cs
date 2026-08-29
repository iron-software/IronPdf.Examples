using System.Xml;
using System.Xml.Xsl;
using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.XmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Load and Transform are instance members, and Transform returns void:
            // the transformed HTML comes back through the writer.
            var transform = new XslCompiledTransform();
            transform.Load("template.xslt");

            var html = new StringWriter();
            using (var xml = XmlReader.Create("data.xml"))
            {
                transform.Transform(xml, null, html);
            }

            new IronPdf.ChromePdfRenderer()
                .RenderHtmlAsPdf(html.ToString())
                .SaveAs("output.pdf");
        }
    }
}