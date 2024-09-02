# Managing PDFs with Images from Azure Blob Storage

Azure Blob Storage by Microsoft Azure is a cloud service tailored for storing large quantities of unstructured data, such as text or binary data. This data can be accessed via HTTP or HTTPS protocols.

Developers often face challenges when dealing with images stored in Azure Blob Storage because these images are saved in a binary format rather than as direct file references that could be effortlessly used within HTML. A practical solution involves converting these images into base64 strings and embedding them within HTML `img` tags.

# Converting Azure Blob to HTML

Before you begin, make sure you have an Azure Storage account established, along with a container that holds your blobs. Additionally, handling the authentication and connection within your C# project is crucial. You can then make use of the `DownloadToStreamAsync` method to download the image as a stream. This stream is then converted into a Base64 string which will be embedded into the HTML `img` tag. Subsequently, this `img` tag can be integrated into an HTML document.

```cs
// Declare your connection string and container name
string connectionString = "your_connection_string";
string containerName = "your_container_name";

// Initialize a BlobServiceClient with your connection string
BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

// Retrieve the BlobContainerClient for the determined container
BlobContainerClient blobContainer = blobServiceClient.GetBlobContainerClient(containerName);

// Access a specific Blob
var blob = blobContainer.GetBlobReference("867.jpg");

var stream = new MemoryStream();

// Download the blob to the stream
await blob.DownloadToStreamAsync(stream);

var buffer = new byte[blob.Properties.Length];

// Place the downloaded blob data into a byte array
await blob.DownloadToByteArrayAsync(target: buffer, 0);

// Transform bytes into a base64 string
var base64 = Convert.ToBase64String(buffer);

var imageTag = $"<img src=\"data:image/jpeg;base64,{base64}\"/><br/>";
```

### Converting HTML to PDF

Using the previously formed `imageTag`, you can convert this HTML into a PDF using the `RenderHtmlAsPdf` method available in **ChromePdfRenderer** from Iron Pdf.

```cs
using IronPdf;

// Create an instance of the Renderer
var renderer = new ChromePdfRenderer();

// Convert the HTML string to PDF
var pdf = renderer.RenderHtmlAsPdf(imageTag);

// Save the resulting PDF to a file
pdf.SaveAs("https://ironpdf.com/imageToPdf.pdf");
```