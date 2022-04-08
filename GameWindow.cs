using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Yahtzee
{

    public partial class GameWindow : Form
    {

        public GameWindow()
        {
            InitializeComponent();
        }

        Dictionary<string, bool> scorecard = new Dictionary<string, bool>();
        DiceBlock[] allDice = new DiceBlock[5];
        Dictionary<int, int> turnsHeld = new Dictionary<int, int>();
        Dictionary<int, int> timesRolled = new Dictionary<int, int>();
        int turn = 1;
        int totalScore = 0;
        string[] scoreTypes = {"Aces", "Twos", "Threes", "Fours", "Fives", "Sixes",
                                "Three of a kind" , "Four of a Kind", "Full House",
                                "Small Straight", "Large Straight", "Yahtzee"};

        private void GameWindow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                allDice[i] = new DiceBlock(0, false);

            foreach (string score in scoreTypes)
                scorecard.Add(score, false);

            for (int i = 1; i <= 6; i++)
            {
                turnsHeld.Add(i, 0);
                timesRolled.Add(i, 0);
            }

            

        }

        public class DiceBlock //Constructor: DiceBlock(int faceValue, bool isHeld)
        {
            private int diceValue;
            private bool isHeld;

            public DiceBlock(int diceValue, bool isHeld)
            {
                this.diceValue = diceValue;
                this.isHeld = isHeld;
            }

            public int DiceValue
            {
                get { return this.diceValue; }
                set { this.diceValue = value; }
            }

            public bool IsHeld
            {
                get { return this.isHeld; }
                set { this.isHeld = value; }
            }

        }


        private void rollButton_Click(object sender, EventArgs e)
        {

            if (turn > 3)
            {
                DialogResult dialog = MessageBox.Show("Round over. Please select an area that you would like to score.",
                                     Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Random rand = new Random();
            listBox1.Items.Clear();
            if (turn < 3)
                roundLabel.Text = "Turn " + turn + " of 3. Choose a category to score or " +
                    "choose which blocks you would like to hold and roll again.";
            else
                roundLabel.Text = "Turn " + turn + " of 3. Choose which category you would like to score.";
            


            for (int i = 0; i < allDice.Length; i++)
            {
                if (allDice[i].DiceValue == 0)
                {
                    allDice[i].DiceValue = rand.Next(1, 7);
                    timesRolled[allDice[i].DiceValue]++;

                    listBox1.Items.Add(allDice[i].DiceValue);

                }

                else if (!allDice[i].IsHeld)
                {
                    allDice[i].DiceValue = rand.Next(1, 7);
                    timesRolled[allDice[i].DiceValue]++;

                    listBox1.Items.Add(allDice[i].DiceValue);

                }
                else
                {
                    turnsHeld[allDice[i].DiceValue]++;

                    listBox1.Items.Add(allDice[i].DiceValue);
                
                }

            }
            SetDiceImage(allDice);
            turn++;


            //Displays all of the dice rolls and how many times they've been held in a turn. Stream to file
            foreach (int diceBlock in turnsHeld.Keys)
            {
                string value = scoreTypes[diceBlock - 1];
                listBox1.Items.Add(value + ": " + turnsHeld[diceBlock] + " times held in a turn.");
            }

            //Displays all the dice rolls and how many times each block has been rolled
            foreach (int diceBlock in timesRolled.Keys)
            {
                string value = scoreTypes[diceBlock - 1];
                listBox1.Items.Add(value + ": " + timesRolled[diceBlock] + " times rolled.");
            }

        }


        

        //Use method to display all roll values, inside method, check to see if value is already scored

        public void SetDiceImage(DiceBlock[] allDice)
        {
            PictureBox[] dicePics = { dicePictureBox1, dicePictureBox2, dicePictureBox3, dicePictureBox4, dicePictureBox5 };


            for (int i = 0; i < allDice.Length; i++)
            {
                switch (allDice[i].DiceValue)
                {
                    case 1:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1cropped;
                        break;

                    case 2:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock2gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock2cropped;
                        break;

                    case 3:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock3gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock3cropped;
                        break;

                    case 4:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock4gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock4cropped;
                        break;

                    case 5:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock5gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock5cropped;
                        break;

                    case 6:
                        if (allDice[i].IsHeld)
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock6gray;
                        else
                            dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock6cropped;
                        break;

                    case 0:
                        dicePics[i].Image = global::Yahtzee.Properties.Resources.diceblock1cropped;
                        break;

                    default:
                        DialogResult dialog = MessageBox.Show("Error: Cannot set dice image.",
                                     Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

        }


        public void ResetTurn()
        {
            foreach (DiceBlock singleDice in allDice)
            {
                singleDice.DiceValue = 0;
                singleDice.IsHeld = false;
            }

            SetDiceImage(allDice);

            turn = 1;
            roundLabel.Text = "Click \"Roll\" to Begin the Next Round";

        }


        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Close();
        }


       

        
        /*
         * 
         * ALL LABEL CLICK EVENT HANDLERS
         * 
         */

        private void acesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file

            if (acesLabel.Text == "---" && turn > 1)
            {
                int acesTotal = scoreAces();
                acesLabel.Text = acesTotal.ToString();

                totalScore += acesTotal;
                totalLabel.Text = totalScore.ToString();

                ResetTurn();
            }


            //add stats stuff
            
        }

        private void twosBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file

            if (twosLabel.Text == "---" && turn > 1)
            {
                int twosTotal = scoreTwos();
                twosLabel.Text = twosTotal.ToString();

                totalScore += twosTotal;
                totalLabel.Text = totalScore.ToString();

                ResetTurn();
            }
        }

        private void threesBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file

            if (threesLabel.Text == "---" && turn > 1)
            {
                int threesTotal = scoreThrees();
                threesLabel.Text = threesTotal.ToString();

                totalScore += threesTotal;
                totalLabel.Text = totalScore.ToString();

                ResetTurn();
            }
        }

        private void foursBGLabel_Click(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file

            if (foursLabel.Text == "---" && turn > 1)
            {
                int foursTotal = scoreFours();
                foursLabel.Text = foursTotal.ToString();

                totalScore += foursTotal;
                totalLabel.Text = totalScore.ToString();

                ResetTurn();
            }
        }

        private void fivesBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void sixesBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void threeKindBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void fourKindBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullHouseBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void smallStraightBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void largeStraightBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void yahtzeeBGLabel_Click(object sender, EventArgs e)
        {

        }

        private void chanceBGLabel_Click(object sender, EventArgs e)
        {

        }


        /*
         * 
         * ALL SCORECARD LOGIC
         * 
         */

        public bool isLastScore()
        {
            //Use to determine if the scorecard is completely full

            foreach (string scoreType in scorecard.Keys)
            {
                if (scorecard[scoreType] == false)
                    return false;
            }

            return true;
        }

        public int scoreAces()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 1)
                    score += 1;
            }


            return score;
        }

        public int scoreTwos()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 2)
                    score += 2;
            }

            return score;
        }

        public int scoreThrees()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 3)
                    score += 3;
            }

            return score;
        }

        public int scoreFours()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 4)
                    score += 4;
            }

            return score;
        }

        public int scoreFives()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 5)
                    score += 5;
            }

            return score;
        }

        public int scoreSixes()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
            {
                if (dice.DiceValue == 6)
                    score += 6;
            }

            return score;
        }

        public int scoreThreeOfAKind()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of at least 4
                if (counts[key] >= 3)
                {
                    foreach (DiceBlock dice in allDice)
                        score += dice.DiceValue;
                }
            }

            return score;

        }

        public int scoreFourOfAKind()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of at least 4
                if (counts[key] >= 4)
                {
                    foreach (DiceBlock dice in allDice)
                        score += dice.DiceValue;
                }
            }

            return score;

        }

        public int scoreFullHouse()
        {
            int score = 0;
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (DiceBlock dice in allDice)
            {
                if (counts.ContainsKey(dice.DiceValue)) //If the value dice is already a key value
                {
                    //Increment the key value's count by 1
                    counts[dice.DiceValue]++;
                }
                else //If the value dice is not already a key value
                {
                    //Add the key value and set the count equal to 1
                    counts[dice.DiceValue] = 1;
                }
            }

            int count = 0;

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of 3
                if (counts[key] == 3)
                    count++;
            }

            foreach (int key in counts.Keys)
            {
                //If one of the key values has a count of 2 and we've already incremented count in previous foreach loop
                if (counts[key] == 2 && count == 1)
                    count++;
            }

            if (count == 2)
                score = 25;

            return score;

        }

        public int scoreSmallStraight()
        {
            int score = 0;
            int[] tempValues = new int[allDice.Length];

            for (int i = 0; i < allDice.Length; i++)
            {
                tempValues[i] = allDice[i].DiceValue;
            }

            if (tempValues.Contains(1) && tempValues.Contains(2) && tempValues.Contains(3)
                && tempValues.Contains(4))
            {
                score = 30;
            }
            // If array contains 3, 4, 5, and either 2 or 6
            else if ((tempValues.Contains(3) && tempValues.Contains(4) && tempValues.Contains(5))
                        && (tempValues.Contains(6) || tempValues.Contains(2)))
            {
                score = 30;
            }

            return score;

        }

        public int scoreLargeStraight()
        {
            int score = 0;
            int[] tempValues = new int[allDice.Length];

            for (int i = 0; i < allDice.Length; i++)
            {
                tempValues[i] = allDice[i].DiceValue;
            }

            if (tempValues.Contains(1) && tempValues.Contains(2) && tempValues.Contains(3)
                && tempValues.Contains(4) && tempValues.Contains(5))
            {
                score = 40;
            }
            else if (tempValues.Contains(2) && tempValues.Contains(3) && tempValues.Contains(4)
                    && tempValues.Contains(5) && tempValues.Contains(6))
            {
                score = 40;
            }

            return score;

        }

        public int scoreYahtzee()
        {
            int score = 50;

            for (int i = 0; i < allDice.Length; i++)
            {
                for (int j = 1; j < allDice.Length; j++)
                {
                    if (allDice[i].DiceValue != allDice[j].DiceValue)
                        score = 0;
                }
            }

            return score;
        }

        public int scoreChance()
        {
            int score = 0;

            foreach (DiceBlock dice in allDice)
                score += dice.DiceValue;

            return score;
        }


        /*
         * 
         * ALL PICTURE BOX CLICK EVENT HANDLERS
         * 
         */

        private void dicePictureBox1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                return;

            if (allDice[0].IsHeld == false)
            {
                allDice[0].IsHeld = true;
                SetDiceImage(allDice);
            }
            else
            {
                allDice[0].IsHeld = false;
                SetDiceImage(allDice);
            }
        }

        private void dicePictureBox2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                return;
            if (allDice[1].IsHeld == false)
            {
                allDice[1].IsHeld = true;
                SetDiceImage(allDice);
            }
            else
            {
                allDice[1].IsHeld = false;
                SetDiceImage(allDice);
            }
        }

        private void dicePictureBox3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                return;
            if (allDice[2].IsHeld == false)
            {
                allDice[2].IsHeld = true;
                SetDiceImage(allDice);
            }
            else
            {
                allDice[2].IsHeld = false;
                SetDiceImage(allDice);
            }
        }

        private void dicePictureBox4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                return;
            if (allDice[3].IsHeld == false)
            {
                allDice[3].IsHeld = true;
                SetDiceImage(allDice);
            }
            else
            {
                allDice[3].IsHeld = false;
                SetDiceImage(allDice);
            }
        }

        private void dicePictureBox5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                return;
            if (allDice[4].IsHeld == false)
            {
                allDice[4].IsHeld = true;
                SetDiceImage(allDice);
            }
            else
            {
                allDice[4].IsHeld = false;
                SetDiceImage(allDice);
            }
        }


        /*
         * 
         * ALL MOUSE ENTER / MOUSE LEAVE EVENT HANDLERS
         * 
         */

        private void acesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (acesLabel.Text == "---" && turn > 1)
            {
                acesBGLabel.BackColor = Color.White;
                acesLabel.BackColor = Color.White;
            }

        }

        private void acesBGLabel_MouseLeave(object sender, EventArgs e)
        {

            acesBGLabel.BackColor = Color.Gainsboro;

            if (acesLabel.Text == "---")
            {
                acesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                acesLabel.BackColor = Color.Gold;
            } 
            
        }

        private void twosBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (twosLabel.Text == "---" && turn > 1)
            {
                twosBGLabel.BackColor = Color.White;
                twosLabel.BackColor = Color.White;
            }
        }

        private void twosBGLabel_MouseLeave(object sender, EventArgs e)
        {

            twosBGLabel.BackColor = Color.Gainsboro;

            if (twosLabel.Text == "---")
            {
                twosLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                twosLabel.BackColor = Color.Gold;
            }

        }

        private void threesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (threesLabel.Text == "---" && turn > 1)
            {
                threesBGLabel.BackColor = Color.White;
                threesLabel.BackColor = Color.White;
            }
        }

        private void threesBGLabel_MouseLeave(object sender, EventArgs e)
        {

            threesBGLabel.BackColor = Color.Gainsboro;

            if (threesLabel.Text == "---")
            {
                threesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                threesLabel.BackColor = Color.Gold;
            }

        }

        private void foursBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (foursLabel.Text == "---" && turn > 1)
            {
                foursBGLabel.BackColor = Color.White;
                foursLabel.BackColor = Color.White;
            }
        }

        private void foursBGLabel_MouseLeave(object sender, EventArgs e)
        {

            foursBGLabel.BackColor = Color.Gainsboro;

            if (foursLabel.Text == "---")
            {
                foursLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                foursLabel.BackColor = Color.Gold;
            }

        }

        private void fivesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (fivesLabel.Text == "---" && turn > 1)
            {
                fivesBGLabel.BackColor = Color.White;
                fivesLabel.BackColor = Color.White;
            }
        }

        private void fivesBGLabel_MouseLeave(object sender, EventArgs e)
        {

            fivesBGLabel.BackColor = Color.Gainsboro;

            if (fivesLabel.Text == "---")
            {
                fivesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fivesLabel.BackColor = Color.Gold;
            }

        }

        private void sixesBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (sixesLabel.Text == "---" && turn > 1)
            {
                sixesBGLabel.BackColor = Color.White;
                sixesLabel.BackColor = Color.White;
            }
        }

        private void sixesBGLabel_MouseLeave(object sender, EventArgs e)
        {

            sixesBGLabel.BackColor = Color.Gainsboro;

            if (sixesLabel.Text == "---")
            {
                sixesLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                sixesLabel.BackColor = Color.Gold;
            }

        }

        private void threeKindBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (threeOfAKindLabel.Text == "---" && turn > 1)
            {
                threeKindBGLabel.BackColor = Color.White;
                threeOfAKindLabel.BackColor = Color.White;
            }
        }

        private void threeKindBGLabel_MouseLeave(object sender, EventArgs e)
        {

            threeKindBGLabel.BackColor = Color.Gainsboro;

            if (threeOfAKindLabel.Text == "---")
            {
                threeOfAKindLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                threeOfAKindLabel.BackColor = Color.Gold;
            }

        }

        private void fourKindBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (fourOfAKindLabel.Text == "---" && turn > 1)
            {
                fourKindBGLabel.BackColor = Color.White;
                fourOfAKindLabel.BackColor = Color.White;
            }
        }

        private void fourKindBGLabel_MouseLeave(object sender, EventArgs e)
        {

            fourKindBGLabel.BackColor = Color.Gainsboro;

            if (fourOfAKindLabel.Text == "---")
            {
                fourOfAKindLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fourOfAKindLabel.BackColor = Color.Gold;
            }

        }

        private void fullHouseBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (fullHouseLabel.Text == "---" && turn > 1)
            {
                fullHouseBGLabel.BackColor = Color.White;
                fullHouseLabel.BackColor = Color.White;
            }
        }

        private void fullHouseBGLabel_MouseLeave(object sender, EventArgs e)
        {

            fullHouseBGLabel.BackColor = Color.Gainsboro;

            if (fullHouseLabel.Text == "---")
            {
                fullHouseLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                fullHouseLabel.BackColor = Color.Gold;
            }

        }

        private void smallStraightBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (smallStraightLabel.Text == "---" && turn > 1)
            {
                smallStraightBGLabel.BackColor = Color.White;
                smallStraightLabel.BackColor = Color.White;
            }
        }

        private void smallStraightBGLabel_MouseLeave(object sender, EventArgs e)
        {

            smallStraightBGLabel.BackColor = Color.Gainsboro;

            if (smallStraightLabel.Text == "---")
            {
                smallStraightLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                smallStraightLabel.BackColor = Color.Gold;
            }

        }

        private void largeStraightBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (largeStraightLabel.Text == "---" && turn > 1)
            {
                largeStraightBGLabel.BackColor = Color.White;
                largeStraightLabel.BackColor = Color.White;
            }
        }

        private void largeStraightBGLabel_MouseLeave(object sender, EventArgs e)
        {

            largeStraightBGLabel.BackColor = Color.Gainsboro;

            if (largeStraightLabel.Text == "---")
            {
                largeStraightLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                largeStraightLabel.BackColor = Color.Gold;
            }

        }

        private void yahtzeeBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (yahtzeeLabel.Text == "---" && turn > 1)
            {
                yahtzeeBGLabel.BackColor = Color.White;
                yahtzeeLabel.BackColor = Color.White;
            }
        }

        private void yahtzeeBGLabel_MouseLeave(object sender, EventArgs e)
        {

            yahtzeeBGLabel.BackColor = Color.Gainsboro;

            if (yahtzeeLabel.Text == "---")
            {
                yahtzeeLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                yahtzeeLabel.BackColor = Color.Gold;
            }

        }

        private void chanceBGLabel_MouseEnter(object sender, EventArgs e)
        {
            //Code that allows both labels to act the same was placed in the GameWindow.Designer file
            if (chanceLabel.Text == "---" && turn > 1)
            {
                chanceBGLabel.BackColor = Color.White;
                chanceLabel.BackColor = Color.White;
            }
        }

        private void chanceBGLabel_MouseLeave(object sender, EventArgs e)
        {

            chanceBGLabel.BackColor = Color.Gainsboro;

            if (chanceLabel.Text == "---")
            {
                chanceLabel.BackColor = Color.Gainsboro;
            }
            else
            {
                chanceLabel.BackColor = Color.Gold;
            }

        }

    }
}
