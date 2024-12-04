# Working with Images in PDFs from Azure Blob Storage

***Based on <https://ironpdf.com/how-to/images-azure-blob-storage/>***


Azure Blob Storage, developed by Microsoft Azure, serves as a cloud solution that specializes in the storage of massive amounts of unstructured data such as texts or binaries, accessible via HTTP or HTTPS protocols.

Developers looking to incorporate images stored in Azure Blob Storage within their projects face the challenge of dealing with binary data instead of standard file formats. A practical solution involves converting images into base64 strings, which can then be integrated into HTML using an `img` tag.

## Converting Azure Blobs to Embedded HTML Images

Once you have established your Azure Storage account and set up a container with the required blobs, you'll need to establish a connection and manage authentication within your C# application. Utilizing the `DownloadToStreamAsync` method, you can retrieve the image as a stream. Subsequently, this stream can be transformed into Base64 format and embedded within an HTML `img` tag. This newly formed imageTag is then ready to be amalgamated into an HTML document.

```cs
// Configuration for storage access
string connectionString = "your_connection_string";
string containerName = "your_container_name";

// Creating Blob service client from the connection string
BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

// Acquiring client for the specified container
BlobContainerClient blobContainer = blobServiceClient.GetBlobContainerClient(containerName);

// Retrieve your Blob
var blob = blobContainer.GetBlobReference("867.jpg");

var stream = new MemoryStream();

// Download blob to stream asynchronously
await blob.DownloadToStreamAsync(stream);

var array = new byte[blob.Properties.Length];
await blob.DownloadToByteArrayAsync(target: array, index: 0);

// Converting bytes into base64 string
var base64 = Convert.ToBase64String(array);

// Preparing the HTML image tag
var imageTag = $"<img src=\"data:image/jpeg;base64,{base64}\"/><br/>";
```

### Transforming HTML with Images into a PDF Document

Following the creation of the `imageTag` with the base64 encoded image, this can be further processed into a PDF file utilizing the `RenderHtmlAsPdf` method from the **ChromePdfRenderer** class.

```cs
using IronPdf;
namespace ironpdf.ImagesAzureBlobStorage
{
    public class Section1
    {
        public void Execute()
        {
            // Initializing the PDF renderer
            var renderer = new ChromePdfRenderer();
            
            // Generating PDF from HTML string
            var pdfDocument = renderer.RenderHtmlAsPdf(imageTag);
            
            // Saving the PDF document to a file
            pdfDocument.SaveAs("imageToPdf.pdf");
        }
    }
}
```

This adapted approach ensures that images stored in Azure Blob Storage can be efficiently integrated into PDF documents using C# and IronPDF's capabilities, handling the conversion from binary data to embedded images, followed by the conversion of HTML to PDF.