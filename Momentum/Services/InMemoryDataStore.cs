using Momentum.Models;
namespace Momentum.Services;


public class InMemoryDataStore
{
    public List<Asset> Assets { get; set; } = new();
    
    public InMemoryDataStore()
    {
        InitializeSampleData();
    }

    private void InitializeSampleData()
    {
      Assets = new List<Asset>
{
    new Asset
    {
        Id = 1, Title = "Adults", FilePath = "images/adults.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-10), PublishedDate = DateTime.Now.AddDays(-8), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "Available", Goal = "Brand Awareness", TargetPersona = "Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 2, Title = "App", FilePath = "images/app.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-15), PublishedDate = DateTime.Now.AddDays(-12), ModifiedDate = DateTime.Now.AddDays(-5),
        AssetType = "Graphic/Visual", UsageRights = "Clear selection", Goal = "New Customers", TargetPersona = "Young Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 3, Title = "Art", FilePath = "images/art.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-20), PublishedDate = DateTime.Now.AddDays(-18), ModifiedDate = null,
        AssetType = "Graphic/Visual", UsageRights = "Confidential", Goal = "Customer Loyalty", TargetPersona = "Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 4, Title = "Beach", FilePath = "images/beach.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-5), PublishedDate = DateTime.Now.AddDays(-3), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "Available", Goal = "Brand Awareness", TargetPersona = "Teenagers",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 5, Title = "Colorful", FilePath = "images/colorful.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-8), PublishedDate = DateTime.Now.AddDays(-6), ModifiedDate = DateTime.Now.AddDays(-1),
        AssetType = "Graphic/Visual", UsageRights = "Special Usage rights", Goal = "Product Launch", TargetPersona = "Young Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 6, Title = "Concert", FilePath = "images/concert.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-12), PublishedDate = DateTime.Now.AddDays(-10), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "On request", Goal = "Customer Loyalty", TargetPersona = "Young Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 7, Title = "Conference", FilePath = "images/conference.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-25), PublishedDate = DateTime.Now.AddDays(-22), ModifiedDate = DateTime.Now.AddDays(-7),
        AssetType = "Photography", UsageRights = "Available", Goal = "New Customers", TargetPersona = "Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 8, Title = "Dancer", FilePath = "images/dancer.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-3), PublishedDate = DateTime.Now.AddDays(-1), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "Clear selection", Goal = "Brand Awareness", TargetPersona = "Teenagers",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 9, Title = "Dj", FilePath = "images/dj.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-18), PublishedDate = DateTime.Now.AddDays(-15), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "Available", Goal = "Product Launch", TargetPersona = "Young Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
    new Asset
    {
        Id = 10, Title = "Events", FilePath = "images/events.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-30), PublishedDate = DateTime.Now.AddDays(-28), ModifiedDate = DateTime.Now.AddDays(-10),
        AssetType = "Photography", UsageRights = "Confidential", Goal = "Customer Loyalty", TargetPersona = "Adults",
        Tags = new() { "Product Launch", "Photography", "Summer", "Lifestyle", "Social", "Vendors" }
    },
   
};
      
    }
    
}