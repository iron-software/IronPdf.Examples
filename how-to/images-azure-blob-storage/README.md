# Rendering PDFs with Images from Azure Blob Storage

***Based on <https://ironpdf.com/how-to/images-azure-blob-storage/>***


Azure Blob Storage is Microsoft Azure's versatile cloud storage solution. It's perfect for managing vast amounts of unstructured data — be it textual or binary — accessible through HTTP or HTTPS protocols.

For developers aiming to incorporate images housed in Azure Blob Storage into their projects, an initial challenge is that these images exist in a binary format rather than as traditional files. A useful approach involves transforming these images into a base64 string format and incorporating them within an HTML image tag.

### Initialize with IronPDF

---

## Converting Azure Blob Images for HTML Use

Should you have an Azure Storage account with an operational container containing blobs, you'll need to establish a connection and authentication within your C# project. Utilize the `DownloadToStreamAsync` method to download the image into a stream, convert this stream data into a Base64 format, and embed it within an HTML img tag. This img tag can then be integrated into an HTML document.

```cs
// Setup your connection string and specify the container name
string connectionString = "your_connection_string_here";
string containerName = "your_container_name_here";

// Create BlobServiceClient using the provided connection string
BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

// Access the BlobContainerClient for your container
BlobContainerClient blobContainer = blobServiceClient.GetBlobContainerClient(containerName);

// Reference your specific Blob
var blob = blobContainer.GetBlobReference("your_image_name.jpg");

var stream = new MemoryStream();

// Download your image into the stream
await blob.DownloadToStreamAsync(stream);

var buffer = new byte[blob.Properties.Length];

// Fill newly defined buffer with image data
await blob.DownloadToByteArrayAsync(target: buffer, index: 0);

// Convert download image data to base64
var base64String = Convert.ToBase64String(buffer);

var imageTag = $"<img src=\"data:image/jpeg;base64, {base64String}\"/><br/>";
```

### Converting HTML to PDF

With the prepared image tag, you can proceed to convert it into a PDF file using IronPDF:

```cs
// Use IronPdf's advanced Chrome PDF rendering technology
using IronPdf;

// Instantiate Renderer object
var renderer = new ChromePdfRenderer();

// Convert HTML string (imageTag) to a PDF document
var pdfDocument = renderer.RenderHtmlAsPdf(imageTag);

// Save the generated PDF to a file
pdfDocument.SaveAs("imageToPdf.pdf");
```