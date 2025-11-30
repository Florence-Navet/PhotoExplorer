using PhotoExplorer.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoExplorer.Components.Services;

public interface IPhotoService
{
    Task<List<Photo>?> GetPhotosFromApi();
    Task<Photo?> GetPhotoById(string id);
}
