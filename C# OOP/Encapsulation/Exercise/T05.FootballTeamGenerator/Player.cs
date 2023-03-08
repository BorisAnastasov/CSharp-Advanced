using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T05.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int skillLevel;
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            SkillLevel = CalculatingStats(endurance,sprint,dribble,passing,shooting);
        }

        public string Name 
        {
            get => name;
            private set 
            {

                value= name;
            }
        }
        public int SkillLevel 
        {
            get => skillLevel;
            set
            {
                skillLevel= value;
            } 
        }
        private int CalculatingStats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            double sum = (endurance+ sprint +dribble + passing + shooting)/5;
            int result = (int)Math.Round(sum);
            return result;
        }
    }
}
