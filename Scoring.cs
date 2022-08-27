namespace Yahtzee
{
    internal class Scoring //Constructor: Scoring(string scoreName, bool isScore, int scoreValue)
    {

        public Scoring()
        {
            ScoreValue = 0;
            IsScored = false;
        }

        public int ScoreValue { get; set; }
        public bool IsScored { get; set; }

    }
}
