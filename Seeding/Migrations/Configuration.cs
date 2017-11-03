namespace Seeding.Migrations
{
    using Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Seeding.Models.CustomerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Seeding.Models.CustomerContext context)
        {
            context.CustomerList.AddOrUpdate(a => a.Id,
                new Customer
                {
                    Name = "Ria",
                    Location = "hld",
                    Phone = 9898988,
                    Email = "ria@gmail.com",
                    course = new Collection<Course>()
                    {
                        new Course()
                        {
                            CourseName="S.s.t",
                            Description="sssssssss"
                        }
                    }
                });
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
        }
    }
}
