using IronPdf;
namespace IronPdf.Examples.HowTo.XmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Convert XML to PDF in one line!
            new IronPdf.ChromePdfRenderer()
                .RenderHtmlAsPdf(
                    XslCompiledTransform.Load("template.xslt")
                        .Transform(XmlReader.Create("data.xml"), new StringWriter())
                        .ToString()
                )
                .SaveAs("output.pdf");
        }
    }
}