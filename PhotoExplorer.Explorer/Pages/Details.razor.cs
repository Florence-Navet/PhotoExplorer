using Microsoft.AspNetCore.Components;
using PhotoExplorer.Components.Models;
using PhotoExplorer.Components.Services;

namespace PhotoExplorer.Explorer.Pages;

public partial class Details
{
    [Parameter] public string Id { get; set; }
    [Inject] private IPhotoService PhotoService { get; set; } = default!;

    private Photo? _photo;
    private bool _error;

    protected override async Task OnInitializedAsync() // async pour le stocker dans photo
    {
        var photo = await PhotoService.GetPhotoById(Id); //await car vient de la route
        if (photo is not null)
        {
            _photo = photo;
        }
        else
        {
            _error = true;
        }
    }
}