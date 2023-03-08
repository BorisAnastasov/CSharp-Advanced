using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using T05.FootballTeamGenerator;

namespace T05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> playerList;
        private int rating;

        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Rating 
        {
            get=>rating;
        }
        public void Add(Player player, Team team)
        {
           team.playerList.Add(player);
           Setting(team);                                          
        }
        public void Remove(string playerName, Team team)
        {
            Player player = team.playerList.FirstOrDefault(p => p.Name == playerName);
            try
            {
                team.playerList.Remove(player);
                Setting(team);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private int Setting(Team team) 
        {
             double resultDouble = 0;
             foreach (var item in team.playerList)
             {
                 resultDouble += item.SkillLevel;
             }
             resultDouble /= playerList.Count;
             return (int)Math.Round(resultDouble);
        }
    }
}
