using System;
using System.Collections.Generic;
using System.Globalization;
using Teams.Controller;
using Teams.Model;

namespace Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new MatchGenerator();
            var member = new List<Person>()
            {
                new Person("Jennifer"),
                new Person("Michel"),
                new Person("Philipp"),
                new Person("Anka"),
                new Person("Jonas")
            };
            foreach (var match in generator.GeneratePossibleMatches(member))
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
