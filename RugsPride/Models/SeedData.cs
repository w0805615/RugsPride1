using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RugsPride.Data;
using System;
using System.Linq;
                                     //No data should be added mannually to make this seeding database work
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
                // Look for any rugs.
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
                        Rating = "2",
                        Price = 100M
                    },
new Rug
{
    Brand = "CottonFry",
    Color = "White",
    Shape = "Round",
    Material = "Faux Fur",
    Rating = "1",
    Price = 140M
},
new Rug
{
    Brand = "The Rug Culture",
    Color = "Black",
    Shape = "Rectangular",
    Material = "Jute",
    Rating = "1",
    Price = 99.99M
},
new Rug
{
    Brand = "HassanCarpet",
    Color = "Beige",
    Shape = "Rectangular",
    Material = "Polypropylene",
    Rating = "3.5",
    Price = 200M
},
new Rug
{
    Brand = "Moroccan Trellis",
    Color = "Ivory Multi",
    Shape = "Rectangular",
    Material = "Faux Fur",
    Rating = "5",
    Price = 224M
},
new Rug
{
    Brand = "HassanCarpet",
    Color = "Red",
    Shape = "Round",
    Material = "Jute",
    Rating = "3",
    Price = 250M
},
new Rug
{
    Brand = "Moroccan Trellis",
    Color = "Multi",
    Shape = "Rectangular",
    Material = "Jute",
    Rating = "3",
    Price = 300M
},
new Rug
{
    Brand = "The Rug Culture",
    Color = "Pink Blue",
    Shape = "Round",
    Material = "Super Soft Microfiber",
    Rating = "4.5",
    Price = 330M
},
new Rug
{
    Brand = "SWEET HOMES",
    Color = "Dark-grey Ivory",
    Shape = "Rectangular",
    Material = "Polypropylene",
    Rating = "5",
    Price = 420M
},
new Rug
{
    Brand = "CottonFry",
    Color = "White",
    Shape = "Rectangular",
    Material = "Super Soft Microfiber",
    Rating = "2.5",
    Price = 180M
}
    );
                context.SaveChanges();
            }
        }
    }
}
