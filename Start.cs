using EfRelationshipsCodeFirst.Models.Contexts;
using System;
using System.Linq;

namespace EfRelationshipsCodeFirst
{
    class Start
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDbContext();
            var user = context.Users.Include("Password").First(x => x.Id == 1);
            Console.WriteLine("What is your name?");
            Console.WriteLine(user.Name);
            Console.WriteLine("What is your favorite color?");
            Console.WriteLine(user.Password.PasswordHash);
            user = context.Users.Include("Roles").First(x => x.Id == 1);
            Console.WriteLine("What is your quest?");
            Console.WriteLine(user.Roles.First(x => x.Id == 1).Name);
            Console.WriteLine("What is the capital of Assyria?");
            Console.WriteLine(user.Roles.First(x => x.Id == 2).Name);
            var users = context.Users.Include("Programs").ToList();
            users.ForEach(u =>
            {
                var progs = u.Programs.ToList();
                progs.ForEach(p =>
                {
                    Console.WriteLine("User " + u.Name + " has program " + p.Name);
                });
            });
            var programs = context.Programs.Include("Users").ToList();
            programs.ForEach(p =>
            {
                var usrs = p.Users.ToList();
                usrs.ForEach(u =>
                {
                    Console.WriteLine("Program " + p.Name + " has user " + u.Name);
                });
            });
        }
    }
}
