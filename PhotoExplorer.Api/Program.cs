using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoExplorer.Api.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.AddDbContext<PhotoExplorerDbContext>(opt => opt.UseSqlite("Filename=photos.db"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    using (var ctx = scope.ServiceProvider.GetRequiredService<PhotoExplorerDbContext>())
    {
        await ctx.Database.MigrateAsync();
    }
}

app.UseCors(p =>
{
    p.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
    .WithOrigins("http://localhost:1234");  // TODO définir l'URL de l'application WASM
});

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/photos/{id:guid}", async (
    [FromServices] PhotoExplorerDbContext ctx,
    [FromRoute] Guid id) =>
{
    var photo = await ctx.Photos.FindAsync(id);
    if (photo is not null)
    {
        return Results.Ok(photo);
    }
    return Results.NotFound();
});

app.MapGet("/photos", async (
    [FromServices] PhotoExplorerDbContext ctx) =>
{
    var photos = await ctx.Photos.ToListAsync();
    return Results.Ok(photos);
});

app.Run();
