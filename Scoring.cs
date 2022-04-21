using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    internal class Scoring //Constructor: Scoring(string scoreName, bool isScore, int scoreValue)
    {
        public Scoring(string scoreName, bool isScored, int scoreValue)
        {
            this.ScoreName = scoreName;
            this.IsScored = isScored;
            this.ScoreValue = scoreValue;
        }

        public string ScoreName { get; set; }
        public bool IsScored { get; set; }
        public int ScoreValue { get; set; }
    }
}
