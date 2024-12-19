using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToHtml
{
    public static class Section1
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Convert PDF to HTML string
            string html = pdf.ToHtmlString();
            Console.WriteLine(html);
            
            // Convert PDF to HTML file
            pdf.SaveAsHtml("myHtml.html");
        }
    }
}