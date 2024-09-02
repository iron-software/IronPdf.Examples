# Utilizing OpenAI with PDF Management

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/how-tos/icons/chatgpt.svg">
        </div>
    </div>
</div>

OpenAI, a cutting-edge artificial intelligence research lab that includes both the for-profit OpenAI LP and its non-profit counterpart OpenAI Inc., was established with the mission to promote digital intelligence in a manner that universally benefits humanity. OpenAI pursues research across various AI fields and is committed to creating AI technologies that are safe, beneficial, and broadly accessible.

The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) NuGet package introduces capabilities for enhancing PDFs using OpenAI, including summarization, querying, and memorization, leveraging Microsoft's [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/).

## Example of Summarizing a PDF Document

To activate the OpenAI functionalities, both an Azure Endpoint and an API Key are essential. Follow the code example below to set up Semantic Kernel, import a PDF, and apply the `Summarize` method to produce a concise summary of your document. Access a sample PDF file [here](https://ironpdf.com/static-assets/pdf/how-to/openai/wikipedia.pdf).

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/openai/wikipedia.pdf" width="100%" height="400px"></iframe>

```cs
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Configuration for OpenAI
string azureEndpoint = "AzureEndPoint";
string apiKey = "APIKEY";

var volatileMemoryStore = new VolatileMemoryStore();
var builder = new KernelBuilder()
    .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
    .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
    .WithMemoryStorage(volatileMemoryStore);
var kernel = builder.Build();

// Activating IronAI
IronAI.Initialize(kernel);

// Loading the PDF document
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Generating summary
string summary = await pdf.Summarize(); // Optionally utilize a specific AI instance or directly use the AI facility
Console.WriteLine($"Document summary: {summary}");
```

### Sample Output for Document Summary

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/openai/summarize.webp" alt="Summary of PDF document" class="img-responsive add-shadow">
    </div>
</div>

## Example of Continuous Querying on a PDF

Sometimes, a single query is not adequate for all use cases. The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) package also supports a method to execute ongoing queries within a document.

```cs
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Setup for OpenAI features
string azureEndpoint = "AzureEndPoint";
string apiKey = "APIKEY";

var volatileMemoryStore = new VolatileMemoryStore();
var builder = new KernelBuilder()
    .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
    .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
    .WithMemoryStorage(volatileMemoryStore);
var kernel = builder.Build();

// Initializing IronAI
IronAI.Initialize(kernel);

// Loading the PDF
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Begin continuous querying
while (true)
{
    Console.Write("User Input: ");
    var response = await pdf.Query(Console.ReadLine());
    Console.WriteLine($"\n{response}");
}
```