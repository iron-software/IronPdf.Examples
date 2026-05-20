# Utilizing OpenAI for PDF Processing

***Based on <https://ironpdf.com/how-to/openai/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/how-tos/icons/chatgpt.svg">
        </div>
    </div>
</div>

OpenAI, known for its commitment towards advancing intelligent technology that benefits all humanity, is a distinguished artificial intelligence research lab. Its organizational structure includes both a non-profit and a for-profit entity. OpenAI drives forward numerous research initiatives across diverse AI domains and seeks to create AI solutions that are safe, beneficial, and globally accessible.

The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) library now includes functionality to expand PDF processing capabilities through OpenAI, such as summarization, querying, and data retention, leveraging capabilities from Microsoft's [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/).

### Quick Guide: How to Summarize PDFs with IronPDF and OpenAI

Start by embedding OpenAI features into your PDF management tasks using IronPDF in C#. Here's a quick code snippet on how to summarize a PDF document efficiently, enhancing your PDF handling with powerful AI tools.

```csharp
:title=Effortlessly Summarize PDFs using AI!
// Install-Package IronPdf.Extensions.AI
await IronPdf.AI.PdfAIEngine.Summarize("input.pdf", "summary.txt", azureEndpoint, azureApiKey);
```

In addition to the [IronPdf](https://www.nuget.org/packages/IronPdf) core package, make sure to add these packages too:

- [IronPdf.Extensions.AI](https://www.nuget.org/packages/IronPdf.Extensions.AI)
- [Microsoft.SemanticKernel.Plugins.Memory](https://www.nuget.org/packages/Microsoft.SemanticKernel.Plugins.Memory)

## Example: Summarizing PDFs

You'll need an Azure Endpoint and an API Key to utilize OpenAI capabilities. Set up the Semantic Kernel as demonstrated in the sample below. Load your PDF document and use the `Summarize` method to create a summary. Download a sample PDF from [OpenAI PDF Summarization Example](https://ironsoftware.com/csharp/examples/openai-pdf-summarization/).

Be aware of the errors SKEXP0001, SKEXP0010, and SKEXP0050 which might arise due to the experimental nature of the Semantic Kernel methods. You can suppress these warnings in your project file as shown:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <NoWarn>$(NoWarn);SKEXP0001,SKEXP0010,SKEXP0050</NoWarn>
  </PropertyGroup>
</Project>
```

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/openai/wikipedia.pdf" width="100%" height="400px">
</iframe>

Below is an illustrative C# example of summarizing a PDF using the Semantic Kernel:

```csharp
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Initialize OpenAI setup
var azureEndpoint = "<<enter your azure endpoint here>>";
var apiKey = "<<enter your azure API key here>>";
var builder = Kernel.CreateBuilder()
    .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
    .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
var kernel = builder.Build();

// Configure Memory Management
var memory_builder = new MemoryBuilder()
    .WithMemoryStore(new VolatileMemoryStore())
    .WithAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey);
var memory = memory_builder.Build();

// Activate IronDocumentAI
IronDocumentAI.Initialize(kernel, memory);

// Licensing
License.LicenseKey = "<<enter your IronPdf license key here>>";

// Load PDF document
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Start summarization process
Console.WriteLine("Summarizing the document, please wait...");
string summary = await pdf.Summarize(); // Optionally specify the AI instance
Console.WriteLine($"Generated summary: {summary}\n\n");
```

### Output Example

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/openai/summarize.webp" alt="Summarize PDF document" class="img-responsive add-shadow">
    </div>
</div>

## Continuous Query Example

Sometimes a singular query isn't enough. The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) library also supports ongoing queries, allowing for dynamic interactions.

```csharp
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Initialize OpenAI configuration
var azureEndpoint = "<<enter your azure endpoint here>>";
var apiKey = "<<enter your azure API key here>>";
var builder = Kernel.CreateBuilder()
    .AddAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey)
    .AddAzureOpenAIChatCompletion("oaichat", azureEndpoint, apiKey);
var kernel = builder.Build();

// Configure Memory
var memory_builder = new MemoryBuilder()
    .WithMemoryStore(new VolatileMemoryStore())
    .WithAzureOpenAITextEmbeddingGeneration("oaiembed", azureEndpoint, apiKey);
var memory = memory_builder.Build();

IronDocumentAI.Initialize(kernel, memory);

// Apply licensing
License.LicenseKey = "<<enter your IronPdf license key here>>";

// Document import
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Continuous interaction
while (true)
{
    Console.Write("User Input: ");
    var response = await pdf.Query(Console.ReadLine());
    Console.WriteLine($"\n{response}");
}
```