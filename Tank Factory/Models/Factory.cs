using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;



namespace Tank_Factory.Models
{
    public class Factory
    {
        Tank heavy = new Tank();
        
        public List<Tank> Tanks { get; set; }


    }
}
