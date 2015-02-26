using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class Location
    {
        public int LocationId { set; get; }
        public int Latitude { set; get; }
        public int Longitude { set; get; }
        public string Address { set; get; }
        public int UserId { set; get; }
        public ICollection<User> Users { set; get; } 
    }
}