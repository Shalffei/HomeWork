using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;

namespace Tank_Factory.Service
{
    public class CreatTankServiceLight
    {
        public ArtilleryMount GetTankArtillery(string type, Chassis chassis, Engine engine, Frame frame, Weapon weapon, Ammo ammo, Factory factory)
        {
            ArtilleryMount tank = new ArtilleryMount();
            tank.Type = type;
            tank.Chassis = chassis;
            tank.Engine = engine;
            tank.Frame = frame;
            tank.Weapon = weapon;
            if (factory.Artilleries == null)
                factory.Artilleries = new List<ArtilleryMount>();
            Console.WriteLine($"You are creating {type} Tank. Your tank has been added to the collection in your Factory");
            factory.Artilleries.Add(tank);


            return tank;
        }
    }
}
