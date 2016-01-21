namespace LabManager.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LabScheduler2.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<LabManager.DAL.LabContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
               
        }

        protected override void Seed(LabManager.DAL.LabContext context)
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
      new Supervisor { FirstName = "Mindy", LastName = "Greer" },
      new Supervisor { FirstName = "Elana", LastName = "" }
    );

            context.Benches.AddOrUpdate(p => p.Description,
                new Bench { Description = "Architect" },
                new Bench { Description = "Vista" },
                new Bench { Description = "Serology" },
                new Bench { Description = "UA" },
                new Bench { Description = "Coag" },
                new Bench { Description = "Hem1" },
                new Bench { Description = "Stools" },
                new Bench { Description = "DSX" },
                new Bench { Description = "Variant" },
                new Bench { Description = "Centaur" },
                new Bench { Description = "ESR" },
                new Bench { Description = "Sypigg" },
                new Bench { Description = "Diffs" },
                new Bench { Description = "Hem2" },
                new Bench { Description = "Sysmex" },
                new Bench { Description = "IFOB" },
                new Bench { Description = "VIT D"}
                );

            context.HourlyEmployees.AddOrUpdate(p => p.FirstName,
                new HourlyEmployee { FirstName = "Evelyn", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Imelda", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Jan", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Jerry", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Maribeth", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Marita", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Michelle", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Nirali", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Tony", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Violeta", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" },
                new HourlyEmployee { FirstName = "Wilberto", LastName = "", HoursPerWeek = 40.0m, IsActive = "Y" }
                );

        }
    }
}
