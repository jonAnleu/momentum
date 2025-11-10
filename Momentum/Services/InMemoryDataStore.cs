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
    
  
   
};
      
    }
    
}