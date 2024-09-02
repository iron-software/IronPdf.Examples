# Converting XML to PDF in C# and VB.NET

Transforming XML directly into PDF using C# can often be intricate. A good strategy involves leveraging XSLT as an intermediate step. By using XSLT transformations, XML data can be successfully converted to HTML, which can then be rendered as a PDF. An XSLT document is crucial as it details the process of turning XML from a specified schema into a precise HTML format using the established XSLT standards. Essentially, XSLT serves as a specialized converter from XML to HTML.

For an in-depth understanding of XSLT, consider exploring the '[Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class)' on Microsoft's resource site.

After transforming to HTML, this HTML can then be transformed into a PDF document using the [.NET PDF Generator](https://ironpdf.com/docs/).

```cs
string xslt = @"<?xml version='1.0' encoding='UTF-8'?>
<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
<xsl:template match='/'>
<html>
<style>
td {
  text-align: center;
  padding: 20px;
  border: 1px solid #CDE7F0;
}
th {
  color: white;
  padding: 20px;
}
</style>
<body style='font-family: Arial, Helvetica Neue, Helvetica, sans-serif;'>
  <table style='border-collapse: collapse;'>
  <thead>
    <tr>
      <th colspan='3'>
        <img style='margin: auto;' src='https://ironsoftware.com/csharp/ocr/object-reference/html/R_Project_IronOcr_Logo.htm'/>
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
    <feature>OCR technology for precise text extraction</feature>
    <compatible>Microsoft Windows, Linux, MacOS, Docker, Azure, AWS</compatible>
  </cd>
  <cd>
    <title>IronBarcode</title>
    <feature>Detailed barcode processing</feature>
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

IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderHtmlAsPdf(results.ToString()).SaveAs("TranslatedPDF.pdf");
```
<hr class="separator">

### Infographic

<div style="margin-top: 50px; margin-bottom: 50px; text-align: center;">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/xml-to-pdf/XmlToHtml.webp" alt="XML to PDF Conversion" class="img-responsive add-shadow" style="margin: auto;">
</div>