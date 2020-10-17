using System;
using Strings.ex2.Entities;

namespace Strings.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            System.Console.WriteLine(p1);
        }
    }
}
