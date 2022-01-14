using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using System;
using System.Linq;
namespace MvcGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGamesContext>>()))
            {
        
                if (context.Games.Any())
                {
                    return;  
                }
                context.Games.AddRange(
                    new Games
                    {
                        Title = "Call of Duty: Modern Warfare",
                        ReleaseDate = DateTime.Parse("2015-06-18"),
                        Genre = "FPS",
                        Pegi = 16
                    },
                    new Games
                    {
                        Title = "League of Legends",
                        ReleaseDate = DateTime.Parse("2009-02-11"),
                        Genre = "MOBA",
                        Pegi = 12
                    },
                    new Games
                    {
                        Title = "DayZ",
                        ReleaseDate = DateTime.Parse("2013-08-20"),
                        Genre = "Survival Horror",
                        Pegi = 18
                    },
                    new Games
                    {
                        Title = "Rocket League",
                        ReleaseDate = DateTime.Parse("2015-06-10"),
                        Genre = "Sport",
                        Pegi = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}