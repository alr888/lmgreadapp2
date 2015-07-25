namespace lmgreadapp2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using lmgreadapp2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<lmgreadapp2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(lmgreadapp2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Contacts.AddOrUpdate(p => p.Name,
            new Contact
            {
                Name = "Gary Nightingale",
                ICP = "000000-001",
                MeterNo = "11111",
                MeterRead = 22.22,
                Address = "1234 Main St",
                City = "Christchurch",
                State = "Canterbury",
                Zip = "7000",
                Email = "gary@lmg.co.nz",
            },
            new Contact
            {
                Name = "Mike Bickers",
                ICP = "000000-002",
                MeterNo = "11112",
                MeterRead = 33.33,
                Address = "5678 Main St",
                City = "Christchurch",
                State = "Canterbury",
                Zip = "7000",
                Email = "mike@lmg.co.nz",
            },
            new Contact
            {
                Name = "Lorina Capistrano",
                ICP = "000000-003",
                MeterNo = "11113",
                MeterRead = 44.44,
                Address = "Broadmeadows",
                City = "Wellington",
                State = "Wellington",
                Zip = "6000",
                Email = "lorina@lmg.co.nz",
            },
            new Contact
            {
                Name = "LMG Employee1",
                ICP = "000000-004",
                MeterNo = "11114",
                MeterRead = 55.55,
                Address = "Island Bay",
                City = "Wellington",
                State = "Wellington",
                Zip = "6000",
                Email = "emp1@lmg.co.nz",
            }
            );
        }
    }
}
