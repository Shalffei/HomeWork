using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maternity_Hospital.Models;
using Maternity_Hospital.EnumBirth;

namespace Maternity_Hospital.Service
{
    public class MotherService
    {
        public Mother GetMother(string name, Nationality nationality)
        {
            Mother mother = new Mother();
            mother.Name = name;
            mother.Nationality = nationality;
            return mother;
        }
    }
}
