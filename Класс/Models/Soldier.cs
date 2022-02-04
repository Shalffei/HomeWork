using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Класс.Models
{
    public class Soldier
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Weapon Weapon { get; set; }

        public bool Alive { get; set; }
        
        public int Expiriense { get; set; }
    }
}
