using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
using System.Collections.Generic;
using System.IO;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class EditingPDFs : IExecuteApp
    {
        public string OutputPath { get ; set ; }

        public void Run()
        {           
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
            var Renderer = new HtmlToPdf();
            // Join Multiple Existing PDFs into a single document
            var PDFs = new List<PdfDocument>();
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\A.pdf"));
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\B.pdf"));
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\C.pdf"));
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\A.pdf"));
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\B.pdf"));
            PDFs.Add(PdfDocument.FromFile($@"{Directory.GetCurrentDirectory()}\Inputs\C.pdf"));
            PdfDocument PDF = PdfDocument.Merge(PDFs);
            PDF.SaveAs($@"{OutputPath}\merged.pdf");
            // Add a cover page
            PDF.PrependPdf(Renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>"));
            // Remove the last page from the PDF and save again
            PDF.RemovePage(PDF.PageCount - 1);
            PDF.SaveAs($@"{OutputPath}\merged.pdf");
            // Copy pages 5-7 and save them as a new document.
            PDF.CopyPages(2, 5).SaveAs($@"{OutputPath}\exerpt.pdf");
        }
    }
}
