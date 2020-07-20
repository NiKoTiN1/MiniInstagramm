using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniInstagram.Web.Models
{
    public class ApplicationUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}