using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Класс.Models;

namespace Класс.Services
{
    public class SoldierServis
    {
        public void KillSoldier (Soldier soldier1, Soldier soldier2)
        {
            if (soldier2.Alive == false || soldier1.Alive == false)
                return;

            soldier2.Alive = false;

            soldier1.Expiriense += 1;

            Console.WriteLine($"Солдат {soldier1.Name} убил {soldier2.Name} оружием {soldier1.Weapon.Name}");

        }
    }
}
