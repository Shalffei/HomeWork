using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Tank_Details;
using Tank_Factory.Models;

namespace Tank_Factory.Service
{
    public class CreatTankServiceMiddle
    {
        public MiddleTank GetTankMiddle(string type, Chassis chassis, Engine engine, Frame frame, Tower tower, Weapon weapon, Factory factory)
        {
            MiddleTank tank = new MiddleTank();
            tank.Tower = tower;
            tank.Type = type;
            tank.Chassis = chassis;
            tank.Engine = engine;
            tank.Frame = frame;
            tank.Weapon = weapon;
            if (factory.Middles == null)
                factory.Middles = new List<MiddleTank>();
            Console.WriteLine($"You are creating {type} Tank. Your tank has been added to the collection in your Factory");
            factory.Middles.Add(tank);
            

            return tank;

        }
    }
}
