# Convert XML to PDF in C# and VB.NET

***Based on <https://ironpdf.com/how-to/xml-to-pdf/>***


Transforming XML directly into PDF within the .NET framework, particularly using C# or VB.NET, can offer considerable challenges. The most effective approach begins with utilizing XSLT as a transformation mechanism. By employing XSLT, XML data is first converted to HTML format. XSLT documents function by mapping XML from a specific schema into a precise HTML structure, making them a robustly established standard. Essentially, XSLT serves as a tailor-made mechanism to convert XML into HTML.

For more insights into XSLT transformation, consider reading the article on [Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class) provided by Microsoft.

Once XML is transformed into HTML using XSLT, the HTML can then be converted into a PDF document using the [.NET PDF Generator](https://ironpdf.com/docs/). Check out an example of how to perform this XML to PDF conversion with IronPDF's demo project available for download at [XML to PDF Conversion Example](https://ironpdf.com/downloads/csharp-xml-to-pdf.zip).

```cs
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
  background-color: #506378;
  color: white;
  padding: 20px;
  text-align: center;
}
</style>
<body style='font-family: Arial, Helvetica Neue, Helvetica, sans-serif;'>
  <table style='width: 100%; border-collapse: collapse;'>
  <thead>
    <tr>
      <th colspan='3'>
        <img src='https://ironsoftware.com/img/svgs/ironsoftware-logo-black.svg' alt='Iron Software Logo' style='margin: auto; display: block;'/>
      </th>
    </tr>
  </thead>
  <tbody>
    <tr bgcolor='#687864'>
      <th>Title</th>
      <th>Feature</th>
      <th>Compatibility</th>
    </tr>
    <xsl:for-each select='catalog/cd'>
    <tr>
      <td style='font-weight: bold;'><xsl:value-of select='title'/></td>
      <td style='background-color: #f0f8ff; color: #333; font-weight: bold;'><xsl:value-of select='feature'/></td>
      <td style='color: #666;'><xsl:value-of select='compatible'/></td>
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
    <feature>Enables PDF generation and manipulation</feature>
    <compatible>Supports various platforms such as Microsoft Windows, Linux distros, MacOS, alongside Docker and cloud services like Azure and AWS</compatible>
  </cd>
  <cd>
    <title>IronOCR</title>
    <feature>Provides OCR capabilities and handling</feature>
    <compatible>Works on Windows, Linux, MacOS, and both Docker and cloud services</compatible>
  </cd>
  <cd>
    <title>IronBarcode</title>
    <feature>Supports encoding and decoding of barcodes</feature>
    <compatible>Suitable for Windows, Linux, and MacOS; Integrated easily with Docker setups and cloud infrastructures</compatible>
  </cd>
</catalog>
";

XslCompiledTransform transformer = new XslCompiledTransform();
using (XmlReader xsltReader = XmlReader.Create(new StringReader(xslt)))
{
    transformer.Load(xsltReader);
}
StringWriter transformed = new StringWriter();
using (XmlReader xmlReader = XmlReader.Create(new StringReader(xml)))
{
    transformer.Transform(xmlReader, null, transformed);
}

IronPdf.ChromePdfRenderer pdfRenderer = new IronPdf.ChromePdfRenderer();
// Additional rendering options and configurations can be applied below
// Convert the HTML from XSLT to PDF format
pdfRenderer.RenderHtmlAsPdf(transformed.ToString()).SaveAs("TransformedPDF.pdf");
```

---

#### Infographic

<div style="text-align:center; margin: 50px 0;">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/xml-to-pdf/XmlToHtml.webp" alt="XML to PDF Conversion Infographic" style="box-shadow: 0px 8px 15px rgba(0,0,0,0.1);">
</div>