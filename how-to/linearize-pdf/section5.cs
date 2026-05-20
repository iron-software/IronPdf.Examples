using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.LinearizePdf
{
    public static class Section5
    {
        public static void Run()
        {
            // First example Linearized PDF
            Console.WriteLine(PdfDocument.IsLinearized("linearize.pdf"));
            
            // Second example Linearized PDF
            Console.WriteLine(PdfDocument.IsLinearized("linearize-from-bytes.pdf"));
            
            // Third example Linearized PDF
            Console.WriteLine(PdfDocument.IsLinearized("linearize-stream.pdf"));
            
            // Fourth example Non-Linearized PDF
            Console.WriteLine(PdfDocument.IsLinearized("sample.pdf"));
        }
    }
}