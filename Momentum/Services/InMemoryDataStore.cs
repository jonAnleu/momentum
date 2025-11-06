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
        Id = 1, Filename = "Chuck the Duck", FilePath = "images/chuck.jpg", FileType = "jpg", IsSelected = false,
        CreatedDate = DateTime.Now.AddDays(-10), PublishedDate = DateTime.Now.AddDays(-8), ModifiedDate = null,
        AssetType = "Photography", UsageRights = "Available", Goal = "Brand Awareness", TargetPersona = "Adults",
    },
  
   
};
      
    }
    
}