using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using MiniInstagram.Database;
using MiniInstagram.Web.Models;

namespace MiniInstagram.Web.Controllers
{
    public class ValuesController : ApiController
    {
        DataBaseContext db = new DataBaseContext();

        public IEnumerable<Image> GetBooks()
        {
            return db.Images;
        }

        public Image GetImage(int id)
        {
            Image image = db.Images.Find(id);
            return image;
        }

        [HttpPost]
        public void CreateImage([FromBody] Image image)
        {
            db.Images.Add(image);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditBook(int id, [FromBody] Image image)
        {
            Guid ID = Guid.Parse(id.ToString());
            if (ID == image.Id)
            {
                db.Entry(image).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            Image image = db.Images.Find(id);
            if (image != null)
            {
                db.Images.Remove(image);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}