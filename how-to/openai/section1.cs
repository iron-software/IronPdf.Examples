using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Openai
{
    public class Section1
    {
        public void Run()
        {
            // Setup OpenAI
            string azureEndpoint = "AzureEndPoint";
            string apiKey = "APIKEY";
            
            var volatileMemoryStore = new VolatileMemoryStore();
            var builder = new KernelBuilder()
                .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
                .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
                .WithMemoryStorage(volatileMemoryStore);
            var kernel = builder.Build();
            
            // Initialize IronAI
            IronAI.Initialize(kernel);
            
            // Import PDF document
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Summarize the document
            string summary = await pdf.Summarize(); // optionally pass AI instance or use AI instance directly
            Console.WriteLine($"Document summary: {summary}");
        }
    }
}