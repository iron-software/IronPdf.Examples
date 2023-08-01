namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;
    using System;
    using System.IO;
    using System.Threading;

    public class HTMLFileToPDFMultiThread : IExecuteApp
    {
        public string OutputPath { get; set; }

        public void Run()
        {
            // init child thread
            ThreadStart childref = new ThreadStart(ChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread = new Thread(childref);
            // start thread
            childThread.Start();
            // init 2nd child thread
            ThreadStart childref1 = new ThreadStart(ChildThread);
            Console.WriteLine("In Main: Creating the Child thread");

            Thread childThread1 = new Thread(childref1);
            //start thread
            childThread1.Start();
            Console.ReadKey();
        }
        public void ChildThread()
        {
            // Create a PDF from an existing HTML using C#
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHTMLFileAsPdfAsync($@"{Directory.GetCurrentDirectory()}\Inputs\InvoiceTemplate.html");

            Console.WriteLine($@"Output {OutputPath}\{Guid.NewGuid()}Invoice.pdf");
            PDF.Result.SaveAs($@"{OutputPath}\{Guid.NewGuid()}Invoice.pdf");
        }
    }
}
