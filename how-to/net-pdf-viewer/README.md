# C# PDF Viewing Solutions

***Based on <https://ironpdf.com/how-to/net-pdf-viewer/>***


This piece delves into the different techniques available for viewing PDFs within a .NET framework. Presenting PDFs effectively within applications is a common challenge, but there are various solutions available, including the robust PDF Library designed for .NET.

IronPDF offers a PDF viewer specifically tailored for MAUI projects. More details can be found at this link: "[Exploring PDF Views in MAUI for C# .NET](https://www.ironpdf.com/tutorials/pdf-viewing/)."

## ASP.NET & MVC PDF Viewing Options

In web applications, displaying PDFs can be efficiently done in a browser tab or within an iframe. Another excellent choice is leveraging the [pdf.js library by Mozilla](https://mozilla.github.io/pdf.js/), which is an extensive, wholly JavaScript-based PDF viewer.

<hr class="separator">

## WPF C# PDF Viewer

To display PDF documents seamlessly within WPF applications, the **WebBrowser** control can be utilized.

<hr class="separator">

## Windows Forms PDF Viewer

Similarly, when embedding PDFs into Windows Forms (WinForms) applications, the **WebBrowser** control serves as a reliable solution.

<hr class="separator">

## Launching PDFs in the System Default PDF Viewer

To open a PDF file externally from any application, a useful strategy involves using **System.Diagnostics.Process.Start**.

This method commonly launches the PDF in the default web browser equipped to handle PDF files, or in Adobe Acrobat if it is the default PDF viewer.

```cs
using IronPdf;
namespace ironpdf.NetPdfViewer
{
    public class Section1
    {
        public void Execute()
        {
            // This generates a simple PDF from HTML content.
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPdf</h1>");
            
            var outputPath = "GeneratedPdfFile.pdf";
            
            // Here, the PDF is saved to a specified path.
            pdf.SaveAs(outputPath);
            
            // This command will ensure the newly created PDF file is opened in the default viewer.
            System.Diagnostics.Process.Start(outputPath);
        }
    }
}
```

IronPDF caters to MAUI-based projects needing PDF viewing capabilities. Further details can be acquired by clicking this link: "[Exploring PDF Views in MAUI for C# .NET](https://www.ironpdf.com/tutorials/pdf-viewing/)."