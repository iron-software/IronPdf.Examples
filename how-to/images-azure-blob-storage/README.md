# Managing PDFs with Images from Azure Blob Storage

***Based on <https://ironpdf.com/how-to/images-azure-blob-storage/>***


Azure Blob Storage is a versatile cloud storage solution offered by Microsoft Azure, perfect for handling vast quantities of unstructured data accessible through both HTTP and HTTPS.

Developers sometimes need to integrate images from Azure Blob Storage into their applications. One challenge is that the images are stored as binary data rather than traditional file formats. The solution is converting these images into base64 encoded strings for easy embedding within HTML img tags.

```cs
:title=Incorporate Azure Blob storage image into PDF seamlessly
var encodedImage = Convert.ToBase64String(new BlobContainerClient("connection-string","container").GetBlobClient("picture.jpg").DownloadContent().Value.Content.ToArray());
new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf($"<img src=\"data:image/jpeg;base64,{encodedImage}\" />").SaveAs("output.pdf");
```

## Transforming Azure Blob Images into HTML

To start, ensure your Azure Storage account is set up with an accessible container. The next steps involve authenticating and connecting to your Azure Storage within a C# project. You can utilize the `DownloadToStreamAsync` method to pull the image into a stream which will then be converted into a base64 string for HTML embedding.

```csharp
using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

public async Task ConvertBlobToHtml()
{
    // Specify your connection string and container name
    string connectionString = "your_connection_string";
    string containerName = "your_container_name";

    // Set up BlobServiceClient with your connection string
    BlobServiceClient serviceClient = new BlobServiceClient(connectionString);

    // Access the BlobContainerClient from the container specified
    BlobContainerClient containerClient = serviceClient.GetBlobContainerClient(containerName);

    // Reference the blob and prepare a stream for data
    BlobClient blobClient = containerClient.GetBlobClient("image-name.jpg");
    using var stream = new MemoryStream();

    // Stream the blob data
    await blobClient.DownloadToAsync(stream);
    stream.Seek(0, SeekOrigin.Begin); // Reposition stream to start

    // Stream conversion to byte array
    byte[] imageData = stream.ToArray();

    // Encode to base64
    var base64Data = Convert.ToBase64String(imageData);

    // Prepare an HTML img tag
    var htmlImgTag = $"<img src=\"data:image/jpeg;base64,{base64Data}\"/><br/>";
    
    // Now, this img tag can be used in HTML as needed
}
```

### Converting HTML to PDF

Following the generation of the `htmlImgTag`, converting this HTML into a PDF is straightforward with the `RenderHtmlAsPdf` function provided by **ChromePdfRenderer**.

Here is how you can utilize this function:

```csharp
using IronPdf;

// Create a new instance of the renderer
var pdfRenderer = new ChromePdfRenderer();

// Convert HTML string to PDF
var pdfDocument = pdfRenderer.RenderHtmlAsPdf(htmlImgTag);

// Save the PDF to a file
pdfDocument.SaveAs("convertedImage.pdf");
```

Be sure to update the `"htmlContent"` variable appropriately to make use of your actual HTML content that includes the `htmlImgTag`.