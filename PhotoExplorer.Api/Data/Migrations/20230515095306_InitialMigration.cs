using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhotoExplorer.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Path = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Author", "Description", "Path" },
                values: new object[,]
                {
                    { new Guid("2ca16a6d-fe63-4351-bd05-f669f615f4cc"), "Albert T.", "Tigre blanc en forêt", "animal1.jpg" },
                    { new Guid("4f159947-627c-4070-9532-50a4d3a6c6ef"), "Justine M.", "Vallée verdoyante", "montagne2.jpg" },
                    { new Guid("5d839739-8291-4c98-bc3d-5f619cba1af7"), "Albert T.", "Cerf au crépuscule", "animal3.jpg" },
                    { new Guid("7dcda0ab-a7d5-4b97-908e-50dc94306236"), "Raphaël M.", "Sea, sex and sun", "plage3.jpg" },
                    { new Guid("921c1f8b-5671-4a6e-b12c-916079bc7844"), "Justine M.", "Randonnée dominicale", "montagne1.jpg" },
                    { new Guid("948e198d-a7b1-40df-8d96-e29891fec311"), "Raphaël M.", "Beauté du pacifique", "plage4.jpg" },
                    { new Guid("a20d1103-e141-439b-bed1-68fb101de295"), "Albert T.", "Firefox (IRL)", "animal4.jpg" },
                    { new Guid("bd7bf2e7-1dac-47de-8709-407f8a3b6838"), "Raphaël M.", "L'étoile", "plage2.jpg" },
                    { new Guid("cebb5c21-327c-443c-9146-5d93ce5beebd"), "Albert T.", "Perroquet tropical", "animal2.jpg" },
                    { new Guid("da25fdad-cd44-46c3-8871-bbd61cfa13b9"), "Raphaël Z.", "L'été est là", "plage1.jpg" },
                    { new Guid("dfba52a5-d319-48a3-9ebe-b85836c5a30c"), "Justine M.", "Sommet enneigé", "montagne3.jpg" },
                    { new Guid("e8bdf7f7-89c4-47ac-9b29-092e773af3fb"), "Justine M.", "Les dents de la neige", "montagne4.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
