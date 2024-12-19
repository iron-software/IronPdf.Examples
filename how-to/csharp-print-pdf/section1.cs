using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPrintPdf
{
    public static class Section1
    {
        public static void Run()
        {
            // Create a new PDF and print it
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            
            // Print PDF from default printer
            await pdf.Print();
            
            // For advanced silent real-world printing options, use PdfDocument.GetPrintDocument
            // Remember to add an assembly reference to System.Drawing.dll
            System.Drawing.Printing.PrintDocument PrintDocYouCanWorkWith = pdf.GetPrintDocument();
        }
    }
}