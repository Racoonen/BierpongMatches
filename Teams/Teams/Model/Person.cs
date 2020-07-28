using System;
using System.Collections.Generic;
using System.Text;

namespace Teams.Model
{
    class Person
    {
        public string Name { get; set; }

        public Person(string aName)
        {
            Name = aName;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person pers)
            {
                return Name.Equals(pers.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
