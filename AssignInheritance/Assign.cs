using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignInheritance
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int no_of_matches;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string TeamName
        {
            get
            {
                return teamname;
            }
            set
            {
                teamname = value;
            }
        }
        public int Matches
        {
            get
            {
                return no_of_matches;
            }
            set
            {
                no_of_matches = value;
            }
        }
        public Player(string name,string teamname,int matches)
        {
            this.name = name;
            this.teamname = teamname;
            this.no_of_matches = matches;
            Console.WriteLine("player constructor");
        }
        public abstract void DisplayPlayerStatistics();
    }
    class CricketPlayer:Player
    {
        int totalruns, no_of_wickets;
        //public int Total
        //{
        //    get
        //    {
        //        return totalruns;
        //    }
        //    set
        //    {
        //        totalruns = value;
        //    }
        //}
        //public int Wickets
        //{
        //    get
        //    {
        //        return no_of_wickets;
        //    }
        //    set
        //    {
        //        no_of_wickets = value;
        //    }
        //}
        
        public CricketPlayer(string name, string teamname, int matches,int runs,int wick):base(name, teamname, matches)

        {
            this.totalruns = runs;
            this.no_of_wickets = wick;
            Console.WriteLine("Cricket constructor");
        }
        public override void DisplayPlayerStatistics()
        {

            Console.WriteLine("Player name: " + this.name + "\nTeam name: " + this.teamname + "\nNo_of_matches " + this.no_of_matches + "\ntotal runs: " + this.totalruns + "\nNo_Of_wickets: " + this.no_of_wickets);
        }
    }
    class HockeyPlayer:Player
    {
        int no_of_goals;
        string position;
        
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("Player name: " + this.name + "\nTeam name: " + this.teamname + "\nNo_of_matches " + this.no_of_matches + "\nPosition: " + this.position + "\nNo_Of_goals: " + this.no_of_goals);

        }
        public HockeyPlayer(string name,string teamname,int matches,string position, int goals):base(name,teamname,matches)
        {
            this.position = position;
            this.no_of_goals = goals;
            Console.WriteLine("Hockey parameter constructor");
        }

    }
}
