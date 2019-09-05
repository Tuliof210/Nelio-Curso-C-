using System;
using RedeSocial.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zealand",
                "I'm going to visit this wonderful coutry",
                12);

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            p1.AddComment(c1, c2);

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            p2.AddComment(c3, c4);

            Console.WriteLine($"{p1}\n------------------------------\n\n{p2}");
            
            Console.ReadKey();
        }
    }
}
