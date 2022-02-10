using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;


namespace Tank_Factory.Service
{
    public class CreatTankServiceHeavy
    {
        public HeavyTank GetTankHeavy(string type, Chassis chassis, Engine engine, Frame frame, Tower tower, Weapon weapon, Ammo ammo, Factory factory)
        {
            HeavyTank tank = new HeavyTank();
            tank.Type = type;
            tank.Chassis = chassis;
            tank.Engine = engine;
            tank.Frame = frame;
            tank.Weapon = weapon;
            if (factory.Heavies == null)
                factory.Heavies = new List<HeavyTank>();
            if (type == "Heavy")
            Console.WriteLine($"You are creating {type} Tank. Your tank has been added to the collection in your Factory");
            factory.Heavies.Add(tank);
           

            return tank;

        }
    }
}
