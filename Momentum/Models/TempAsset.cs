namespace Momentum.Models;

public class TempAsset
{
    public string Title { get; set; } = string.Empty;

    // File Information (set during upload)
    public string OriginalFileName { get; set; } = string.Empty;
    public string FileExtension { get; set; } = string.Empty;
    public byte[] BinaryData { get; set; } = Array.Empty<byte>();



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
    public List<string> AssetSubtypes { get; set; } = [];
    public List<string> Goals { get; set; } = [];
    public List<string> TargetPersonas { get; set; } = [];
    public List<string> Channels { get; set; } = [];
    public List<string> Launches { get; set; } = [];
    public List<string> Themes { get; set; } = [];
    public List<string> Campaigns { get; set; } = [];
    public List<string> ProducedBy { get; set; } = [];
    public List<string> Tags { get; set; } = [];
    public List<string> Collections { get; set; } = [];


    // Related Assets (IDs to reference later)
    public List<Guid> RelatedAssetIds { get; set; } = [];
}
