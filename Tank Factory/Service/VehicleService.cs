using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;

namespace Tank_Factory.Service
{
    public class VehicleService
    {
        public object CreatVehicle(string type, Chassis chassis, Engine engine, Frame frame, Weapon weapon, string vehicleType, int hungarNumber, Factory factory)
        {
            Random random = new Random();
            Vehicle vehicle = null;
            if (vehicleType == "HeavyTank")
            {
                vehicle = new HeavyTank { Tower = Tower.HavyTower};
            }
            if (vehicleType == "MiddleTank")
            {
                vehicle = new MiddleTank { Tower = Tower.MiddleTower };
            }
            if (vehicleType == "LightTank")
            {
                vehicle = new LightTank { Tower = Tower.MiddleTower };
            }
            if (vehicleType == "Artillery")
            {
                var test = new ArtilleryMount();
                test.Degree = -15;
                vehicle = test;
                vehicle = new ArtilleryMount { Degree = -15 };
            }
            vehicle.HungarNumber = hungarNumber;
            vehicle.Type = type;
            vehicle.Chassis = chassis;
            vehicle.Engine = engine;
            vehicle.Frame = frame;
            vehicle.Weapon = weapon;
            vehicle.DateTimeMade = new DateTime (random.Next(2000, 2021), random.Next(1, 12), random.Next(1, 28));
            if (factory.Artilleries == null)
            { 
                factory.Artilleries = new List<ArtilleryMount>(); 
            }
           
            factory.Artilleries.Add(vehicle as ArtilleryMount);
            return vehicle;
            
            
            
        }
    }
}
