namespace MiniInstagram.Database
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MiniInstagram.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataBaseContext : IdentityDbContext<ApplicationUser>
    {
        public DataBaseContext()
            : base("name=DBContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public static DataBaseContext Create()
        {
            return new DataBaseContext();
        }

        public DbSet<Image> Images { get; set; }
    }
}