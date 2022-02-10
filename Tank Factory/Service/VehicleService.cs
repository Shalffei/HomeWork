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
        public Vehicle CreatVehicle(string type, Chassis chassis, Engine engine, Frame frame, Weapon weapon, string vehicleType)
        {
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
            vehicle.Type = type;
            vehicle.Chassis = chassis;
            vehicle.Engine = engine;
            vehicle.Frame = frame;
            vehicle.Weapon = weapon;
            return vehicle;
            
            
            
        }
    }
}
