using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Microsoft.AspNetCore.Http;

namespace PMApplication.Services
{
    
    public class AzureBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;

        public AzureBlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public BlobServiceClient GetBlobServiceClient(string accountName)
        {
            return _blobServiceClient;
        }

        public BlobContainerClient GetBlobContainerClient(
            BlobServiceClient blobServiceClient,
            string containerName)
        {
            // Create the container client using the service client object
            BlobContainerClient client = blobServiceClient.GetBlobContainerClient(containerName);
            return client;
        }

        public async Task UploadFormFileAsync(
            BlobContainerClient containerClient,
            IFormFile file,
            string fileName)
        {
            try
            {
                string blobName = fileName;
                BlobClient blobClient = containerClient.GetBlobClient(blobName);
                var fileType = fileName.Split('.')[1];
                var blobUploadOptions = new BlobUploadOptions();
                var blobHttpHeaders = new BlobHttpHeaders();
                if (fileType.ToLower() == "svg")
                {
                    blobHttpHeaders.ContentType = "image/svg+xml";
                    
                    blobUploadOptions.HttpHeaders = blobHttpHeaders;
                    await blobClient.UploadAsync(file.OpenReadStream(), blobUploadOptions);
                }
                else
                {
                    await blobClient.UploadAsync(file.OpenReadStream(), true);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error uploading file to Blob Storage: {ex.Message}", ex);
            }
        }
    }
}
