using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.HowTo.Async
{
    public static class Section1
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            string[] htmlStrings = {"<h1>Html 1</h1>", "<h1>Html 2</h1>", "<h1>Html 3</h1>"};
            
            // Create an array to store the tasks for rendering
            var renderingTasks = new Task<PdfDocument>[htmlStrings.Length];
            
            for (int i = 0; i < htmlStrings.Length; i++)
            {
                int index = i; // Capturing the loop variable
                renderingTasks[i] = Task.Run(async () =>
                {
                    // Render HTML to PDF
                    return await renderer.RenderHtmlAsPdfAsync(htmlStrings[index]);
                });
            }
            
            // Wait for all rendering tasks to complete
            // await Task.WhenAll(renderingTasks);
        }
    }
}