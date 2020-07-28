using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teams.Model;

namespace Teams.Controller
{
    class MatchGenerator
    {
        public IEnumerable<Match> GeneratePossibleMatches(IEnumerable<Person> member)
        {
            var result = new List<Match>();

            var teams = GenerateTeams(member);

            foreach (var team in teams)
            {
                foreach (var secondTeam in teams.ToList())
                {
                    var neumatch = new Match(team, secondTeam);
                    if (neumatch.IsPossible() && !result.Any(e => e.Equals(neumatch)))
                        result.Add(neumatch);
                }
            }
            return result;
        }

        private IEnumerable<Team> GenerateTeams(IEnumerable<Person> member)
        {
            var result = new List<Team>();
            foreach (var entry in member)
            {
                foreach (var second in member.Where(e => !e.Equals(entry)).ToList())
                {
                    var neuteam = new Team(entry, second);
                    if (!result.Any(e => e.Equals(neuteam)))
                        result.Add(neuteam);
                }
            }
            return result;
        }
    }
}
