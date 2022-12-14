namespace MVCMovie2.Migrations
{
    using MVCMovie2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCMovie2.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCMovie2.Models.MovieDBContext";
        }

        protected override void Seed(MVCMovie2.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
       new Movie
       {
           Title = "When Harry Met Sally",
           ReleaseDate = DateTime.Parse("1989-1-11"),
           Genre = "Romantic Comedy",
           Price = 7.99M,
               Rating = "PG",

       },

        new Movie
        {
            Title = "Ghostbusters ",
            ReleaseDate = DateTime.Parse("1984-3-13"),
            Genre = "Comedy",
            Price = 8.99M,
                Rating = "PG",

        },

        new Movie
        {
            Title = "Ghostbusters 2",
            ReleaseDate = DateTime.Parse("1986-2-23"),
            Genre = "Comedy",
            Price = 9.99M,
                Rating = "PG",

        },

      new Movie
      {
          Title = "Rio Bravo",
          ReleaseDate = DateTime.Parse("1959-4-15"),
          Genre = "Western",
          Price = 3.99M,
             Rating = "PG",

      }
  );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
