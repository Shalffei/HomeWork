using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Service;



namespace Tank_Factory.Models
{
    public class Factory
    {
        public List<ArtilleryMount> Artilleries { get; set; }
        public List<HeavyTank> Heavies { get; set; }
        public List<MiddleTank> Middles { get; set; }
        public List<LightTank> Lights { get; set; }


    }
}
