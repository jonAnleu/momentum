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
        public bool IsSelected { get; set; } = true;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;



        // ----- Metadata Fields -----

        // Single-select
        public string AssetType { get; set; } = string.Empty;
        public string UsageRights { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string PublicationDate { get; set; } = string.Empty; // Or DateOnly if you prefer
        public string Copyright { get; set; } = string.Empty;

        // Special field for “Please specify”
        public string? UsageRightsDetails { get; set; }

        // Multi-select
        public List<string> AssetSubtypes { get; set; } = new List<string>();
        public List<string> Goals { get; set; } = new List<string>();
        public List<string> TargetPersonas { get; set; } = new List<string>();
        public List<string> Channels { get; set; } = new List<string>();
        public List<string> Launches { get; set; } = new List<string>();
        public List<string> Themes { get; set; } = new List<string>();
        public List<string> Campaigns { get; set; } = new List<string>();
        public List<string> Installations { get; set; } = new List<string>();
        public List<string> Tags { get; set; } = new List<string>();
        public List<string> Collections { get; set; } = new List<string>();

        
    }
}