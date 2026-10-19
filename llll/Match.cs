using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llll
{
    public class Match
    {
        private Team _home;
        private Team _away;
        private int _homeGoals;
        private int _awayGoals;
        private bool _isPlayed;

        public Team Home
        {
            get { return _home; }
            set { _home = value; }
        }
        public Team Away
            {
            get { return _away; }
            set { _away = value; }
        }
        public int HomeGoals
            {
            get { return _homeGoals; }
            set { _homeGoals = value; }
        }
        public int AwayGoals
            {
            get { return _awayGoals; }
            set { _awayGoals = value; }
        }
        public bool IsPlayed
            {
            get { return _isPlayed; }
            set { _isPlayed = value; }
        }
        public Match(Team home, Team away)
        {
            Home = home;
            Away = away;
            HomeGoals = 0;
            AwayGoals = 0;
            IsPlayed = false;
        }
        public bool Play(int homeGoals, int awayGoals)
        {
            if(IsPlayed== false || homeGoals < 0 || awayGoals < 0)
            {
                return false;
            }
            else
            {
                HomeGoals = homeGoals;
                AwayGoals = awayGoals;
                IsPlayed = true;
                Home.AddResult(homeGoals, awayGoals);
                Away.AddResult(awayGoals, homeGoals);
                return true;
            }
        }
    }
}
