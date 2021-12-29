using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }
    class PlayerImplementation
    {
        public int Average(IList<Player> players)
        {
            int count = 0;
            int avg = 0;
            foreach (var item in players)
            {
                avg = avg + item.Score;
                count++; 
            }
            avg = avg / count;
            return avg;
        }
        public int Max(IList<Player> players)
        {
            var result = players.Max(o => o.Score);
            return result;
        }
        public int Min(IList<Player> players)
        {
            var result = players.Min(o => o.Score);
            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            players.Add(new Player { Name = "X", Team = "A", Score = 50 });
            players.Add(new Player { Name = "X", Team = "A", Score = 30 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine(playerImplementation.Average(players));
            Console.WriteLine(playerImplementation.Max(players));
            Console.WriteLine(playerImplementation.Min(players));
        }
    }

    
}
