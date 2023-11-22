using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstTogether_START.Data
{
    public class DataInitializer
    {
        public void MigrateAndSeed(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedCountys(dbContext);
            dbContext.SaveChanges();
        }

        private void SeedCountys(ApplicationDbContext dbContext)
        {
            if (!dbContext.County.Any(c => c.Name == "Stockholms län"))
            {
                dbContext.County.Add(new County
                {
                    Name = "Stockholms län",
                    ContactPerson = "Annie"
                });
            }
            if (!dbContext.County.Any(c => c.Name == "Uppsalas län"))
            {
                dbContext.County.Add(new County
                {
                    Name = "Uppsalas län",
                    ContactPerson = "Brand"
                });
            }
        }

    }
}
