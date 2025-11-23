using Microsoft.EntityFrameworkCore;
using PhotoExplorer.Api.Data.Models;

namespace PhotoExplorer.Api.Data;

public class PhotoExplorerDbContext : DbContext
{

    public DbSet<Photo> Photos { get; set; }

    public PhotoExplorerDbContext(
        DbContextOptions<PhotoExplorerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Photo>()
            .HasData(new[]
            {
                new Photo{ Id = Guid.Parse("2ca16a6d-fe63-4351-bd05-f669f615f4cc"), Author = "Albert T.", Description = "Tigre blanc en forêt", Path = "animal1.jpg"},
                new Photo{ Id = Guid.Parse("cebb5c21-327c-443c-9146-5d93ce5beebd"), Author = "Albert T.", Description = "Perroquet tropical", Path = "animal2.jpg"},
                new Photo{ Id = Guid.Parse("5d839739-8291-4c98-bc3d-5f619cba1af7"), Author = "Albert T.", Description = "Cerf au crépuscule", Path = "animal3.jpg"},
                new Photo{ Id = Guid.Parse("a20d1103-e141-439b-bed1-68fb101de295"), Author = "Albert T.", Description = "Firefox (IRL)", Path = "animal4.jpg"},
                new Photo{ Id = Guid.Parse("921c1f8b-5671-4a6e-b12c-916079bc7844"), Author = "Justine M.", Description = "Randonnée dominicale", Path = "montagne1.jpg"},
                new Photo{ Id = Guid.Parse("4f159947-627c-4070-9532-50a4d3a6c6ef"), Author = "Justine M.", Description = "Vallée verdoyante", Path = "montagne2.jpg"},
                new Photo{ Id = Guid.Parse("dfba52a5-d319-48a3-9ebe-b85836c5a30c"), Author = "Justine M.", Description = "Sommet enneigé", Path = "montagne3.jpg"},
                new Photo{ Id = Guid.Parse("e8bdf7f7-89c4-47ac-9b29-092e773af3fb"), Author = "Justine M.", Description = "Les dents de la neige", Path = "montagne4.jpg"},
                new Photo{ Id = Guid.Parse("da25fdad-cd44-46c3-8871-bbd61cfa13b9"), Author = "Raphaël Z.", Description = "L'été est là", Path = "plage1.jpg"},
                new Photo{ Id = Guid.Parse("bd7bf2e7-1dac-47de-8709-407f8a3b6838"), Author = "Raphaël M.", Description = "L'étoile", Path = "plage2.jpg"},
                new Photo{ Id = Guid.Parse("7dcda0ab-a7d5-4b97-908e-50dc94306236"), Author = "Raphaël M.", Description = "Sea, sex and sun", Path = "plage3.jpg"},
                new Photo{ Id = Guid.Parse("948e198d-a7b1-40df-8d96-e29891fec311"), Author = "Raphaël M.", Description = "Beauté du pacifique", Path = "plage4.jpg"}
            });
    }
}
