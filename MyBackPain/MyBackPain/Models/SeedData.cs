using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBackPain.Data;

namespace MyBackPain.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyBackPainContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyBackPainContext>>()))
            {
                // Look for any back pains.
                if (context.BackPain.Any())
                {
                    return;   // DB has been seeded
                }

                context.BackPain.AddRange(
                    new BackPain
                    {
                        DoIHaveBackPain = "Yes",
                        Day = DateTime.Parse("2021-2-11"),
                        IsItMyFault = "Yes",
                        DidITakeIbuprofen = "No",
                        DoIShakeMyFistsAtTheSky = "Yes"
                    },

                    new BackPain
                    {
                        DoIHaveBackPain = "Yes",
                        Day = DateTime.Parse("2021-31-10"),
                        IsItMyFault = "Probably",
                        DidITakeIbuprofen = "No",
                        DoIShakeMyFistsAtTheSky = "Yes"
                    },

                    new BackPain
                    {
                        DoIHaveBackPain = "Yes",
                        Day = DateTime.Parse("2021-30-10"),
                        IsItMyFault = "No",
                        DidITakeIbuprofen = "Yes",
                        DoIShakeMyFistsAtTheSky = "Yes"
                    },

                    new BackPain
                    {
                        DoIHaveBackPain = "Yes",
                        Day = DateTime.Parse("2021-1-11"),
                        IsItMyFault = "Partially",
                        DidITakeIbuprofen = "Yes",
                        DoIShakeMyFistsAtTheSky = "Yes"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
