# Leveraging OpenAI for Enhanced PDF Interactions

***Based on <https://ironpdf.com/how-to/openai/>***


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://ironpdf.com/img/how-tos/icons/chatgpt.svg">
        </div>
    </div>
</div>

OpenAI, a hybrid of for-profit and non-profit entities, boasts a mission to promote and develop digital intelligence in ways that benefit society at large. Through extensive research in multiple domains of artificial intelligence (AI), OpenAI is dedicated to creating AI tools that are safe, beneficial, and universally accessible.

The [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) NuGet package introduces the capability to enhance PDFs using OpenAI technology, including features like summarization, querying, and data recall. This package is powered by Microsoft's [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/).

<h3>Getting Started with IronPDF</h3>

----

## Example: Summarizing PDF Documents

To activate the OpenAI features, you'll need an Azure Endpoint and an API Key. Following the configuration setup with Semantic Kernel shown in the example below, you can load your PDF file and apply the `Summarize` method to get a concise version of its content. Access a practical example PDF here: [OpenAI for PDF Summarization Example](https://ironsoftware.com/csharp/examples/openai-pdf-summarization/).

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/openai/wikipedia.pdf" width="100%" height="400px">
</iframe>

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

// Initializing IronAI
IronAI.Initialize(kernel);

// Loading PDF document
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Executing document summarization
string summary = await pdf.Summarize(); // Optionally pass AI instance or directly use it
Console.WriteLine($"Document summary: {summary}");
```

### Summarization Output

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/openai/summarize.webp" alt="Summarize PDF document" class="img-responsive add-shadow">
    </div>
</div>

## Example: Continuous Querying

For situations that require ongoing interaction, the [`IronPdf.Extensions.AI`](https://www.nuget.org/packages/IronPdf.Extensions.AI) package also provides a method to perform continuous queries.

```cs
using IronPdf;
using IronPdf.AI;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Memory;
using System;
using System.Threading.Tasks;

// Initialization for OpenAI
string azureEndpoint = "AzureEndPoint";
string apiKey = "APIKEY";

var volatileMemoryStore = new VolatileMemoryStore();
var builder = new KernelBuilder()
    .WithAzureTextEmbeddingGenerationService("oaiembed", azureEndpoint, apiKey)
    .WithAzureChatCompletionService("oaichat", azureEndpoint, apiKey)
    .WithMemoryStorage(volatileMemoryStore);
var kernel = builder.Build();

// Launching IronAI
IronAI.Initialize(kernel);

// PDF document import
PdfDocument pdf = PdfDocument.FromFile("wikipedia.pdf");

// Engaging in continuous query
while (true)
{
    Console.Write("User Input: ");
    var response = await pdf.Query(Console.ReadLine());
    Console.WriteLine($"\n{response}");
}
```

In these examples, IronPDF seamlessly integrates with OpenAI services to provide powerful PDF manipulation capabilities that leverage advanced AI functionalities for querying and summarization, enhancing the utility and accessibility of PDF contents.