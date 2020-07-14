using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniInstagram.Web.Models
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Path { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime UploadDate { get; set; }
        public Category category { get; set; } = Category.Other;
    }
}