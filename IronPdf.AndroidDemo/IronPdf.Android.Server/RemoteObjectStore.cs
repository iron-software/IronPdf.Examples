using Azure.Storage.Blobs;
using IronPdfEngine;
using IronSoftware;

namespace IronPdfEngineService
{

    //TODO: RemoteObjectStore need to update(re-upload) data.
    //e.g. when add a background data pdf data changed but it was not uploaded to Azure Blob

    /// <summary>
    /// Remote object store which uses Azure blob storage for document storage
    /// </summary>
    public class RemoteObjectStore : IObjectStore
    {
        private BlobContainerClient container = null;
        /// <summary>
        /// Create a new remote object store using the specified blob storage connection string and blob container name
        /// </summary>
        /// <param name="connection_string">Blob storage connection string</param>
        /// <param name="container_name">Blob container name</param>
        public RemoteObjectStore(string connection_string, string container_name)
        {
            if (string.IsNullOrEmpty(connection_string))
                throw new ArgumentNullException(nameof(connection_string), "Invalid blob storage connection string. Please set the environment variable 'BLOB_STORAGE_CONNECTION'.");
            if (string.IsNullOrEmpty(container_name))
                throw new ArgumentNullException(nameof(container_name), "Invalid blob container name. Please set the environment variable 'BLOB_STORAGE_CONTAINER'.");
            container = new BlobContainerClient(connection_string, container_name);
        }
        public IPdfDocumentId AddDocument(PdfDocument newPdf)
        {
            Guid id = Guid.NewGuid();
            var blob = container.GetBlobClient(id.ToString());
            MemoryStream stream = new MemoryStream();
            byte[] bytes = newPdf.BinaryData;
            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0;
            blob.Upload(stream);

            return new PdfDocumentId(id.ToString());
        }

        public IPdfDocumentId CopyDocument(IPdfDocumentId id)
        {
            return id;
        }

        public int DisposeDocument(IPdfDocumentId id)
        {
            // TODO 8/2/23: implement blob storage disposal
            return 0;
        }

        public IPdfDocumentId FetchDocument(IPdfDocumentId id)
        {

            var blob = container.GetBlobClient(id.RemoteId);
            MemoryStream stream = new MemoryStream();
            var result = blob.DownloadTo(stream);
            return new PdfDocument(stream.ToArray());
        }

        public int IncrementReference(IPdfDocumentId id)
        {
            // TODO 8/2/23: implement blob storage reference incrementing
            return 0;
        }
    }
}
