using Momentum.Models;
namespace Momentum.Data.Services;

public class CollectionService
{
    private List<Collection> _collections = new()
    {
        new Collection { Id = Guid.NewGuid(), Image = "images/chuck.jpg", Title = "Image 1", FileCount = 8, IsSelected = false },
       
       
    };
    
    public List<Collection> GetAssets()
    {
        return _collections;
    }

}