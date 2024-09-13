using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

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

// Continuous query
while (true)
{
    Console.Write("User Input: ");
    var response = await pdf.Query(Console.ReadLine());
    Console.WriteLine($"\n{response}");
}