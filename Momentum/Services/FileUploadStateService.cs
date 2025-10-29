using Microsoft.AspNetCore.Components.Forms;

namespace Momentum.Services
{
    public class FileUploadStateService
    {
        public List<UploadedFile> PendingFiles { get; private set; } = new();

        public void SetFiles(List<UploadedFile> files)
        {
            PendingFiles = files;
        }

        public void ClearFiles()
        {
            PendingFiles.Clear();
        }
    }

    public class UploadedFile
    {
        public string Name { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public byte[] Data { get; set; } = Array.Empty<byte>();
    }
}