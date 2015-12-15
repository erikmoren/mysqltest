using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace unclebob.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

    }
}