using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Tank_Details;

namespace Tank_Factory.Models
{
    public class Vehicle
    {
        readonly Ammo _TypeAmmo = Ammo.explosive;
        public string Type { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }
        public Frame Frame { get; set; }
        public Weapon Weapon { get; set; }
        public Color? Color { get; set; }
        public DateTime? DateTimeMade { get; set; }
        public int HungarNumber { get; set; }
    }
}
