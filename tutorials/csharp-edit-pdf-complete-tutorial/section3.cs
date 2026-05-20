using System.IO;
using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section3
    {
        public static void Run()
        {
            // Read PDF file as stream
            var fileByte = File.ReadAllBytes("sample.pdf");
            
            // Instantiate PDF object from stream
            PdfDocument pdf = new PdfDocument(fileByte);
        }
    }
}