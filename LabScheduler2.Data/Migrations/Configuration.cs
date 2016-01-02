namespace LabScheduler2.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabScheduler2.Data.LabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LabScheduler2.Data.LabContext context)
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
            context.Supervisors.AddOrUpdate(
      p => p.LastName,
      new Domain.Supervisor { FirstName = "Mindy", LastName = "Greer" },
      new Domain.Supervisor { FirstName = "Elana", LastName = "Postawa" }


    );


            context.Benches.AddOrUpdate(p => p.Description,
                new Domain.Bench { Description = "Centar" },
                new Domain.Bench { Description = "Bench1" },
                new Domain.Bench { Description = "Bench2" },
                new Domain.Bench { Description = "Bench3" },
                new Domain.Bench { Description = "Bench4" },
                new Domain.Bench { Description = "Bench5" },
                new Domain.Bench { Description = "Bench6" },
                new Domain.Bench { Description = "Bench7" },
                new Domain.Bench { Description = "Bench8" },
                new Domain.Bench { Description = "Bench9" },
                new Domain.Bench { Description = "Bench10" },
                new Domain.Bench { Description = "Bench11" },
                new Domain.Bench { Description = "Bench12" },
                new Domain.Bench { Description = "Bench13" },
                new Domain.Bench { Description = "Bench14" },
                new Domain.Bench { Description = "Bench15" },
                new Domain.Bench { Description = "Bench16" }

                );

            context.HourlyEmployees.AddOrUpdate(p => p.LastName,
                new Domain.HourlyEmployee { FirstName = "John", LastName = "Doe", HoursPerWeek = 40.0m, IsActive = "Y" },
                new Domain.HourlyEmployee { FirstName = "Jane", LastName = "Baker", HoursPerWeek = 40.0m, IsActive = "Y" }
                );
        }
    }
}
