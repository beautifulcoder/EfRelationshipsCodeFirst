using System.Data.Entity;

namespace EfRelationshipsCodeFirst.Models.Contexts
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(@"Data Source=(LocalDb)\v11.0;
            AttachDbFilename=C:\Dev\Publish\EfRelationshipsCodeFirst\App_Data\EfRelationshipsCodeFirstDb.mdf;
            Integrated Security=True;
            Connect Timeout=30")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}
