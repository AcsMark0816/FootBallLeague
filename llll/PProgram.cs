using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llll
{
    public class PProgram
    {
        public static void Main(string[] args)
        {
            League league = new League("Premier League");
            Team team1 = new Team("A");
            Team team2 = new Team("B");
            Team team3 = new Team("C");
            league.AddTeam(team1);
            league.AddTeam(team2);
            league.AddTeam(team3);
            league.AddMatch(team1, team2);
            league.AddMatch(team2, team3);
            league.AddMatch(team3, team1);
            
            team1.AddResult(2, 1); 
            team2.AddResult(1, 1); 
            team3.AddResult(0, 3); 
            
            Console.WriteLine($"League: {league.Name}");
            foreach (var team in league.Teams)
            {
                Console.WriteLine($"Team: {team.Name}, Points: {team.Points}, Goals For: {team.GoalsFor}, Goals Against: {team.GoalsAgaints}, Goal Difference: {team.GoalDifference()}");
            }
        }
    }
}
