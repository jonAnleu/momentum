namespace Momentum.Models;

public class Asset
{
    // Primary Key
    public int Id { get; set; }
    
    // Basic File Info
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public string FileType { get; set; } = string.Empty;
    public bool IsSelected { get; set; }
    
    // Timestamps
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? ModifiedDate { get; set; }
    
    // Required Metadata Fields
    public string AssetType { get; set; } = string.Empty;
    public List<string> AssetSubTypes { get; set; } = new List<string>();
    public string UsageRights { get; set; } = string.Empty;
    public string? UsageRightsDetails { get; set; }
    public List<string> Goals { get; set; } = new List<string>();
    
    // Optional Metadata Fields
    public string Description { get; set; } = string.Empty;
    public int? Year { get; set; }
    public DateTime? PublicationDate { get; set; }
    public TimeSpan? PublicationTime { get; set; }
    public string Copyright { get; set; } = string.Empty;
    
    // Relationship/Categorization Fields
    public List<string> TargetPersonas { get; set; } = new List<string>();
    public List<string> Channels { get; set; } = new List<string>();
    public List<string> Launches { get; set; } = new List<string>();
    public List<string> Themes { get; set; } = new List<string>();
    public List<string> Campaigns { get; set; } = new List<string>();
    public List<string> Installations { get; set; } = new List<string>();
    public List<string> Tags { get; set; } = new List<string>();
    public List<string> Collections { get; set; } = new List<string>();
}