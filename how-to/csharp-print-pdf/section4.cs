using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.CsharpPrintPdf
{
    public class Section4
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            await pdf.PrintToFile("PathToFile", false);
        }
    }
}