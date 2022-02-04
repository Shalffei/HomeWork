using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;

namespace Tank_Factory.Service
{
    public class CreatTank
    {
        public Tank GetTank(string type, Chassis chassis, Engine engine, Frame frame, Tower tower, Weapon weapon, Factory factory)
        {
            Tank tank = new Tank();
            tank.Type = type;
            tank.Chassis = chassis;
            tank.Engine = engine;
            tank.Frame = frame;
            tank.Tower = tower;
            tank.Weapon = weapon;
            if (factory.Tanks == null)
                factory.Tanks = new List<Tank>();  
                factory.Tanks.Add(tank);
            if (tank.Tower == Tower.HavyTower && tank.Engine == Engine.SixHundredHP && tank.Weapon == Weapon.HeavyWeapon && tank.Chassis == Chassis.SixtyTone && tank.Frame == Frame.Heavy)
                Console.WriteLine($"You are creating Heavy Tank {type}. Your tank has been added to the collection in your Factory");
            else if (tank.Tower == Tower.MiddleTower && tank.Engine == Engine.ForHundredHP && tank.Weapon == Weapon.MiddleWeapon && tank.Chassis == Chassis.FortyTone && tank.Frame == Frame.Middle)
                Console.WriteLine($"You are creating Middle Tank{type}. Your tank has been added to the collection in your Factory");
            else
                {
                Console.WriteLine("Error, parts not applicable to this chassis or Tower, Engine, Frame, Weapon");
                } 
            
            return tank;

        }
    }
}
