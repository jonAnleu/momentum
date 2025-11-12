using Microsoft.AspNetCore.Components.Forms;
using Momentum.Models;

namespace Momentum.Services
{
    public class FileUploadService
    {
        public List<UploadedFile> PendingFiles { get; private set; } = new();
        public async Task<UploadedFile> ProcessUpload(IBrowserFile browserFile)
        {
            using var stream = browserFile.OpenReadStream(maxAllowedSize: 500_000_000);
            using var ms = new MemoryStream();
            await stream.CopyToAsync(ms);
            var fileData = ms.ToArray(); 


            return new UploadedFile
            {
                Name = browserFile.Name,
                ContentType = browserFile.ContentType,
                Data = fileData,
                Title = Path.GetFileNameWithoutExtension(browserFile.Name),
                FileExtension = Path.GetExtension(browserFile.Name).ToUpper().TrimStart('.'),
                FileSize = browserFile.Size,
                UploadDate = DateTime.Now,
                ThumbnailDataUrl = GenerateThumbnailDataUrl(browserFile.ContentType, fileData)
            };
        }

        private string GenerateThumbnailDataUrl(string contentType, byte[] data)
        {
            if (contentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase))
            {
                if (data.Length < 5_000_000) 
                {
                    return $"data:{contentType};base64,{Convert.ToBase64String(data)}";
                }
                else
                {
                    return "images/large-image-icon.png"; 
                }
            }
            else if (contentType.StartsWith("video/", StringComparison.OrdinalIgnoreCase))
            {
                return "images/video-icon.png"; 
            }
            else if (contentType == "application/pdf")
            {
                return "images/pdf-icon.png"; 
            }
            else
            {
                return "images/file-icon.png"; 
            }
        }

        public void SetFiles(List<UploadedFile> files)
        {
            PendingFiles = files;
        }

        public void ClearFiles()
        {
            PendingFiles.Clear();
        }
    }

    
}