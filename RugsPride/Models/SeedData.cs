using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RugsPride.Data;
using System;
using System.Linq;

namespace RugsPride.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RugsPrideContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RugsPrideContext>>()))
            {
                // Look for any movies.
                if (context.Rug.Any())
                {
                    return;   // DB has been seeded
                }

                context.Rug.AddRange(
                    new Rug
                    {
                        Brand = "SWEET HOMES",
                        Color = "Dark-grey Ivory",
                        Shape = "Rectangular",
                        Material = "Super Soft Microfiber",
                        Price = 100M
                    },
new Rug
{
    Brand = "CottonFry",
    Color = "White",
    Shape = "Round",
    Material = "Faux Fur",
    Price = 140M
},
new Rug
{
    Brand = "The Rug Culture",
    Color = "Black",
    Shape = "Rectangular",
    Material = "Jute",
    Price = 99.99M
},
new Rug
{
    Brand = "HassanCarpet",
    Color = "Beige",
    Shape = "Rectangular",
    Material = "Polypropylene",
    Price = 200M
},
new Rug
{
    Brand = "Moroccan Trellis",
    Color = "Ivory Multi",
    Shape = "Rectangular",
    Material = "Faux Fur",
    Price = 224M
},
new Rug
{
    Brand = "HassanCarpet",
    Color = "Red",
    Shape = "Round",
    Material = "Jute",
    Price = 250M
},
new Rug
{
    Brand = "Moroccan Trellis",
    Color = "Multi",
    Shape = "Rectangular",
    Material = "Jute",
    Price = 300M
},
new Rug
{
    Brand = "The Rug Culture",
    Color = "Pink Blue",
    Shape = "Round",
    Material = "Super Soft Microfiber",
    Price = 330M
},
new Rug
{
    Brand = "SWEET HOMES",
    Color = "Dark-grey Ivory",
    Shape = "Rectangular",
    Material = "Polypropylene",
    Price = 420M
},
new Rug
{
    Brand = "CottonFry",
    Color = "White",
    Shape = "Rectangular",
    Material = "Super Soft Microfiber",
    Price = 180M
}
    );
                context.SaveChanges();
            }
        }
    }
}
