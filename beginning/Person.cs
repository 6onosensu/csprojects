using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_project
{
    public class Person
    {
        public string Name { get; set; }
        public int BirthdayYear;
        private int Age;
        public int Age 
        {
            get 
            { 
                age = DateTime.Now.Year - BirthdayYear;
                return age;
            }
            set { age = value; }
        }

        public Person(string name)
        { 
            Name = name;
        }
        public Person(string name, int age = 100)
        {
            Name = name;
            Age = age;
        }

        public void ShowAge()
        {
            console.WriteLine("I am " + Age + "years old");
        }
        public abstract float Income(float salary)
        {
            return salary;
        }
    }
}