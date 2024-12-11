using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Chroma;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Memory;

// set-up IronPdf
// NOTE 12/11/24: only supported with IronPdf version 2024.9.3 - future support is on the way
IronPdf.License.LicenseKey =
    "<<enter your IronPdf license key here";

// render a fake PDF document
var doc = new PdfDocument("sml-book-draft-latest.pdf");
var indices = new List<int>() {23, 24, 25};

// SETUP AI
var azureEndpoint =
    "<<enter your azure endpoint here>>";
var apiKey =
    "<<enter your azure API key here>>";
var builder = Kernel.CreateBuilder()
    .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
    .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
var kernel = builder.Build();

// SETUP MEMORY
var memory_builder = new MemoryBuilder()
    // optionally use new ChromaMemoryStore("http://127.0.0.1:8000") (see https://github.com/microsoft/semantic-kernel/blob/main/dotnet/notebooks/09-memory-with-chroma.ipynb)
    .WithMemoryStore(new VolatileMemoryStore())
    .WithAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey);
var memory = memory_builder.Build();

// INITIALIZE IRONAI
IronDocumentAI.Initialize(kernel, memory);

// SUMMARIZE the document
Console.WriteLine("Please wait while I summarize the document...");
var summary = await doc.Summarize(indices); // optionally pass AI instance or use AI instance directly
Console.WriteLine($"Document summary: {summary}\n\n");

// CHAT with the document
while (true)
{
    Console.Write("User Input: ");
    var response = await doc.Query(Console.ReadLine(), indices);
    Console.WriteLine($"\n{response}");
}