using Tank_Factory.Service;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;

CreatTankServiceArtillery creatTankArtillery = new CreatTankServiceArtillery();
CreatTankServiceMiddle creatTankServiceMiddle = new CreatTankServiceMiddle();
VehicleService vehicleService = new VehicleService();
var myModel = vehicleService.CreatVehicle("Artillery Mount", Chassis.SixtyTone, Engine.SixHundredHP, Frame.Middle, Weapon.HeavyWeapon, "Artillery");
var artillery = myModel as ArtilleryMount;
artillery.GetColor(Color.yellow);


Factory factory = new Factory();
var myModelMiddle = creatTankServiceMiddle.GetTankMiddle("Middle", Chassis.FortyTone, Engine.SixHundredHP, Frame.Middle, Tower.MiddleTower, Weapon.MiddleWeapon, factory);
var myModelArtillery = creatTankArtillery.GetTankArtillery("Artillery Mount", Chassis.SixtyTone, Engine.SixHundredHP, Frame.Middle, Weapon.HeavyWeapon, DateTime.Now, factory);
myModelMiddle.GetColor(Color.yellow);
//myModelArtillery.GetColor(Color.black, DateTime.Now);
//DoColorDateAddFactory.GetColor(Color.yellow, DateTime.Now);


