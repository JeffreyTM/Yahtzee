using System;

namespace Yahtzee
{
    internal class DiceBlock : GameForm
    {
        public DiceBlock()
        {
            DiceValue = 0;
            IsHeld = false;
        }

        public int DiceValue { get; set; }
        public bool IsHeld { get; set; }

        public void Roll(Random rand)
        {
            DiceValue = rand.Next(1, 7);
        }
    }
}
