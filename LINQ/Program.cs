using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Super Mario", "Crash Bandicoot", "Horizon"};

            var games = videoGames.OrderBy(name => name.Length);

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
        }
    }
}
