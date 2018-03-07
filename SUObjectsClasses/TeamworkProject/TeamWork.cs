using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProject
{
    class TeamWork
    {
        private static void PrintTeams(List<Team> teamsList)
        {
            var sortedTeams = teamsList
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name);
            foreach (var team in sortedTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.CreatorName}");

                var sortedMEmbers = team.Members
                    .OrderBy(x => x);
                foreach (var player in sortedMEmbers)
                {
                    Console.WriteLine($"-- {player}");
                }
            }
            var notValidTeams = teamsList
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name);
            Console.WriteLine("Teams to disband:");
            foreach (var team in notValidTeams)
            {
                Console.WriteLine(team.Name);
            }
            
        }
        static void Main()
        {
            var teamsList = new List<Team>();
            int teamsNumber = int.Parse(Console.ReadLine());
            //team creation
            for (int i = 0; i < teamsNumber; i++)
            {
                string input = Console.ReadLine();
                string creatorName = input
                    .Split(new [] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .First();
                string teamName = input
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .Last();

                if (teamsList.Any(x=>x.Name== teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamsList.Any(x=>x.CreatorName==creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");                   
                }
                else
                {
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    teamsList.Add(new Team(teamName, creatorName));
                }
            }

            string membersLine = Console.ReadLine();
            while (membersLine!= "end of assignment")
            {
                string teamMember = membersLine
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .First();
                string team = membersLine
                    .Split(new char[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries )
                    .Last();

                if (!teamsList.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teamsList.Any(x => x.Members.Any(p=>p== teamMember))||
                    teamsList.Any(x=>x.CreatorName==teamMember))
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {team}!");
                }
                else
                {
                    foreach (var item in teamsList)
                    {
                        if (item.Name==team)
                        {
                            item.Members.Add(teamMember);
                        }
                    }
                }

                membersLine = Console.ReadLine();
            }
            PrintTeams(teamsList);
        }

    }
    public class Team
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.CreatorName = creator;
            this.Members = new List<string>();
        }
    }
}
