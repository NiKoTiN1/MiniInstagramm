using Microsoft.AspNet.Identity.EntityFramework;
using MiniInstagram.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniInstagram.Database
{
    public class DbInitialaser: DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext d      b)
        {
            ApplicationUser user2 = new ApplicationUser
            {
                UserName = "NBNN111222221"
            };
            Image img1 = new Image()
            {
                Id = new Guid(),
                category = Category.Other,
                Path = "1233333",
                UploadDate = DateTime.Now,
                User = user2
                
            };
            db.Users.Add(user2);
            db.Images.Add(img1);
            db.SaveChanges();

            base.Seed(db);
        }
    }
}
