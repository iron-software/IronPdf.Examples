# Creating PDF Reports in ASP.NET Using C# or VB

Creating reports from structured databases, like SQL, is a typical development task in .NET. IronPDF serves as an effective tool for reading and exporting SSRS reports into the PDF format in ASP.NET with C#.

IronPDF allows for rendering snapshots of data into PDF "reports". It also functions as a parser for PDF C# format.


<hr class="separator">

<h4 class="tutorial-segment-title">Step 1</h4>

## 1. Installation of IronPDF
Use the NuGet Package Manager: [IronPDF on NuGet](https://www.nuget.org/packages/IronPdf)
```shell
Install-Package IronPdf
```
Alternatively, the IronPDF DLL can be [obtained here](https://ironsoftware.com/packages/IronPdf.zip).

<hr class="separator">

<h4 class="tutorial-segment-title">Tutorial Guide</h4>

## 2. Creating a PDF Report

Begin by crafting the report as an HTML document. Following that, convert the HTML into a PDF with IronPDF. This guide illustrates the steps needed to develop a PDF report in ASP.NET C#.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

renderer.RenderHtmlFileAsPdf("report.html").SaveAs("report.pdf");
```

## 3. Convert Crystal Reports to PDF using .NET

In Crystal Reports, choose to export to HTML:

File -> Export -> choose HTML 4.0

Subsequently, transform the HTML report into PDF using the example C# code above.

Example below:

```cs
using IronPdf;
using IronSoftware.Drawing;

ChromePdfRenderer renderer = new ChromePdfRenderer();

// Easily add a page header
renderer.RenderingOptions.FirstPageNumber = 1;
renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
renderer.RenderingOptions.TextHeader.CenterText = "{url}";
renderer.RenderingOptions.TextHeader.Font = FontTypes.Arial;
renderer.RenderingOptions.TextHeader.FontSize = 12;

// Add a matching footer
renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
renderer.RenderingOptions.TextFooter.Font = FontTypes.Arial;
renderer.RenderingOptions.TextFooter.FontSize = 10;
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";

renderer.RenderHtmlFileAsPdf(@"c:\my\exported\report.html").SaveAs("report.pdf");
```

### 3.1 Programmatic Crystal Reports to PDF Conversion in C#

Here's how you can programmatically create a PDF from a Crystal Reports (RPT) file for deeper control.

```cs
CrystalDecisions.Shared.DiskFileDestinationOptions diskOpts = new CrystalDecisions.Shared.ExportOptions.CreateDiskFileDestinationOptions();
CrystalDecisions.Shared.ExportOptions exportOpts = new CrystalDecisions.Shared.ExportOptions();
CrystalDecisions.Shared.CharacterSeparatedValuesFormatOptions csvExpOpts = new CrystalDecisions.Shared.CharacterSeparatedValuesFormatOptions();
CrystalDecisions.Shared.HTMLFormatOptions HTMLExpOpts = new CrystalDecisions.Shared.HTMLFormatOptions();

rpt.Load(@"c:\my\report.rpt");
diskOpts.DiskFileName = @"c:\tmp\html\b.html";

exportOpts.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile;
exportOpts.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.HTML40;
exportOpts.ExportDestinationOptions = diskOpts;

HTMLExpOpts.HTMLBaseFolderName = @"c:\tmp\html\b.html";
HTMLExpOpts.HTMLEnableSeparatedPages = false;
HTMLExpOpts.UsePageRange = false;
HTMLExpOpts.HTMLHasPageNavigator = false;

System.IO.Stream htmlStream;
byte[] htmlByteArray = null;

htmlStream = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.HTML40);
htmlByteArray = new byte[htmlStream.Length];
htmlStream.Read(htmlByteArray, 0, Convert.ToInt32(htmlStream.Length - 1));
System.IO.File.WriteAllBytes(diskOpts.DiskFileName, htmlByteArray);

IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
Renderer.RenderFileAsPdf(diskOpts.DiskFileName).SaveAs("Report.pdf");

Console.WriteLine("Report Written To {0}", Path.GetFullPath(diskOpts.DiskFileName));
```

## 4. Styling XML Reports

While exporting report data as XML is common, an advanced approach involves using XSLT to convert XML directly into HTML. The `XslCompiledTransform` class can be used for this conversion, as described in '[Using the XslCompiledTransform Class](https://docs.microsoft.com/en-us/dotnet/standard/data/xml/using-the-xslcompiledtransform-class)'.

The resultant HTML can then be converted into a PDF with IronPDF:

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

Learn more about the XML to PDF conversion in C# and VB.NET [here](https://ironsoftware.com/how-to/xml-to-pdf/).

## 5. SQL Server PDF Reports

Utilize Microsoft's SQL Server tools for report generation. These reports can be HTML formatted and then converted to PDF with IronPDF, promoting effective report management and security.

Further integration details are found [here](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/rendering-to-html-report-builder-and-ssrs?view=sql-server-2017).

## 6. Securing PDF Reports

To secure a PDF report against alterations, digital signing is recommended after rendering and saving the PDF.

```cs
using IronPdf.Signing;

// Digitally sign a PDF report file using a specific certificate
new PdfSignature("IronSoftware.pfx", "123456").SignPdfFile("signed.pdf");
```

## 7. Converting ASPX to PDF in ASP.NET Webforms

In ASP.NET Webforms, the simplest method for delivering HTML content is utilizing the `IronPdf.AspxToPdf` class during the `Form_Load` event.

```cs
var AspxToPdfOptions = new IronPdf.ChromePdfRenderOptions()
{
  EnableJavaScript = false,
  // Additional options can be configured here
};

IronPdf.AspxToPdf.RenderThisPageAsPdf(IronPdf.AspxToPdf.FileBehavior.Attachment, "Report.pdf", AspxToPdfOptions);
```

For more insights, refer to our comprehensive [ASP.NET ASPX to PDF Tutorial](https://ironsoftware.com/how-to/aspx-to-pdf/). We hope this guide aids your understanding in generating PDF reports using ASP.NET with either C# or VB.NET.