using ConsoleApp.Domain;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TestContext();
            context.Add(new User
            {
                Id = 1,
                Name = "Gary",
            });

            context.SaveChanges();
        }
    }
}
