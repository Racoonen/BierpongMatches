using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Teams.Model
{
    class Match
    {
        public Team FirstTeam { get; set; }
        public Team SecondTeam { get; set; }

        public Match(Team aFirstTeam, Team aSecondTeam)
        {
            FirstTeam = aFirstTeam;
            SecondTeam = aSecondTeam;
        }

        public bool IsPossible()
        {
            if (FirstTeam.FirstMember.Equals(SecondTeam.FirstMember))
                return false;
            if (FirstTeam.SecondMember.Equals(SecondTeam.SecondMember))
                return false;
            if (FirstTeam.SecondMember.Equals(SecondTeam.FirstMember))
                return false;
            if (FirstTeam.FirstMember.Equals(SecondTeam.SecondMember))
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Match other)
            {
                return FirstTeam.Equals(other.FirstTeam) && SecondTeam.Equals(other.SecondTeam) ||
                     FirstTeam.Equals(other.SecondTeam) && SecondTeam.Equals(other.FirstTeam);


            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstTeam, SecondTeam);
        }

        public override string ToString()
        {
            return string.Format("{0} vs. {1}", FirstTeam, SecondTeam);
        }
    }
}
