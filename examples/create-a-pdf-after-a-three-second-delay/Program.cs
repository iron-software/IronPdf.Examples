using System;
using System.Threading.Tasks;
using System.Diagnostics;
using IronPdf;
class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Starting the PDF generation task...");
        Stopwatch stopwatch = Stopwatch.StartNew();
        await Task.Delay(3000); // Wait for 3 seconds
        GeneratePdf();
        Console.WriteLine("PDF generated successfully.");
    }
    private static void GeneratePdf()
    {
        var htmlToPdf = new ChromePdfRenderer();
        var pdf = htmlToPdf.RenderHtmlAsPdf("<h1>Hello, World!</h1>");
        pdf.SaveAs("HelloWorld.pdf");
    }
}
