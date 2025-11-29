using PhotoExplorer.Components.Models;
using PhotoExplorer.Components.Services;
using System.Net.Http.Json;

namespace PhotoExplorer.Explorer.Services;

public class WASMPhotoService : IPhotoService
{
    private readonly HttpClient client;

    public WASMPhotoService(
        HttpClient client)
    {
        this.client = client;
    }
    public Task<List<Photo>?> GetPhotosFromApi()
    {
        return client.GetFromJsonAsync<List<Photo>>("https://localhost:7198/photos");
    }
}
