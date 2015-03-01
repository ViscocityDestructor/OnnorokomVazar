using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class Location
    {
        public int LocationId { set; get; }
        public string DistrictName { set; get; }
        public ICollection<User> Users { set; get; } 
    }
}