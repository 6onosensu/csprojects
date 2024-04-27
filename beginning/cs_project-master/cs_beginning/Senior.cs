using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_project
{
    public class Senior: Person
    {
        public int Experience;
        public Senior() 
        {

        }
        public override float Income(float salary)
        {
            return salary * (1 + ((float)Experience / 100));
        }
    }
}