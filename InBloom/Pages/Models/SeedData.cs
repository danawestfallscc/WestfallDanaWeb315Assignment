using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using RazorPagesMovie.Data;
using System;
using System.Linq;
using InBloom.Models;

namespace InBloom.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FlowerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FlowerContext>>()))
            {
                // Look for any flowers.
                if (context.Flower.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flower.AddRange(
                    new Flower
                    {
                        Type = "Rose",
                        LatinName = "Rosa",
                        Colour = "Red",
                        Price = 19.99M
                    },
                    new Flower
                    {
                        Type = "Lily",
                        LatinName = "Lilium",
                        Colour = "White",
                        Price = 14.99M
                    },
                    new Flower
                    {
                        Type = "Carnation",
                        LatinName = "Dianthus Caryophyllus",
                        Colour = "Pink",
                        Price = 10.99M
                    },
                    new Flower
                    {
                        Type = "Sunflower",
                        LatinName = "Helianthus",
                        Colour = "Yellow",
                        Price = 17.99M
                    },
                    new Flower
                    {
                        Type = "Orchid",
                        LatinName = "Orchidaceae",
                        Colour = "Purple",
                        Price = 29.99M
                    }
                    );
                    context.SaveChanges();
                    }
            }
        }
    }
