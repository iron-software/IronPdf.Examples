using IronPdf;
namespace IronPdf.Examples.HowTo.ImagesAzureBlobStorage
{
    public static class Section1
    {
        public static void Run()
        {
            // BlobContainerClient comes from Azure.Storage.Blobs, which this project does not reference.
            // Kept verbatim; see README.md for the full context.
            // var blobBase64 = Convert.ToBase64String(new BlobContainerClient("conn","cont").GetBlobClient("img.jpg").DownloadContent().Value.Content.ToArray());
            // new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf($"<img src=\"data:image/jpeg;base64,{blobBase64}\" />").SaveAs("blobImage.pdf");
        }
    }
}