namespace PeiramataLinq.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PeiramataLinq.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PeiramataLinq.MyDatabase context)
        {
            Actor a1 = new Actor() { FirstName = "Di Caprio", Salary = 5000, Age = 33, Address = "Omonoia" };
            Actor a2 = new Actor() { FirstName = "Tom Cruz", Salary = 7000, Age =27, Address = "Exarxia" };
            Actor a3 = new Actor() { FirstName = "Julia Roberts", Salary = 2000, Age = 25, Address = "Omonoia" };
            Actor a4 = new Actor() { FirstName = "Beggos", Salary = 1000, Age = 35, Address = "Omonoia" };

            Movie m1 = new Movie() { Title = "Avatar", Price = 30000, Category = "Drama",
            Actors = new List<Actor>() { a1,a2}
            };
            Movie m2 = new Movie() { Title = "Titanic", Price = 20000, Category = "Action",
                Actors = new List<Actor>() { a3 }
            };
            Movie m3 = new Movie() { Title = "PowerRangers", Price = 40000, Category = "Comedy",
                Actors = new List<Actor>() { a4}
            };

            context.Actors.AddOrUpdate(x => x.FirstName, a1, a2, a3, a4);
            context.Movies.AddOrUpdate(x => x.Title, m1,m2,m3);

            context.SaveChanges();



        }
    }
}
