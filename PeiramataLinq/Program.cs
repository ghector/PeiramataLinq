using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PeiramataLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor a1 = new Actor() { FirstName = "Di Caprio", Salary = 5000, Age = 33, Address = "Omonoia" };

            var a = typeof(Actor).GetMethod("Output");

            a.


            MyDatabase db = new MyDatabase();

            //Arithmitikes Linq
            // var plithos =  db.Movies.Count();

            //var plithos = db.Movies.Count(m => m.Price > 28000);


            //var mesitimi = db.Movies.Average(movie => movie.Price);

            //var athroisma = db.Movies.Sum(movie => movie.Price);

            //var pollaplasiasmo = db.Actors.Aggregate((a, b) => a.Age + b.Age);

            //List<int> lista = new List<int>() { 5, 6, 4 };

            //var athroisma = lista.Aggregate((a, b) => a + b * 2);
            //var athroisma2 = lista.Sum();

            //var lista = db.Actors.Take(4).AsEnumerable().OrderBy(x => x.FirstName);
            //var lista2 = db.Actors.Take(4).ToList().OrderBy(x => x.FirstName);

            //var tsimpa = db.Actors.ToList().TakeWhile(x=>x.Age<45);  //Skip SkipWhile

            //var resulat = db.Actors.Any(x => x.Age>43);
            //var resulat2 = db.Actors.All(x => x.Age>43);

            //-------------------
            //var goo = db.Actors.First(x => x.Age == 46);
            //var goo = db.Actors.FirstOrDefault(x => x.Age == 33);
            //var goo = db.Actors.ToList().LastOrDefault(x => x.Age == 33);
            //var goo = db.Actors.ToList().SingleOrDefault(x => x.Age == 33);


            //if(goo is null)
            //{
            //    Console.WriteLine("Den iparxei");
            //}
            //else
            //{
            //    Console.WriteLine(goo.FirstName);
            //}
            //




            ////Console.WriteLine(resulat2);
            //foreach (var item in goo)
            //{
            //    Console.WriteLine(item.FirstName);
            //}




            //var goo = db.Actors.Include(x=>x.Movie).ToList().FirstOrDefault(x => x.Age == 33);

            // var proxeiro = new
            // {
            //     Misthos = a1.Salary,
            //     Onoma = a1.FirstName
            // };
            //
            //Actor a1 = new Actor() { FirstName = "Di Caprio", Salary = 5000, Age = 33, Address = "Omonoia" };
            //Actor a2 = new Actor() { FirstName = "Tom Cruz", Salary = 7000, Age = 27, Address = "Exarxia" };
            //Actor a3 = new Actor() { FirstName = "Julia Roberts", Salary = 2000, Age = 25, Address = "Omonoia" };
            //Actor a4 = new Actor() { FirstName = "Beggos", Salary = 1000, Age = 35, Address = "Omonoia" };

            //List<Actor> actors = new List<Actor>() { a1, a2, a3, a4 };

            //var lista = actors.Select(actor =>
            // new
            // {
            //     Onoma = actor.FirstName,
            //     Misthos = actor.Salary
            // }

            //);



            //var lista2 = from actor in actors
            //             select new
            //             {
            //                 actor.FirstName,
            //                 actor.Salary
            //             };
            //Console.WriteLine("============================");


            //var lista4 = actors.Select(actor => actor);





            //var lista3 = actors.Select(actor => actor.Address);


            //foreach (var item in lista4)
            //{
            //    Console.WriteLine(item);
            //}


            //// Console.WriteLine(proxeiro.Misthos);

        }
    }




}
