using PhotoExplorer.Components.Models;
using PhotoExplorer.Components.Services;

namespace PhotoExplorer.Manager.Services;

public class ServerPhotoService : IPhotoService
{
    private readonly IHttpClientFactory factory;

    public ServerPhotoService(
        IHttpClientFactory factory)
    {
        this.factory = factory;
    }

    public async Task<Photo?> GetPhotoById(string id)
    {
        using var httpClient = factory.CreateClient("api");
        var result = await httpClient.GetFromJsonAsync<Photo?>("photos/" + id);
        return result;
    }

    public async Task<List<Photo>?> GetPhotosFromApi()
    {
        using var httpClient = factory.CreateClient("api");
        var result = await httpClient.GetFromJsonAsync<List<Photo>>("/photos");
        return result;

    }
}
