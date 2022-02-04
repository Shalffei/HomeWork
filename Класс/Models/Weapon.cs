using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Класс.Enum;

namespace Класс.Models
{
    public class Weapon
    {
        public Weapon()
        {
            SerialNumber = "ABC123";
        }

        public Weapon (bool ok)
        {
            Name = "AK47";
            Type = TypeOfWeapon.automat;
            Ammo = 30;
        }

        public Weapon(string name, TypeOfWeapon type, int ammo)
        {
            Name = name;

            Type = type;

            Ammo = ammo;
        }
    
    public string Name { get; set; }

        public TypeOfWeapon Type {get; set;}

        public int Ammo { get; set;}

    private string SerialNumber { get; set; }
    
    //public string ReadSerialNumber()
        {

        }

    }
    
}
