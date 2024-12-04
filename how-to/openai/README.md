# Utilizing OpenAI with PDFs

***Based on <https://ironpdf.com/how-to/openai/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/how-tos/icons/chatgpt.svg">
        </div>
    </div>
</div>

OpenAI operates as a research organization specializing in artificial intelligence. It includes the business entity OpenAI LP and its non-profit counterpart, OpenAI Inc. Founded to foster the progression of digital intelligence in a manner that could universally benefit humanity, OpenAI pursues research in numerous AI fields and seeks to create AI technologies that are not only safe and beneficial but also widely accessible.

The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) NuGet package has introduced capabilities for enhancing PDFs with OpenAI, offering features such as summarization, querying, and memorization. This functionality is powered by the Microsoft [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/).

## PDF Summarization Example

For utilizing the OpenAI-based features, you will require an Azure Endpoint and an API Key. The setup for Semantic Kernel can be followed as demonstrated in the code sample below. First, load your PDF file and then apply the `Summarize` method to output a brief summary of the document. A sample PDF file can be obtained from [OpenAI PDF Summarization Example](https://ironsoftware.com/csharp/examples/openai-pdf-summarization/).

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/openai/wikipedia.pdf" width="100%" height="400px">
</iframe>

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Openai
{
    public class Section1
    {
        public async Task Execute()
        {
            // Configuration for OpenAI
            string azureEndpoint = "AzureEndPoint";
            string apiKey = "APIKEY";
            
            var memoryStore = new VolatileMemoryStore();
            var builder = new KernelBuilder()
                .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
                .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
                .WithMemoryStorage(memoryStore);
            var kernel = builder.Build();
            
            // Start IronAI
            IronAI.Initialize(kernel);
            
            // Load the PDF file
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Generate a summary of the PDF
            string summary = await pdf.Summarize(); // Optionally specify the AI instance or directly use it
            Console.WriteLine($"Summary of the document: {summary}");
        }
    }
}
```

### Summary Output Display

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/openai/summarize.webp" alt="Summarize PDF document" class="img-responsive add-shadow">
    </div>
</div>

## Continuous Querying Example

Sometimes, a single query might not meet all needs. The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) package also enables continuous querying capabilities.

```cs
using System.Threading.Tasks;
using IronPdf;
namespace ironpdf.Openai
{
    public class Section2
    {
        public async Task Execute()
        {
            // Configuration for OpenAI
            string azureEndpoint = "AzureEndPoint";
            string apiKey = "APIKEY";
            
            var memoryStore = new VolatileMemoryStore();
            var builder = new KernelBuilder()
                .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
                .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
                .WithMemoryStorage(memoryStore);
            var kernel = builder.Build();
            
            // Start IronAI
            IronAI.Initialize(kernel);
            
            // Load the PDF file
            PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");
            
            // Initiate continuous querying
            while (true)
            {
                Console.Write("Enter query: ");
                var userInput = Console.ReadLine();
                var response = await pdf.Query(userInput);
                Console.WriteLine($"\nResponse: {response}");
            }
        }
    }
}
```