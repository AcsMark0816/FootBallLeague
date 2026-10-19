using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llll
{
    public class Team
    {
        private string _name;
        private int _points;
        private int _goalsFor;
        private int _goalsAgaints;

        public string Name { get { return _name; } set { _name = value; } }
        public int Points { get { return _points; } set { _points = value; } }
        public int GoalsFor { get { return _goalsFor; } set { _goalsFor = value; } }
        public int GoalsAgaints { get { return _goalsAgaints; } set { _goalsAgaints = value; } } 

        
    public Team(string name)
        {
            _name = name;
            _points = 0;
            _goalsFor = 0;
            _goalsAgaints = 0;
        }
        public void AddResult(int goalsFor, int goalsAgaints)
        {
            _goalsFor += goalsFor;
            _goalsAgaints += goalsAgaints;
            if (goalsFor > goalsAgaints)
            {
                _points += 3;
            }
            else if (goalsFor == goalsAgaints)
            {
                _points += 1;
            }
        }
        public int GoalDifference()
        {
            return _goalsFor - _goalsAgaints;
        }

    } }

