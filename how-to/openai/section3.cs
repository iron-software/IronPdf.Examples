using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.HowTo.Openai
{
    public static class Section3
    {
        public static void Run()
        {
            // Setup OpenAI
            var azureEndpoint = "<<enter your azure endpoint here>>";
            var apiKey = "<<enter your azure API key here>>";
            var builder = Kernel.CreateBuilder()
                .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
                .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
            var kernel = builder.Build();
            
            // Setup Memory
            var memory_builder = new MemoryBuilder()
                // optionally use new ChromaMemoryStore("http://127.0.0.1:8000") (see https://github.com/microsoft/semantic-kernel/blob/main/dotnet/notebooks/09-memory-with-chroma.ipynb)
                .WithMemoryStore(new VolatileMemoryStore())
                .WithAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey);
            var memory = memory_builder.Build();
            
            // Initialize IronAI
            IronDocumentAI.Initialize(kernel, memory);
            
            License.LicenseKey = "<<enter your IronPdf license key here";
            
            // Import PDF document
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Continuous query
            while (true)
            {
                Console.Write("User Input: ");
                var response = await pdf.Query(Console.ReadLine());
                Console.WriteLine($"\n{response}");
            }
        }
    }
}