# Generate PDF Reports in ASP.NET Using C# or VB

***Based on <https://ironpdf.com/how-to/csharp-pdf-reports/>***


Creating management or database-driven reports from structured sources such as SQL databases is a typical task in .NET development. IronPDF serves as an effective PDF reader in C# and facilitates the exportation and visualization of SSIS reports in PDF format within ASP.NET C# applications.

IronPDF empowers developers to capture snapshots of data and present them as "reports" in the PDF format. It is equally efficient as a PDF parser for C#.

## Quickstart: Generate PDF Reports with IronPDF

Kickstart your PDF generation process using IronPDF with just a few lines of code. This straightforward guide will help you turn HTML content into fully-formatted professional PDF documents with ease. Follow the steps outlined below to easily convert your data into a refined PDF report.

```cs
// Title: Instant PDF Report Creation
new IronPdf.ChromePdfRenderer().RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
```

---

#### Step 1

### 1. Install IronPDF

Use NuGet to install: [IronPdf on NuGet](https://www.nuget.org/packages/IronPdf)

```shell
# Installation command for IronPdf

***Based on <https://ironpdf.com/how-to/csharp-pdf-reports/>***

Install-Package IronPdf
```

Alternatively, you can [download the IronPDF DLL manually](https://ironpdf.com/).

---

#### How to Tutorial

### 2. Methodology for Creating a PDF Report

Start by creating the report as an HTML document, and then use IronPDF to convert the HTML to a PDF. Here’s how you can easily craft a PDF report in ASP.NET C#:

```csharp
// Import IronPdf namespace
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer renderer = new ChromePdfRenderer();

// Render and save the PDF
renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
```

### 3. Convert Crystal Reports to PDF in .NET

First export your Crystal Reports output to HTML as follows:

- File -> Export -> Select HTML 4.0

Then convert the HTML output into a PDF using IronPDF as shown in the methodology section. Here's how it's done:

```csharp
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Customize options including headers and footers
renderer.RenderingOptions.FirstPageNumber = 1;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextHeader.Font = FontTypes.Arial;
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";

renderer.RenderHtmlFileAsPdf(@"c:\path\to\your\report.html").SaveAs("report.pdf");
```

#### 3.1 Converting Crystal Reports to PDF Programmatically with C#

For those looking to automate the conversion from a Crystal Reports (RPT) file to PDF, the following sample provides enhanced control:

```csharp
// Necessary namespaces
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using IronPdf;

public static void ExportRptToPdf(string rptPath, string pdfOutputPath)
{
    ReportDocument rpt = new ReportDocument();
    rpt.Load(rptPath);

    DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions
    {
        DiskFileName = @"c:\tmp\output.html"
    };

    ExportOptions exportOpts = ExportOptions.CreateExportOptions();
    exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
    exportOpts.ExportFormatType = ExportFormatType.HTML40;
    exportOpts.ExportDestinationOptions = diskOpts;

    rpt.Export();

    ChromePdfRenderer renderer = new ChromePdfRenderer();
    renderer.RenderFileAsPdf(diskOpts.DiskFileName).SaveAs(pdfOutputPath);
}
```

### 4. XML Reports

While JSON has become popular, XML is still commonly used for reporting. Use XSLT for transforming XML directly into HTML:

```csharp
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using IronPdf;

public static void ConvertXmlToPdf(string xmlContent, string xsltContent, string outputPath)
{
    XslCompiledTransform transform = new XslCompiledTransform();
    using (XmlReader xsltReader = XmlReader.Create(new StringReader(xsltContent)))
    {
        transform.Load(xsltReader);
    }

    StringWriter htmlOutput = new StringWriter();
    using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlContent)))
    {
        transform.Transform(xmlReader, null, htmlOutput);
    }

    ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
    pdfRenderer.RenderHtmlAsPdf(htmlOutput.ToString()).SaveAs(outputPath);
}
```

Please read the [Convert XML to PDF in C# and VB.NET article](https://ironpdf.com/how-to/xml-to-pdf/) for further details.

### 5. Microsoft SQL Server Reports

Microsoft SQL Server and SQL Server Express offer built-in reporting tools. Learn how to use them effectively with IronPDF to convert SSRS report to PDF:

[Tutorial: How to Locate and Start Reporting Services Tools (SSRS)](https://docs.microsoft.com/en-us/sql/reporting-services/tools/tutorial-how-to-locate-and-start-reporting-services-tools-ssrs?view=sql-server-2017)
[Reports to HTML Conversion](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/rendering-to-html-report-builder-and-ssrs?view=sql-server-2017)

### 6. Report Security

Ensure the security of your PDF report by digitally signing it post-rendering.

```csharp
using IronPdf.Signing;

// Sign a PDF report using a digital certificate
new PdfSignature("path_to_certificate.pfx", "password").SignPdfFile("signed_report.pdf");
```

### 7. ASPX to PDF with ASP.NET Webforms

Leverage the `AspxToPdf` class during the `Form_Load` event to convert ASP.NET pages to PDF:

```csharp
using IronPdf;

public static void ConvertAspxToPdf()
{
    var pdfOptions = new ChromePdfRenderOptions
    {
        EnableJavaScript = false
    };

    AspxToPdf.RenderThisPageAsPdf(AspxToPdf.FileBehavior.SaveOnServer, "output.pdf", pdfOptions);
}
```

Explore more in our comprehensive [ASP.NET ASPX to PDF Tutorial](https://ironpdf.com/how-to/aspx-to-pdf/).