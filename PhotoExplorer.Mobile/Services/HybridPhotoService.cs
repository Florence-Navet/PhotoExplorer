using PhotoExplorer.Components.Models;
using PhotoExplorer.Components.Services;
using System.Net.Http.Json;

namespace PhotoExplorer.Explorer.Services;

public class HybridPhotoService : IPhotoService
{
    private readonly HttpClient client;

    public HybridPhotoService(
        HttpClient client)
    {
        this.client = client;
    }

    public Task<Photo?> GetPhotoById(string id)
    {
        return client.GetFromJsonAsync<Photo?>("https://localhost:7198/photos" + id);
    }

    public Task<List<Photo>?> GetPhotosFromApi()
    {
        return client.GetFromJsonAsync<List<Photo>>("https://localhost:7198/photos");
    }
}
