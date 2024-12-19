using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_CsharpPrintPdf Copy
{
    public static class Section1
    {
        public static void Run()
        {
            /**
            Create and Print PDF
            anchor-create-a-pdf-and-print
            **/
            using IronPdf;
            
            // Create a new PDF and print it
            
            IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
            
            using PdfDocument Pdf = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            
            // Send the PDF to the default printer to print
            
            Pdf.Print();
            
            //For advanced silent real-world printing options, use PdfDocument.GetPrintDocument
            
            //Remember to add an assembly reference to System.Drawing.dll
            
             System.Drawing.Printing.PrintDocument PrintDocYouCanWorkWith = Pdf.GetPrintDocument();
        }
    }
}