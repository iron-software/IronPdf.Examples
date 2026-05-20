using System.Threading.Tasks;
using IronPdf;
namespace IronPdf.Examples.HowTo.ImagesAzureBlobStorage
{
    public static class Section2
    {
        public static void Run()
        {
            public async Task ConvertBlobToHtmlAsync()
            {
                // Define your connection string and container name
                string connectionString = "your_connection_string";
                string containerName = "your_container_name";
            
                // Initialize BlobServiceClient with the connection string
                BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            
                // Get the BlobContainerClient for the specified container
                BlobContainerClient blobContainer = blobServiceClient.GetBlobContainerClient(containerName);
            
                // Get the reference to the blob and initialize a stream
                BlobClient blobClient = blobContainer.GetBlobClient("867.jpg");
                using var stream = new MemoryStream();
            
                // Download the blob data to the stream
                await blobClient.DownloadToAsync(stream);
                stream.Position = 0; // Reset stream position
            
                // Convert the stream to a byte array
                byte[] array = stream.ToArray();
            
                // Convert bytes to base64
                var base64 = Convert.ToBase64String(array);
            
                // Create an img tag with the base64-encoded string
                var imageTag = $"<img src=\"data:image/jpeg;base64,{base64}\"/><br/>";
                
                // Use the imageTag in your HTML document as needed
            }
        }
    }
}