using MiniInstagram.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInstagram.Database
{
    class AppDatabaseContext: DbContext
    {
        DbSet<Image> Images { get; set; }
    }
}
