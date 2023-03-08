namespace T05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Team> teams = new List<Team>();
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] cmd = input.Split(";");
                    if (cmd[0] == "Team")
                    {
                        string name = cmd[1];
                        Team team = new(name);
                        teams.Add(team);
                    }
                    else if (cmd[0] == "Add")
                    {
                        string name = cmd[1];
                        string playerName = cmd[2];
                        int endurance = int.Parse(cmd[3]);
                        int sprint = int.Parse(cmd[4]);
                        int dribble = int.Parse(cmd[5]);
                        int passing = int.Parse(cmd[6]);
                        int shooting = int.Parse(cmd[7]);
                        Player player = new(playerName, endurance, sprint, dribble, passing, shooting);
                        foreach (var item in teams)
                        {
                            if (item.Name == name)
                            {
                                item.Add(player, item);
                                break;
                            }
                        }
                    }    
                    else if (cmd[0] == "Remove")
                    {
                        string name = cmd[1];
                        string playerName = cmd[2];
                        foreach (var item in teams)
                        {
                            if (item.Name == name)
                            {
                                item.Remove(playerName, item);
                                break;
                            }
                        }
                    }
                    else if (cmd[0] == "Rating")
                    {
                        string name = cmd[1];
                        Team team = teams.FirstOrDefault(t => t.Name == name);
                        Console.WriteLine($"{team.Name} - {team.Rating}");
                    }
                    input = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}