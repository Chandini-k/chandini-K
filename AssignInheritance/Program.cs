using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.Cricket Player Details\n2.Hockey player Details");
            Console.WriteLine("Enter choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter player name\n");
                    string cname = Console.ReadLine();
                    Console.WriteLine("enter team name\n");
                    string cteamname = Console.ReadLine();
                    Console.WriteLine("Enter no of matches\n");
                    int cmatches = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter total runs scored\n");
                    int runs =int.Parse( Console.ReadLine());
                    Console.WriteLine("Enter total number of wickets\n");
                    int wick = int.Parse(Console.ReadLine());
                    CricketPlayer cri = new CricketPlayer(cname,cteamname,cmatches,runs,wick);
                    cri.DisplayPlayerStatistics();
                    break;
                case 2:
                    Console.WriteLine("Enter player name\n");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter team name\n");
                    string teamname = Console.ReadLine();
                    Console.WriteLine("Enter no of matches\n" );
                    int matches = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter position\n");
                    string position = Console.ReadLine();
                    Console.WriteLine("Enter total number of goals\n");
                    int goals = int.Parse(Console.ReadLine());
                    HockeyPlayer ho = new HockeyPlayer(name, teamname, matches, position, goals);
                    ho.DisplayPlayerStatistics();
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            
            }
            Console.ReadLine();
        }
    }
}
