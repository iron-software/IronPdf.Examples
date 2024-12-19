# Convert XML to PDF in C# and VB.NET

***Based on <https://ironpdf.com/how-to/xml-to-pdf/>***


Transforming XML files directly to PDF using C# can be a complex endeavor. A highly effective method for such conversions involves using XSLT as a transformation layer. This technique enables translation of XML into a precise HTML format using *XSLT* transformations. Essentially, XSLT files dictate how XML content should be formatted into HTML, providing a reliable and established method for such conversions. In essence, XSLT serves as the intermediary translator from XML to HTML.

For further details on XSLT transformations, please refer to the [Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class) article by Microsoft.

The HTML codes generated or the HTML files can then be seamlessly converted to PDF format using IronPDF's [.NET PDF Generator](https://ironpdf.com/docs/). You can also explore IronPDF's functionality for XML to PDF conversions by downloading the sample project from this [XML to PDF Conversion Example](https://ironpdf.com/downloads/csharp-xml-to-pdf.zip).

```cs
string xslt = @"<?xml version='1.0' encoding='UTF-8'?>
<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
<xsl:template match='/'>
<html>
<head>
  <style>
    td {
      text-align: center;
      padding: 20px;
      border: 1px solid #CDE7F0;
    }
    th {
      background-color: #555;
      color: white;
      padding: 20px;
    }
  </style>
</head>
<body style='font-family: Arial, Helvetica Neue, Helvetica, sans-serif;'>
  <table style='border-collapse: collapse; width: 100%;'>
    <thead>
      <tr>
        <th colspan='3'>
          <img src='https://ironsoftware.com/img/svgs/ironsoftware-logo-black.svg' alt='Iron Software Logo' style='display: block; margin: auto;'/>
        </th>
      </tr>
    </thead>
    <tbody>
      <tr bgcolor='#9acd32'>
        <th bgcolor='#32ab90'>Title</th>
        <th bgcolor='#f49400'>Feature</th>
        <th bgcolor='#2a95d5'>Compatibility</th>
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
    <feature>Create, format and manipulate PDFs</feature>
    <compatible>Platform independent</compatible>
  </cd>
  <cd>
    <title>IronOCR</title>
    <feature>Optical Character Recognition capabilities</feature>
    <compatible>Platform independent</compatible>
  </cd>
  <cd>
    <title>IronBarcode</title>
    <feature>Encode and decode barcodes</feature>
    <compatible>Platform independent</compatible>
  </cd>
</catalog>
";

XslCompiledTransform transform = new XslCompiledTransform();
using (XmlReader xmlReader = XmlReader.Create(new StringReader(xslt)))
{
    transform.Load(xmlReader);
}
StringWriter htmlOutput = new StringWriter();
using (XmlReader xmlReader = XmlReader.Create(new StringReader(xml)))
{
    transform.Transform(xmlReader, null, htmlOutput);
}

IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
// Set desired options, headers, and footers here
// Generate PDF from HTML output
renderer.RenderHtmlAsPdf(htmlOutput.ToString()).SaveAs("FinalizedDocument.pdf");
```

<hr class="separator">

### Infographic

<div style="text-align: center; margin-top: 50px; margin-bottom:50px;">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/xml-to-pdf/XmlToHtml.webp" alt="XML to PDF Conversion" style="max-width: 100%; box-shadow: 0 4px 8px rgba(0,0,0,0.1);">
</div>