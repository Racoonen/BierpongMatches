using System;
using System.Collections.Generic;
using System.Text;

namespace Teams.Model
{
    class Team
    {
        public Person FirstMember { get; set; }
        public Person SecondMember { get; set; }

        public Team(Person entry, Person second)
        {
            FirstMember = entry;
            SecondMember = second;
        }

        public override bool Equals(object obj)
        {
            if (obj is Team other)
            {
                return FirstMember.Equals(other.FirstMember) && SecondMember.Equals(other.SecondMember) ||
                    FirstMember.Equals(other.SecondMember) && SecondMember.Equals(other.FirstMember);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstMember, SecondMember);
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}", FirstMember, SecondMember);
        }
    }
}
