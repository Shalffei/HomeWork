using Класс.Models;
using Класс.Enum;
using Класс.Services;

Weapon weapon = new Weapon();
var resultSerialNumber = weapon.ReadSerialNumber();
Soldier soldier1 = new Soldier();
soldier1.Name = "Andrey";
soldier1.Alive = true;
soldier1.Weapon = new Weapon();
soldier1.Weapon.Name = "M4";
soldier1.Weapon.Type = TypeOfWeapon.automat;
soldier1.Weapon.Ammo = 30;
soldier1.Age = 28;
soldier1.Expiriense = 1;
Soldier soldier2 = new Soldier() { Age = 29, Alive = true, Expiriense = 1, Weapon = new Weapon() { Name = "Knife", Ammo = 30, Type = TypeOfWeapon.knife}, Name = "Taras" };
SoldierServis soldierServis = new SoldierServis(); 
soldierServis.KillSoldier(soldier1, soldier2);
Console.WriteLine(resultSerialNumber);
Console.ReadKey();

