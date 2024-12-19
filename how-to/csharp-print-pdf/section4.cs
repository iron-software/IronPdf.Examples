using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPrintPdf
{
    public static class Section4
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            await pdf.PrintToFile("PathToFile", false);
        }
    }
}