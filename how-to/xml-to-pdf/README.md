# Convert XML to PDF in C# and VB.NET

***Based on <https://ironpdf.com/how-to/xml-to-pdf/>***


Transforming XML directly to PDF using C# may appear daunting due to the intricacies involved. A proven strategy involves employing an XSLT as a transformation template. Using this method, XML is transformed into an HTML format through *XSLT*, which subsequently facilitates rendering into a PDF file. Simply put, XSLT functions as an intermediary, translating XML into HTML based on defined templates, adhering closely to established industry standards.

For a more detailed understanding of XSLT transformations, refer to the [Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class) article by Microsoft.

## Quickstart: Convert XML to PDF with IronPDF

Effortlessly transform your XML files into PDF documents utilizing IronPDF. Just a few lines of code are needed to convert XML content to HTML using XSLT, and then produce a PDF from that HTML. This method is perfect for developers requiring seamless and quick integration, allowing them to preserve document formatting and ensure broad platform compatibility.

```cs
:title=Efficient XML to PDF Conversion
var pdfRenderer = new IronPdf.ChromePdfRenderer();
pdfRenderer.RenderHtmlAsPdf(
        XslCompiledTransform.Load("template.xslt")
            .Transform(XmlReader.Create("data.xml"), new StringWriter())
            .ToString()
    )
    .SaveAs("transformed-output.pdf");
```

## Example

The resulting HTML content can then be used to create a PDF document using the [.NET PDF Generator](https://ironpdf.com/docs/). See IronPDF's capabilities in action by downloading the sample project available at this link: [XML to PDF Conversion Example](https://ironpdf.com/downloads/csharp-xml-to-pdf.zip).

```csharp
// This XSLT script outlines how XML data is mapped to HTML format
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

// Example XML data utilized in transformations
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

// Using a transformation object and preparing an HTML format
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

// Utilizing IronPDF to convert HTML into a PDF document
IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();
renderer.RenderHtmlAsPdf(results.ToString()).SaveAs("Final.pdf");
```

---

### Infographic

<div align="center">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/xml-to-pdf/XmlToHtml.webp" alt="XML to PDF Conversion Guide" style="margin-top: 50px; margin-bottom:50px;">
</div>