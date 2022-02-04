using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Service;
using Tank_Factory.Tank_Details;

namespace Tank_Factory.Models
{
    public class Tank
    {
        public string Type { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }
        public Frame Frame { get; set; }
        public Tower Tower { get; set; }
        public Weapon Weapon { get; set; }
    }
}
