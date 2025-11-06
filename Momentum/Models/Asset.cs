namespace Momentum.Models;

public class Asset
{
    public int Id { get; set; }
    public string? Filename { get; set; }
    public string? FilePath { get; set; }
    public string? FileType { get; set; }
    public long FileSize { get; set; }
    
    public string? ThumbnailPath { get; set; }
    public bool IsSelected { get; set; }
    public DateTime CreatedDate { get; set; } 
    public DateTime? PublishedDate { get; set; } 
    public DateTime? ModifiedDate { get; set; }
    public string AssetType { get; set; } = string.Empty; // Audio, Document, Graphic/Visual, Photography, Video
    public string UsageRights { get; set; } = string.Empty; // Clear selection, Available, Confidential, On request, Special Usage rights
    public string Goal { get; set; } = string.Empty; // Brand Awareness, Customer Loyalty, New Customers, Product Launch 
    public string TargetPersona { get; set; } = string.Empty; // Adults, Kids, Teenagers, Young Adults
}

