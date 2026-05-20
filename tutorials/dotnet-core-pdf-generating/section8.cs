using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section8
    {
        public static void Run()
        {
            // BatchRender.cs — Thread-safe on .NET 8+
            using IronPdf;
            using System.Threading.Tasks;
            
            var htmlSources = Directory.GetFiles("./html", "*.html");
            var renderer    = new ChromePdfRenderer();                 // reuse 1 instance
            
            Parallel.ForEach(htmlSources, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, file =>
            {
                string html = File.ReadAllText(file);
                using PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
                pdf.SaveAs(Path.ChangeExtension(file, ".pdf"));
            });
        }
    }
}