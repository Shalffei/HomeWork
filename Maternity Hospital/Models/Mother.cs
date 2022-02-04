using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maternity_Hospital.EnumBirth;

namespace Maternity_Hospital.Models
{
    public class Mother
    {
        public Nationality Nationality { get; set; }
        public string Name { get; set; }
        public Child Child { get; set; }
        public List<Child> ChildList { get; set;}

    }
}
