using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject1.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)

        {
            TimeslotDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TimeslotDbContext>();

            //This if checks if there are any pending migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Times.Any())
            {
                string[] hourslot = {"8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM",
                    "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM" };

                string date1 = "3/22/2021";
                string date2 = "3/23/2021";
                string date3 = "3/24/2021";
                string date4 = "3/25/2021";
                string date5 = "3/26/2021";
                string date6 = "3/27/2021";

                context.Times.AddRange();
}