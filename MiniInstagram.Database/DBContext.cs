namespace MiniInstagram.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

        public DbSet<MiniInstagram.Web.Models.Image> Images { get; set; }
        public DbSet<MiniInstagram.Web.Models.ApplicationUser> Users { get; set; }
    }
}