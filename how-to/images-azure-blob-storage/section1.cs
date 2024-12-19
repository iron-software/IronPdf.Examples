using IronPdf;
namespace IronPdf.Examples.HowTo.ImagesAzureBlobStorage
{
    public static class Section1
    {
        public static void Run()
        {
            // Define your connection string and container name
            string connectionString = "your_connection_string";
            string containerName = "your_container_name";
            
            // Initialize BlobServiceClient with the connection string
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            
            // Get the BlobContainerClient for the specified container
            BlobContainerClient blobContainer = blobServiceClient.GetBlobContainerClient(containerName);
            
            // Get Blob
            var blob = blobContainer.GetBlobReference("867.jpg");
            
            var stream = new MemoryStream();
            
            await blob.DownloadToStreamAsync(stream);
            
            var array = new byte[blob.Properties.Length];
            
            await blob.DownloadToByteArrayAsync(target: array, 0);
            
            // Convert bytes to base64
            var base64 = Convert.ToBase64String(array);
            
            var imageTag = $"<img src=\"data:image/jpeg;base64, {base64}\"/><br/>";
        }
    }
}