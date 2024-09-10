using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftSystemFall2024
{
    public class Person
    {
        public string PersonName = "Anonymous";
        public double Currency = 10.5;

        public Person(){ }
        

        public Person (string name)
        {
            PersonName = name;
        }

        public string About()
        {
            //interpolation
            
            string output = $"{PersonName} {Currency.ToString("c")}";
            //concatenation
            //string output = $"{PersonName} + " " + {Currency.ToString("c")}";

            //composite formatting
            //string output = $"{0} {1.ToString(\"c"\)}";

            return output;
        }

        public void ChangeName(string name)
        {
            PersonName = name; 
        }
    }
}