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

            return new UploadedFile
            {
                Name = browserFile.Name,
                ContentType = browserFile.ContentType,
                Data = ms.ToArray(),
                Title = Path.GetFileNameWithoutExtension(browserFile.Name),
                FileExtension = Path.GetExtension(browserFile.Name).ToUpper().TrimStart('.'),
                FileSize = browserFile.Size,
                UploadDate = DateTime.Now
            };
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