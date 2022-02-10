using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;


namespace Tank_Factory.Service
{
    static class DoColorDateAddFactory
    {
        public static void GetColor(this Vehicle vehicle, Color color)
        {
            vehicle.Color = color;
            vehicle.DateTimeMade = DateTime.Now;
            
        }
    }
}
