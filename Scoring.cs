namespace Yahtzee
{
    internal class Scoring //Constructor: Scoring(string scoreName, bool isScore, int scoreValue)
    {
        public Scoring(int scoreValue, bool isScored)
        {
            this.ScoreValue = scoreValue;
            this.IsScored = isScored;
        }

        public int ScoreValue { get; set; }
        public bool IsScored { get; set; }

    }
}
