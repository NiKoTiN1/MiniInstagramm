namespace MiniInstagram.Database
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MiniInstagram.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBContext : IdentityDbContext<ApplicationUser>
    {
        public DBContext()
            : base("name=DBContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DBContext>());
        }
        public static DBContext Create()
        {
            return new DBContext();
        }

        public DbSet<Image> Images { get; set; }
    }
}