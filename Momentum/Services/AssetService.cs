using Momentum.Models;
namespace Momentum.Services;
public class AssetService
{
    private readonly InMemoryDataStore _dataStore;

    public AssetService(InMemoryDataStore dataStore)
    {
        _dataStore = dataStore;
    }

    public List<Asset> GetAssets()
    {
        return _dataStore.Assets;
    }

    public Asset? GetAssetById(int id)
    {
        return _dataStore.Assets.FirstOrDefault(a => a.Id == id);
    }

    public List<Asset> SearchAssets(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return _dataStore.Assets;

        return _dataStore.Assets.Where(a =>
            (a.FileName?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
            (a.AssetType?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) 
        ).ToList();
    }

    public List<Asset> GetAssetsByIds(List<int> ids)
    {
        return _dataStore.Assets.Where(a => ids.Contains(a.Id)).ToList();
    }
    public Asset AddAsset(Asset asset)
    {
        asset.Id = _dataStore.Assets.Count > 0
            ? _dataStore.Assets.Max(a => a.Id) + 1
            : 1;

        asset.CreatedDate = DateTime.UtcNow;

        _dataStore.Assets.Add(asset);
        return asset;
    }


}