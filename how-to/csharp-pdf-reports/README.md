# Creating PDF Reports in ASP.NET Using C# or VB

***Based on <https://ironpdf.com/how-to/csharp-pdf-reports/>***


Creating management or database reports from structured sources like SQL databases is a frequent task in .NET development. IronPDF serves as a robust tool for reading and parsing PDFs, allowing developers to visualize and convert SSIS reports into PDF format within ASP.NET applications effectively.

IronPDF enables you to capture snapshots of data and present them as PDF "reports," functioning seamlessly as a PDF parser in C#.

<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Installing IronPDF
Add IronPDF to your project using NuGet: [https://www.nuget.org/packages/IronPdf](https://www.nuget.org/packages/IronPdf)
```shell
/Install-Package IronPdf
```
Alternatively, you can [download the IronPDF DLL manually](https://ironpdf.com/packages/IronPdf.zip).

<hr class="separator">

<h4 class="tutorial-segment-title">How to Tutorial</h4>

## 2. Method to Create a PDF Report

Begin by constructing the report in HTML format. Subsequently, use IronPDF to convert this HTML into a PDF document. This tutorial provides a detailed demonstration of generating a PDF report using ASP.NET C#.

```cs
using IronPdf;
namespace ironpdf.CsharpPdfReports
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
        }
    }
}
```

## 3. Convert Crystal Reports into PDF Using .NET

Initially, export your Crystal Reports as HTML:

File -> Export -> Select HTML 4.0

These HTML reports can then be converted to PDF using the C# methodology shown above.

Here’s an example:

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.CsharpPdfReports
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Easily add a header to every page
            renderer.RenderingOptions.FirstPageNumber = 1;
            renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
            renderer.RenderingOptions.TextHeader.CenterText = "{url}";
            renderer.RenderingOptions.TextHeader.Font = FontTypes.Arial;
            renderer.RenderingOptions.TextHeader.FontSize = 12;
            
            // Incorporate a footer as well
            renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
            renderer.RenderingOptions.TextFooter.Font = FontTypes.Arial;
            renderer.RenderingOptions.TextFooter.FontSize = 10;
            renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
            renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
            
            renderer.RenderHtmlFileAsPdf(@"c:\my\exported\report.html").SaveAs("report.pdf");
        }
    }
}
```

### 3.1 Programmatically Convert Crystal Reports to PDF with C#

You can also handle RPT files programmatically to create PDFs, offering more control over the process.

```cs
using System.IO;
using IronPdf;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

ReportDocument rpt = new ReportDocument();

DiskFileDestinationOptions diskOpts = new DiskFileDestinationOptions()
{
    DiskFileName = @"c:\tmp\html\b.html"
};

ExportOptions exportOpts = new ExportOptions();

HTMLFormatOptions HTMLExpOpts = new HTMLFormatOptions();

rpt.Load(@"c:\my\report.rpt");

exportOpts.ExportDestinationType = ExportDestinationType.DiskFile;
exportOpts.ExportFormatType = ExportFormatType.HTML40;
exportOpts.ExportDestinationOptions = diskOpts;

HTMLExpOpts.HTMLBaseFolderName = @"c:\tmp\html\b.html";
HTMLExpOpts.HTMLEnableSeparatedPages = false;

Stream htmlStream;
byte[] htmlByteArray;

htmlStream = rpt.ExportToStream(ExportFormatType.HTML40);

htmlByteArray = new byte[htmlStream.Length];

htmlStream.Read(htmlByteArray, 0, Convert.ToInt32(htmlStream.Length - 1));

File.Create(diskOpts.DiskFileName, Convert.ToInt32(htmlStream.Length - 1)).Close();

File.OpenWrite(diskOpts.DiskFileName).Write(htmlByteArray, 0, Convert.ToInt32(htmlStream.Length - 1));

File.SetAttributes(diskOpts.DiskFileName, FileAttributes.Directory);

htmlStream.Close();

IronPdf.ChromePdfRenderer renderer = new IronPdf.ChromePdfRenderer();

renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextFooter.DrawDividerLine = true;

renderer.RenderFileAsPdf(diskOpts.DiskFileName).SaveAs("Report.pdf");

Console.WriteLine("Report Written To {0}", Path.GetFullPath(diskOpts.DiskFileName));
```

## 4. Handling XML Reports

While JSON has become a more common format, exporting data as XML persists in certain settings. To style XML data, one could parse the XML and generate HTML. However, a more direct approach utilizes XSLT to convert XML to HTML.

Consult the documentation on [Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class) and then render the resulting HTML to PDF with IronPDF:

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

renderer.RenderHtmlFileAsPdf(results.ToString()).SaveAs("Report.pdf");
```