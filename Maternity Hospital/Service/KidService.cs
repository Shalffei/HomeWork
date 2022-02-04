using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maternity_Hospital.EnumBirth;
using Maternity_Hospital.Models;
using Maternity_Hospital.Service;

namespace Maternity_Hospital.Service
{
    public class KidService
    {

        
        public Child GetChild(int growth, int weight, Eye eye, Sex sex, Mother mother)
        {
            Child child = new Child();
            child.Growth = growth;
            child.Weight = weight;
            child.Eye = eye;
            child.Sex = sex;
            child.Nationality = mother.Nationality;
            if (mother.ChildList == null)
            {
                mother.ChildList = new List<Child>();
            }
            mother.ChildList.Add(child);
            return child;
        }
    }
}
 