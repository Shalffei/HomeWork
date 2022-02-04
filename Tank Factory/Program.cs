using Tank_Factory.Service;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;

CreatTank creatTank = new CreatTank();
Factory factory = new Factory();
var myModel = creatTank.GetTank("Middle T-34", Chassis.FortyTone, Engine.SixHundredHP, Frame.Middle, Tower.MiddleTower, Weapon.MiddleWeapon, factory);
myModel = creatTank.GetTank("Middle T-34", Chassis.FortyTone, Engine.ForHundredHP, Frame.Middle, Tower.MiddleTower, Weapon.MiddleWeapon, factory);
myModel = creatTank.GetTank("Havy Middle T-10", Chassis.SixtyTone, Engine.SixHundredHP, Frame.Heavy, Tower.HavyTower, Weapon.HeavyWeapon, factory);