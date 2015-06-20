using EfRelationshipsCodeFirst.Models;
using EfRelationshipsCodeFirst.Models.Contexts;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EfRelationshipsCodeFirst.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Users.AddOrUpdate(new User
            {
                Id = 1,
                Name = "Joe"
            });
            context.Passwords.AddOrUpdate(new Password
            {
                UserId = 1,
                EncryptionMethod = "MD5",
                PasswordHash = "blue"
            });
            context.Roles.AddOrUpdate(
                new Role
                {
                    Id = 1,
                    UserId = 1,
                    Name = "to find the holy grail"
                },
                new Role
                {
                    Id = 2,
                    UserId = 1,
                    Name = "Uh?"
                });
            context.Users.AddOrUpdate(new User
            {
                Id = 2,
                Name = "Jane"
            });
            context.Programs.AddOrUpdate(
                new Program
                {
                    Id = 1,
                    Name = "A"
                },
                new Program
                {
                    Id = 2,
                    Name = "B"
                });
            var user1 = context.Users.Include("Programs").First(x => x.Id == 1);
            var user2 = context.Users.Include("Programs").First(x => x.Id == 2);
            if (user1.Programs.Count == 0)
            {
                foreach (var prog in context.Programs)
                {
                    user1.Programs.Add(prog);
                }
                context.SaveChanges();
            }
            if (user2.Programs.Count == 0)
            {
                foreach (var prog in context.Programs)
                {
                    user2.Programs.Add(prog);
                }
                context.SaveChanges();
            }
        }
    }
}
