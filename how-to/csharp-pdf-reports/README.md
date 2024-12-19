# Generating PDF Reports in ASP.NET Using C# or VB

***Based on <https://ironpdf.com/how-to/csharp-pdf-reports/>***


Creating management or database reports from structured sources like SQL is a routine task in .NET development. IronPDF excels as a PDF reader in C# and provides capabilities to visualize and convert SSIS reports into PDFs within ASP.NET C# applications.

IronPDF is also effective for converting data snapshots into PDF reports, serving as a proficient PDF parser in C#.

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Setting Up IronPDF
Install via NuGet: [IronPdf on NuGet](https://www.nuget.org/packages/IronPdf)
```shell
/Install-Package IronPdf
```
Alternatively, you can [download the IronPDF DLL manually](https://ironpdf.com/packages/IronPdf.zip).

<hr class="separator">

<h4 class="tutorial-segment-title">How-to Tutorial</h4>

## 2. Creating a PDF Report

The standard approach involves generating an HTML document which is then converted to PDF using IronPDF. Here, we demonstrate how to craft a PDF report in ASP.NET C#:

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
```

## 3. Converting Crystal Reports to PDF

First, in Crystal Reports, export your report as HTML:

File -> Export -> choose HTML 4.0

Then, convert the HTML output to PDF using the previously shown C# code:

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Easily add a header
renderer.RenderingOptions.FirstPageNumber = 1;
renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextHeader.Font = FontTypes.Arial;
renderer.RenderingOptions.TextHeader.FontSize = 12;

// And a footer
renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
renderer.RenderingOptions.TextFooter.Font = FontTypes.Arial;
renderer.RenderingOptions.TextFooter.FontSize = 10;

renderer.RenderHtmlFileAsPdf(@"c:\my\exported\report.html").SaveAs("report.pdf");
```

### 3.1 Automated Crystal Reports Conversion to PDF

For a more automated approach using C# to convert Crystal Reports (RPT) files to PDF:

```cs
var diskOpts = new CrystalDecisions.Shared.DiskFileDestinationOptions()
{
    DiskFileName = @"c:\tmp\html\output.html"
};

var exportOpts = new CrystalDecisions.Shared.ExportOptions
{
    ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile,
    ExportFormatType = CrystalDecisions.Shared.ExportFormatType.HTML40,
    ExportDestinationOptions = diskOpts
};

rpt.Load(@"c:\my\report.rpt");
rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.HTML40, diskOpts.DiskFileName);

IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();

// Add page elements
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";

renderer.RenderFileAsPdf(diskOpts.DiskFileName).SaveAs("FinalReport.pdf");

Console.WriteLine("PDF created at: {0}", Path.GetFullPath("FinalReport.pdf"));
```

## 4. Transitioning XML to PDF

While XML data export is prevalent, a more modern approach involves using XSLT for transformation:

```cs
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
renderer.RenderHtmlFileAsPdf(results.ToString()).SaveAs("StyledReport.pdf");
```

Further reading: [Convert XML to PDF in C# and VB.NET](https://ironpdf.com/how-to/xml-to-pdf/)

## 5. SQL Server Reports

Microsoft SQL Server and SQL Server Express include tools for reporting. Learn how to harness these reports in ASP.NET for PDF conversion with IronPDF through [Reporting Services Tools Tutorial (SSRS)](https://docs.microsoft.com/en-us/sql/reporting-services/tools/tutorial-how-to-locate-and-start-reporting-services-tools-ssrs?view=sql-server-2017) and [HTML Rendering](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/rendering-to-html-report-builder-and-ssrs?view=sql-server-2017).

## 6. Securing PDF Reports

Ensure your PDF reports remain unchanged and secure by digitally signing them post-render:

```cs
using IronPdf.Signing;

new PdfSignature("IronSoftware.pfx", "123456").SignPdfFile("secured.pdf");
```

Create a digital signature file using Adobe Acrobat Reader on various platforms if needed.

## 7. Converting ASPX to PDF

Serving HTML content in ASP.NET WebForms is streamlined using IronPdf:

```cs
var options = new IronPdf.ChromePdfRenderOptions
{
    EnableJavaScript = false
};

IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "WebReport.pdf", options);
```

Explore the full [ASP.NET ASPX to PDF Tutorial](https://ironpdf.com/how-to/aspx-to-pdf/) for more details.

We hope