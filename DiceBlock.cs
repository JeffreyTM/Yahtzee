namespace Yahtzee
{
    internal class DiceBlock //Constructor: DiceBlock(int diceValue, bool isHeld)
    {
        public DiceBlock(int diceValue, bool isHeld)
        {
            this.DiceValue = diceValue;
            this.IsHeld = isHeld;
        }

        public int DiceValue { get; set; }
        public bool IsHeld { get; set; }
    }

}
