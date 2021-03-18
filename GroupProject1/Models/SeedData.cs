using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupProject1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)

        {
            GroupListContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<GroupListContext>();

            //This if checks if there are any pending migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Times.Any())
            {
                string[] hourslots = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM",
                    "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM" };

                string[] dates = { "3/22/2021", "3/23/2021", "3/24/2021", "3/25/2021", "3/26/2021", "3/27/2021" };

                // create an array of timeslots with a length equal to number of timeslots
                List<Timeslot> timeslots = new List<Timeslot>();

                // add each timeslot to the array
                foreach (string date in dates)
                {
                    foreach (string hour in hourslots)
                    {
                        timeslots.Add(new Timeslot
                        {
                            Date = DateTime.Parse(date + " " + hour)
                        });
                    }
                }

                // save the timeslots to the database
                context.AddRange(timeslots);
                context.SaveChanges();
            }
        }
    }
}