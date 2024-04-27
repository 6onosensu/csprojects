using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_project
{
    public class Employee: Person
    {
        public string Organization;
        public string Position;
        public float Wages;
        public override float Income(float Wages)
        {
            Wages = (Wages - 640) * 0.8 + 654;
            return Wages;
        }
    }
}
