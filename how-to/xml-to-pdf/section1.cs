using IronPdf;
namespace IronPdf.Examples.HowTo.XmlToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            string xslt = @"<?xml version='1.0' encoding='UTF-8'?>
            <xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
            <xsl:template match='/'>
            <html>
            <style>
            td{
              text-align: center;
              padding: 20px;
              border: 1px solid #CDE7F0;
            }
            th{
              color: white;
              padding: 20px;
            }
            </style>
            <body style='font-family: Arial, Helvetica Neue, Helvetica, sans-serif;'>
              <table style='border-collapse: collapse;'>
              <thead>
                <tr>
                  <th colspan='3'>
                    <img style='margin: auto;' src='https://ironsoftware.com/img/svgs/ironsoftware-logo-black.svg'/>
                  </th>
                </tr>
              </thead>
              <tbody>
                <tr bgcolor='#9acd32'>
                  <th bgcolor='#32ab90'>Title</th>
                  <th bgcolor='#f49400'>Feature</th>
                  <th bgcolor='#2a95d5'>Compatible</th>
                </tr>
                <xsl:for-each select='catalog/cd'>
                <tr>
                  <td style='font-weight: bold;'><xsl:value-of select='title'/></td>
                  <td style='background-color: #eff8fb; color: #2a95d5; font-weight: bold;'><xsl:value-of select='feature'/></td>
                  <td><xsl:value-of select='compatible'/></td>
                </tr>
                </xsl:for-each>
                </tbody>
              </table>
            </body>
            </html>
            </xsl:template>
            </xsl:stylesheet>
            ";
            
            string xml = @"<?xml version='1.0' encoding='UTF-8'?>
            <catalog>
              <cd>
                <title>IronPDF</title>
                <feature>Generate, format and manipulate PDFs</feature>
                <compatible>Microsoft Windows, Linux (Debian, CentOS, Ubuntu), MacOS, Docker (Windows, Linux, Azure), Azure (VPS, Webapps, Websites, Functions), AWS</compatible>
              </cd>
              <cd>
                <title>IronOCR</title>
                <feature>OCR engine, input, result</feature>
                <compatible>Microsoft Windows, Linux, MacOS, Docker, Azure, AWS</compatible>
              </cd>
              <cd>
                <title>IronBarcode</title>
                <feature>Format, read and write Barcode</feature>
                <compatible>Microsoft Windows, Linux, MacOS, Docker, Azure, AWS</compatible>
              </cd>
            </catalog>
            ";
            
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
            
            IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
            // options, headers and footers may be set there
            // Render our XML as a PDF via XSLT
            Renderer.RenderHtmlAsPdf(results.ToString()).SaveAs("Final.pdf");
        }
    }
}