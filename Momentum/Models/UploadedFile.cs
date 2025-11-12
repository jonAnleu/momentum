namespace Momentum.Models;

public class UploadedFile
{
    // Extracted Metadata
    public string Name { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
    public byte[] Data { get; set; } = Array.Empty<byte>();
    public bool IsSelected { get; set; } = true;
    public string Title { get; set; } = string.Empty;
    public long FileSize { get; set; }  
    public DateTime UploadDate { get; set; } = DateTime.Now; 



    // Required Metadata Fields

    public string AssetType { get; set; } = string.Empty;
    public List<string> AssetSubtypes { get; set; } = new List<string>();
    public string UsageRights { get; set; } = string.Empty;
    
    // Special field for “Please specify”
    public string? UsageRightsDetails { get; set; }
    public List<string> Goals { get; set; } = new List<string>();
        
    // Optional-Fields
    public string Description { get; set; } = string.Empty;
    public int? Year { get; set; } 
    public DateTime? PublicationDate { get; set; } 
    public TimeSpan? PublicationTime { get; set; }
    public string Copyright { get; set; } = string.Empty;
    public List<string> TargetPersonas { get; set; } = new List<string>();
    public List<string> Channels { get; set; } = new List<string>();
    public List<string> Launches { get; set; } = new List<string>();
    public List<string> Themes { get; set; } = new List<string>();
    public List<string> Campaigns { get; set; } = new List<string>();
    public List<string> Installations { get; set; } = new List<string>();
    public List<string> Tags { get; set; } = new List<string>();
    public List<string> Collections { get; set; } = new List<string>();
        
}